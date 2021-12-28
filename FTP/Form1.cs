using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net;
using Renci.SshNet;

namespace FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> filelist;
        string zipfilelocation;
        string copypath, zippath;
        private void brwsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                copypath = Path.Combine(Environment.CurrentDirectory, @"file\copy");
                zippath = Path.Combine(Environment.CurrentDirectory, @"file\zip");

                if (!Directory.Exists(copypath))
                {
                    Directory.CreateDirectory(copypath);
                }
                else
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(copypath);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                }
                if (!Directory.Exists(zippath))
                {
                    Directory.CreateDirectory(zippath);
                }
                else
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(zippath);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                }


                var o = new OpenFileDialog();
                o.Multiselect = true;

                if (o.ShowDialog() == DialogResult.OK)
                {
                    filelist = new List<string>();
                    int i = 0;
                    foreach (var originalfilepath in o.FileNames)
                    {
                        filelist.Add(o.SafeFileNames[i]);
                        string destFile = Path.Combine(copypath, o.SafeFileNames[i]);
                        File.Copy(originalfilepath, destFile, true);
                        i++;
                    }
                }
                textBox1.Text = string.Join(Environment.NewLine, filelist);

                zipfilelocation = FileZip();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string FileZip()
        {
            try
            {
                ZipFile.CreateFromDirectory(copypath, zippath);

                return zippath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void SFTPUpload()
        {
            try
            {
                var connectionInfo = new ConnectionInfo(sftphost.Text, sftpun.Text, new PasswordAuthenticationMethod(sftpun.Text, sftppw.Text));

                using (var sftp = new SftpClient(connectionInfo))
                {

                    sftp.Connect();
                    using (var uplfileStream = System.IO.File.OpenRead(zipfilelocation))
                    {
                        sftp.UploadFile(uplfileStream, ziptext.Text + ".zip", true);
                    }
                    sftp.Disconnect();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FTPUpload()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftphost.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new NetworkCredential(ftpun.Text, ftppw.Text);

                byte[] fileContents;
                using (StreamReader sourceStream = new StreamReader(zipfilelocation))
                {
                    fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                }

                request.ContentLength = fileContents.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }
                MessageBox.Show("Upload File Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ftpuploadbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zipfilelocation) && !string.IsNullOrEmpty(ziptext.Text) && !string.IsNullOrEmpty(ftphost.Text) && !string.IsNullOrEmpty(ftpun.Text) && !string.IsNullOrEmpty(ftppw.Text))
            {
                FTPUpload();
            }
            else
            {
                MessageBox.Show("Zip file name and FTP detail canot be null");
            }
        }

        private void sftpuploadbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zipfilelocation) && !string.IsNullOrEmpty(ziptext.Text) && !string.IsNullOrEmpty(sftphost.Text) && !string.IsNullOrEmpty(sftpun.Text) && !string.IsNullOrEmpty(sftppw.Text))
            {
                SFTPUpload();
            }
            else
            {
                MessageBox.Show("Zip file name and SFTP detail canot be null");
            }
        }
    }
}
