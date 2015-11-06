namespace BackupForm
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
            this.lblservername = new System.Windows.Forms.Label();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.lblsqlusername = new System.Windows.Forms.Label();
            this.lblSQLPassword = new System.Windows.Forms.Label();
            this.lblenvironment = new System.Windows.Forms.Label();
            this.ServerNametxt = new System.Windows.Forms.TextBox();
            this.Databasenametxt = new System.Windows.Forms.TextBox();
            this.SqlUserNametxt = new System.Windows.Forms.TextBox();
            this.envcombo = new System.Windows.Forms.ComboBox();
            this.SQLPasswordtxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FTPSitelbl = new System.Windows.Forms.Label();
            this.FTPUserlbl = new System.Windows.Forms.Label();
            this.FTPPasswordlbl = new System.Windows.Forms.Label();
            this.Testbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.FTPusertxt = new System.Windows.Forms.TextBox();
            this.FTPpasswordtxt = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FTPSitetxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.PathDirectorytxt = new System.Windows.Forms.TextBox();
            this.FTPDirectorytxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblservername
            // 
            this.lblservername.AutoSize = true;
            this.lblservername.Location = new System.Drawing.Point(33, 86);
            this.lblservername.Name = "lblservername";
            this.lblservername.Size = new System.Drawing.Size(136, 13);
            this.lblservername.TabIndex = 0;
            this.lblservername.Text = "SQL ServerName/Instance";
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(36, 136);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(84, 13);
            this.lblDataBase.TabIndex = 1;
            this.lblDataBase.Text = "Database Name";
            // 
            // lblsqlusername
            // 
            this.lblsqlusername.AutoSize = true;
            this.lblsqlusername.Location = new System.Drawing.Point(33, 182);
            this.lblsqlusername.Name = "lblsqlusername";
            this.lblsqlusername.Size = new System.Drawing.Size(79, 13);
            this.lblsqlusername.TabIndex = 2;
            this.lblsqlusername.Text = "SQL Username";
            // 
            // lblSQLPassword
            // 
            this.lblSQLPassword.AutoSize = true;
            this.lblSQLPassword.Location = new System.Drawing.Point(36, 233);
            this.lblSQLPassword.Name = "lblSQLPassword";
            this.lblSQLPassword.Size = new System.Drawing.Size(77, 13);
            this.lblSQLPassword.TabIndex = 3;
            this.lblSQLPassword.Text = "SQL Password";
            // 
            // lblenvironment
            // 
            this.lblenvironment.AutoSize = true;
            this.lblenvironment.Location = new System.Drawing.Point(387, 96);
            this.lblenvironment.Name = "lblenvironment";
            this.lblenvironment.Size = new System.Drawing.Size(66, 13);
            this.lblenvironment.TabIndex = 5;
            this.lblenvironment.Text = "Environment";
            // 
            // ServerNametxt
            // 
            this.ServerNametxt.Location = new System.Drawing.Point(206, 79);
            this.ServerNametxt.Name = "ServerNametxt";
            this.ServerNametxt.Size = new System.Drawing.Size(134, 20);
            this.ServerNametxt.TabIndex = 6;
            // 
            // Databasenametxt
            // 
            this.Databasenametxt.Location = new System.Drawing.Point(206, 129);
            this.Databasenametxt.Name = "Databasenametxt";
            this.Databasenametxt.Size = new System.Drawing.Size(100, 20);
            this.Databasenametxt.TabIndex = 7;
            // 
            // SqlUserNametxt
            // 
            this.SqlUserNametxt.Location = new System.Drawing.Point(206, 175);
            this.SqlUserNametxt.Name = "SqlUserNametxt";
            this.SqlUserNametxt.Size = new System.Drawing.Size(100, 20);
            this.SqlUserNametxt.TabIndex = 8;
            // 
            // envcombo
            // 
            this.envcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.envcombo.FormattingEnabled = true;
            this.envcombo.Items.AddRange(new object[] {
            "UIT",
            "PROD"});
            this.envcombo.Location = new System.Drawing.Point(460, 86);
            this.envcombo.Name = "envcombo";
            this.envcombo.Size = new System.Drawing.Size(121, 21);
            this.envcombo.TabIndex = 10;
            // 
            // SQLPasswordtxt
            // 
            this.SQLPasswordtxt.Location = new System.Drawing.Point(206, 226);
            this.SQLPasswordtxt.Name = "SQLPasswordtxt";
            this.SQLPasswordtxt.Size = new System.Drawing.Size(100, 20);
            this.SQLPasswordtxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "SQL Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "FTP Information";
            // 
            // FTPSitelbl
            // 
            this.FTPSitelbl.AutoSize = true;
            this.FTPSitelbl.Location = new System.Drawing.Point(36, 345);
            this.FTPSitelbl.Name = "FTPSitelbl";
            this.FTPSitelbl.Size = new System.Drawing.Size(48, 13);
            this.FTPSitelbl.TabIndex = 14;
            this.FTPSitelbl.Text = "FTP Site";
            // 
            // FTPUserlbl
            // 
            this.FTPUserlbl.AutoSize = true;
            this.FTPUserlbl.Location = new System.Drawing.Point(36, 378);
            this.FTPUserlbl.Name = "FTPUserlbl";
            this.FTPUserlbl.Size = new System.Drawing.Size(52, 13);
            this.FTPUserlbl.TabIndex = 15;
            this.FTPUserlbl.Text = "FTP User";
            // 
            // FTPPasswordlbl
            // 
            this.FTPPasswordlbl.AutoSize = true;
            this.FTPPasswordlbl.Location = new System.Drawing.Point(36, 409);
            this.FTPPasswordlbl.Name = "FTPPasswordlbl";
            this.FTPPasswordlbl.Size = new System.Drawing.Size(76, 13);
            this.FTPPasswordlbl.TabIndex = 16;
            this.FTPPasswordlbl.Text = "FTP Password";
            // 
            // Testbtn
            // 
            this.Testbtn.Location = new System.Drawing.Point(448, 223);
            this.Testbtn.Name = "Testbtn";
            this.Testbtn.Size = new System.Drawing.Size(75, 23);
            this.Testbtn.TabIndex = 17;
            this.Testbtn.Text = "SQL test";
            this.Testbtn.UseVisualStyleBackColor = true;
            this.Testbtn.Click += new System.EventHandler(this.Testbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(421, 439);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 18;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // FTPusertxt
            // 
            this.FTPusertxt.Location = new System.Drawing.Point(206, 370);
            this.FTPusertxt.Name = "FTPusertxt";
            this.FTPusertxt.Size = new System.Drawing.Size(100, 20);
            this.FTPusertxt.TabIndex = 20;
            // 
            // FTPpasswordtxt
            // 
            this.FTPpasswordtxt.Location = new System.Drawing.Point(206, 401);
            this.FTPpasswordtxt.Name = "FTPpasswordtxt";
            this.FTPpasswordtxt.Size = new System.Drawing.Size(100, 20);
            this.FTPpasswordtxt.TabIndex = 21;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 439);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 24);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 22;
            // 
            // FTPSitetxt
            // 
            this.FTPSitetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FTPSitetxt.FormattingEnabled = true;
            this.FTPSitetxt.Items.AddRange(new object[] {
            "ftp://ftp2.upsidesoft.com",
            "ftp://ftp3.upsidesoft.com"});
            this.FTPSitetxt.Location = new System.Drawing.Point(206, 336);
            this.FTPSitetxt.Name = "FTPSitetxt";
            this.FTPSitetxt.Size = new System.Drawing.Size(121, 21);
            this.FTPSitetxt.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Path for backup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Location of the backup file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Broswse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(555, 440);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 27;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click_1);
            // 
            // PathDirectorytxt
            // 
            this.PathDirectorytxt.Location = new System.Drawing.Point(481, 179);
            this.PathDirectorytxt.Name = "PathDirectorytxt";
            this.PathDirectorytxt.Size = new System.Drawing.Size(100, 20);
            this.PathDirectorytxt.TabIndex = 28;
            // 
            // FTPDirectorytxt
            // 
            this.FTPDirectorytxt.Location = new System.Drawing.Point(543, 337);
            this.FTPDirectorytxt.Name = "FTPDirectorytxt";
            this.FTPDirectorytxt.Size = new System.Drawing.Size(100, 20);
            this.FTPDirectorytxt.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 499);
            this.Controls.Add(this.FTPDirectorytxt);
            this.Controls.Add(this.PathDirectorytxt);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FTPSitetxt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FTPpasswordtxt);
            this.Controls.Add(this.FTPusertxt);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.Testbtn);
            this.Controls.Add(this.FTPPasswordlbl);
            this.Controls.Add(this.FTPUserlbl);
            this.Controls.Add(this.FTPSitelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SQLPasswordtxt);
            this.Controls.Add(this.envcombo);
            this.Controls.Add(this.SqlUserNametxt);
            this.Controls.Add(this.Databasenametxt);
            this.Controls.Add(this.ServerNametxt);
            this.Controls.Add(this.lblenvironment);
            this.Controls.Add(this.lblSQLPassword);
            this.Controls.Add(this.lblsqlusername);
            this.Controls.Add(this.lblDataBase);
            this.Controls.Add(this.lblservername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblservername;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Label lblsqlusername;
        private System.Windows.Forms.Label lblSQLPassword;
        private System.Windows.Forms.Label lblenvironment;
        private System.Windows.Forms.TextBox ServerNametxt;
        private System.Windows.Forms.TextBox Databasenametxt;
        private System.Windows.Forms.TextBox SqlUserNametxt;
        private System.Windows.Forms.ComboBox envcombo;
        private System.Windows.Forms.MaskedTextBox SQLPasswordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FTPSitelbl;
        private System.Windows.Forms.Label FTPUserlbl;
        private System.Windows.Forms.Label FTPPasswordlbl;
        private System.Windows.Forms.Button Testbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.TextBox FTPusertxt;
        private System.Windows.Forms.TextBox FTPpasswordtxt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox FTPSitetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.TextBox PathDirectorytxt;
        private System.Windows.Forms.TextBox FTPDirectorytxt;
    }
}

