// using System;
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
                SqlConnection myConnection = new SqlConnection("server=" + ServerName + ";database=" + Database + ";connection timeout=5;uid=" + Username + ";password=" + Password); /* for user auth add Trusted_Connection = yes; before database name*/

                if (ServerName == "")
                {

                    MessageBox.Show("Missing Server Name");
                }
                else if (Database == "")
                {
                    MessageBox.Show("missing Database name");
                }
                else if (Username == "")
                {
                    MessageBox.Show("missing SQL username");
                }
                else if (Password == "")
                {
                    MessageBox.Show("missing SQL Password");
                }
                else
                {
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = ("sp_help"); 
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myConnection;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("well done!");
                }

           }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex.Message);
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
                string env = envcombo.Text;

                if (ServerName == "")
                {

                    MessageBox.Show("Missing Server Name");
                }
                else if (Database == "")
                {
                    MessageBox.Show("missing Database name");
                }
                else if (Username == "")
                {
                    MessageBox.Show("missing SQL username");
                }
                else if (Password == "")
                {
                    MessageBox.Show("missing SQL Password");
                }
                else if (env == "")
                {
                    MessageBox.Show("Missing Environment");
                }
                else
                {
                    SqlConnection myConnection = new SqlConnection("server=" + ServerName + ";database=" + Database + ";connection timeout=90;uid=" + Username + ";password=" + Password); /* for user auth add Trusted_Connection = yes; before database name*/
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    DateTime now = DateTime.Now;
                    string date = now.GetDateTimeFormats('d')[5];
                    string path = (@"'c:\test\" + Database + date + "_" + env + ".bak'"); /*backup file location and name*/
                    cmd.CommandText = ("use master BACKUP DATABASE " + Database + " to disk=" + path); /*SQL script to run a backup of the database*/
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myConnection;
                    cmd.ExecuteNonQuery();
                }

                //FTP Credental
                string FTPuser = FTPusertxt.Text;
                string FTPpassword = FTPpasswordtxt.Text;
                string FTPsite = FTPSitetxt.Text;
                string FTPenv = envcombo.Text;

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
                else
                {
                    DateTime now = DateTime.Now;
                    string date = now.GetDateTimeFormats('d')[5];
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPsite + "/" + Database + date + FTPenv + ".bak");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(FTPuser, FTPpassword);
                    //uploading file
                    System.IO.FileInfo fi = new System.IO.FileInfo(@"c:\test\" + Database + date + "_" + FTPenv + ".bak");
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
                }
                MessageBox.Show("complete");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
    }
}
