namespace FTP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ftpuploadbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.brwsbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ftppw = new System.Windows.Forms.TextBox();
            this.ftpun = new System.Windows.Forms.TextBox();
            this.ftphost = new System.Windows.Forms.TextBox();
            this.SFTP = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sftpuploadbtn = new System.Windows.Forms.Button();
            this.sftppw = new System.Windows.Forms.TextBox();
            this.sftpun = new System.Windows.Forms.TextBox();
            this.sftphost = new System.Windows.Forms.TextBox();
            this.ziptext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SFTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // ftpuploadbtn
            // 
            this.ftpuploadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpuploadbtn.Location = new System.Drawing.Point(247, 101);
            this.ftpuploadbtn.Name = "ftpuploadbtn";
            this.ftpuploadbtn.Size = new System.Drawing.Size(114, 29);
            this.ftpuploadbtn.TabIndex = 0;
            this.ftpuploadbtn.Text = "FTP Upload";
            this.ftpuploadbtn.UseVisualStyleBackColor = true;
            this.ftpuploadbtn.Click += new System.EventHandler(this.ftpuploadbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 304);
            this.textBox1.TabIndex = 1;
            // 
            // brwsbtn
            // 
            this.brwsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwsbtn.Location = new System.Drawing.Point(493, 322);
            this.brwsbtn.Name = "brwsbtn";
            this.brwsbtn.Size = new System.Drawing.Size(93, 29);
            this.brwsbtn.TabIndex = 2;
            this.brwsbtn.Text = "Browse";
            this.brwsbtn.UseVisualStyleBackColor = true;
            this.brwsbtn.Click += new System.EventHandler(this.brwsbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ftpuploadbtn);
            this.groupBox1.Controls.Add(this.ftppw);
            this.groupBox1.Controls.Add(this.ftpun);
            this.groupBox1.Controls.Add(this.ftphost);
            this.groupBox1.Location = new System.Drawing.Point(596, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host";
            // 
            // ftppw
            // 
            this.ftppw.Location = new System.Drawing.Point(88, 71);
            this.ftppw.Name = "ftppw";
            this.ftppw.Size = new System.Drawing.Size(273, 20);
            this.ftppw.TabIndex = 2;
            // 
            // ftpun
            // 
            this.ftpun.Location = new System.Drawing.Point(88, 45);
            this.ftpun.Name = "ftpun";
            this.ftpun.Size = new System.Drawing.Size(273, 20);
            this.ftpun.TabIndex = 1;
            // 
            // ftphost
            // 
            this.ftphost.Location = new System.Drawing.Point(88, 19);
            this.ftphost.Name = "ftphost";
            this.ftphost.Size = new System.Drawing.Size(273, 20);
            this.ftphost.TabIndex = 0;
            // 
            // SFTP
            // 
            this.SFTP.Controls.Add(this.label4);
            this.SFTP.Controls.Add(this.label5);
            this.SFTP.Controls.Add(this.label6);
            this.SFTP.Controls.Add(this.sftpuploadbtn);
            this.SFTP.Controls.Add(this.sftppw);
            this.SFTP.Controls.Add(this.sftpun);
            this.SFTP.Controls.Add(this.sftphost);
            this.SFTP.Location = new System.Drawing.Point(596, 207);
            this.SFTP.Name = "SFTP";
            this.SFTP.Size = new System.Drawing.Size(377, 144);
            this.SFTP.TabIndex = 6;
            this.SFTP.TabStop = false;
            this.SFTP.Text = "SFTP Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "User name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Host";
            // 
            // sftpuploadbtn
            // 
            this.sftpuploadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sftpuploadbtn.Location = new System.Drawing.Point(247, 101);
            this.sftpuploadbtn.Name = "sftpuploadbtn";
            this.sftpuploadbtn.Size = new System.Drawing.Size(114, 29);
            this.sftpuploadbtn.TabIndex = 0;
            this.sftpuploadbtn.Text = "SFTP Upload";
            this.sftpuploadbtn.UseVisualStyleBackColor = true;
            this.sftpuploadbtn.Click += new System.EventHandler(this.sftpuploadbtn_Click);
            // 
            // sftppw
            // 
            this.sftppw.Location = new System.Drawing.Point(88, 71);
            this.sftppw.Name = "sftppw";
            this.sftppw.Size = new System.Drawing.Size(273, 20);
            this.sftppw.TabIndex = 2;
            // 
            // sftpun
            // 
            this.sftpun.Location = new System.Drawing.Point(88, 45);
            this.sftpun.Name = "sftpun";
            this.sftpun.Size = new System.Drawing.Size(273, 20);
            this.sftpun.TabIndex = 1;
            // 
            // sftphost
            // 
            this.sftphost.Location = new System.Drawing.Point(88, 19);
            this.sftphost.Name = "sftphost";
            this.sftphost.Size = new System.Drawing.Size(273, 20);
            this.sftphost.TabIndex = 0;
            // 
            // ziptext
            // 
            this.ziptext.Location = new System.Drawing.Point(698, 23);
            this.ziptext.Name = "ziptext";
            this.ziptext.Size = new System.Drawing.Size(211, 20);
            this.ziptext.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(603, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Zip file name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(915, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = ".zip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 363);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ziptext);
            this.Controls.Add(this.SFTP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.brwsbtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "FTP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SFTP.ResumeLayout(false);
            this.SFTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ftpuploadbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button brwsbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ftppw;
        private System.Windows.Forms.TextBox ftpun;
        private System.Windows.Forms.TextBox ftphost;
        private System.Windows.Forms.GroupBox SFTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sftpuploadbtn;
        private System.Windows.Forms.TextBox sftppw;
        private System.Windows.Forms.TextBox sftpun;
        private System.Windows.Forms.TextBox sftphost;
        private System.Windows.Forms.TextBox ziptext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

