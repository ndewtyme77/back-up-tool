using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.SqlServer.Server;
using System.Net;

namespace BackupForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Testbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ServerName = ServerNametxt.Text;
                string Database = Databasenametxt.Text;
                string Username = SqlUserNametxt.Text;
                string Password = SQLPasswordtxt.Text;
                string Directory = PathDirectorytxt.Text;
                SqlConnection myConnection = new SqlConnection("server=" + ServerName + ";database=" + Database + ";connection timeout=5;uid=" + Username + ";password=" + Password); /* for user auth add Trusted_Connection = yes; before database name*/

                if (ServerName == "")
                {

                    MessageBox.Show("Missing Server Name");
                }
                else if (Database == "")
                {
                    MessageBox.Show("Missing Database name");
                }
                else if (Username == "")
                {
                    MessageBox.Show("Missing SQL username");
                }
                else if (Password == "")
                {
                    MessageBox.Show("Missing SQL Password");
                }

                else
                {
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = ("sp_help"); 
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myConnection;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection was successful");
                }

           }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ServerName = ServerNametxt.Text;
                string Database = Databasenametxt.Text;
                string Username = SqlUserNametxt.Text;
                string Password = SQLPasswordtxt.Text;
                string Directory = PathDirectorytxt.Text;
                string env = envcombo.Text;
                SqlConnection myConnection = new SqlConnection("server=" + ServerName + ";database=" + Database + ";uid=" + Username + ";password=" + Password + ";connection timeout=1200"); /* for user auth add Trusted_Connection = yes; before database name  ;connection timeout=1200*/
                if (ServerName == "")
                {
                    MessageBox.Show("Missing Server Name.");
                }
                else if (Database == "")
                {
                    MessageBox.Show("Missing Database name.");
                }
                else if (Username == "")
                {
                    MessageBox.Show("Missing SQL username.");
                }
                else if (Password == "")
                {
                    MessageBox.Show("Missing SQL Password.");
                }
                else if (env == "")
                {
                    MessageBox.Show("Missing Environment.");
                }
                else if (Directory == "")
                {
                    MessageBox.Show("Missing Directory.");
                }
                else
                {
                    progressBar1.Value = 0;
                    progressBar1.Value += 10;
                    /*SqlConnection myConnection = new SqlConnection("server=" + ServerName + ";database=" + Database + ";uid=" + Username + ";password=" + Password);  for user auth add Trusted_Connection = yes; before database name  ;connection timeout=1200*/
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    DateTime now = DateTime.Now;
                    string date = now.GetDateTimeFormats('d')[5];
                    string path = ("'"+Directory + Database + date + "_" + env + ".bak'"); /*backup file location and name*/
                    cmd.CommandText = ("use master BACKUP DATABASE " + Database + " to disk=" + path+" WITH NOFORMAT, NOINIT,  NAME = N'"+ Database +"-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 100"); /*SQL script to run a backup of the database*/
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myConnection;
                    cmd.ExecuteNonQuery();
                    progressBar1.Value += 20;

                }

                //FTP Credental
                string FTPuser = FTPusertxt.Text;
                string FTPpassword = FTPpasswordtxt.Text;
                string FTPsite = FTPSitetxt.Text;
                string FTPenv = envcombo.Text;
                string FTPDirectory = FTPDirectorytxt.Text;

                //FTP connection

                if (FTPsite == "")
                {
                    MessageBox.Show("Missing FTP Site");
                }
                else if (FTPuser == "")
                {
                    MessageBox.Show("missing FTP user");
                }
                else if (FTPpassword == "")
                {
                    MessageBox.Show("Missing FTP password");
                }
                else if (FTPDirectory == "")
                {
                    MessageBox.Show("Missing FTP Directory password");
                }
                else
                {
                    progressBar1.Value += 30;
                    MessageBox.Show("SQL back up is complete, now starting to upload the file to the " + FTPsite + ".");
                    DateTime now = DateTime.Now;
                    string date = now.GetDateTimeFormats('d')[5];
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPsite + "/" + Database + date + "_" + FTPenv + ".bak");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(FTPuser, FTPpassword);
                    progressBar1.Value += 20;
                    //uploading file
                    System.IO.FileInfo fi = new System.IO.FileInfo(FTPDirectory + Database + date + "_" + FTPenv + ".bak");
                    request.ContentLength = fi.Length;
                    byte[] buffer = new byte[4097];
                    int bytes = 4069;
                    int total_bytes = (int)fi.Length;
                    System.IO.FileStream fs = fi.OpenRead();
                    System.IO.Stream rs = request.GetRequestStream();
                    while (total_bytes > 0)
                    {
                        bytes = fs.Read(buffer, 0, buffer.Length);
                        rs.Write(buffer, 0, bytes);
                        total_bytes = total_bytes - bytes;
                    }
                    //fs.Flush();
                    fs.Close();
                    rs.Close();
                    FtpWebResponse uploadResponse = (FtpWebResponse)request.GetResponse();
                    //value = uploadResponse.StatusDescription;
                    uploadResponse.Close();
                    //removes backup file
                    try
                    {
                        System.IO.File.Delete(FTPDirectory + Database + date + "_" + FTPenv + ".bak");
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                    }
                    
                
                }
                
                progressBar1.Value += 20;
                MessageBox.Show("Task is Complete");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void envcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderdb = new FolderBrowserDialog();
            if (folderdb.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            string folderlocation = folderdb.SelectedPath;
            FTPDirectorytxt.Text =(folderlocation +"\\");
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
