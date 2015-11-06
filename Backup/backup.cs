using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection myConnection = new SqlConnection(@"server=.\sqlexpress;database=Adventureworks2012;connection timeout=90; uid=testuser; password=password"); /* for user auth add Trusted_Connection = yes; before database name*/
            
            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand();
                string database = "AdventureWorks2012"; /*database name*/
                DateTime now = DateTime.Now;
                string date = now.GetDateTimeFormats('d')[5];
                string path = (@"'c:\test\"+ database + date + ".bak'"); /*backup file location and name*/
                cmd.CommandText = ("use master BACKUP DATABASE " + database + " to disk=" + path); /*SQL script to run a backup of the database*/
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myConnection;
                cmd.ExecuteNonQuery();

                //FTP Credental
                string ftpuser = "AltaLink";
                string password = "A$k67924";
                //FTP connection
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@"ftp://66.46.108.120/" + database + date + ".bak");
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential (ftpuser, password);

                //uploading file
                System.IO.FileInfo fi = new System.IO.FileInfo(@"c:\test\"+ database + date + ".bak");
                request.ContentLength = fi.Length;
                byte[] buffer = new byte[4097];
                int bytes = 2048;
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
                /*//upload
                string filepath =  path(value.ToString(ftp://ftp2.upsidesoft.com/AltaLink));
                StreamReader upload = new StreamReader(path);
                byte [] fileContents = Encoding.UTF8.GetBytes(upload.ReadToEnd()); 
                upload.Close();
                request.ContentLength = fileContents.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                //complete*/
                Console.WriteLine("Well done!");
                Console.ReadKey();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("You failed! " + ex.Message);
                Console.ReadKey();
            }
            myConnection.Close();
        }
    }
}
