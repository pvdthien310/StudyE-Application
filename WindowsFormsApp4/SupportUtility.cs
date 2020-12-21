﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class SupportUtility
    {
        // DESKTOP-E6SJOH8
        
        //public static SqlConnection MyCnt = new SqlConnection(@"Server=tcp:study-e.database.windows.net,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=study-e;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public  static SqlConnection MyCnt = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
        
        static string HostEmail = "19522216@gm.uit.edu.vn";
        static string HostPass = "15062001minhthang";
        public static bool IsCorrectAccount(string Name_Email, string Pass)
        {
            string name = "";
            string email = "";
            string pass = "";
            MyCnt.Open();
            string query = "select * from UserAccount where convert(varbinary,Email) = convert(varbinary,'" + Name_Email + "') and convert(varbinary,PassWord) = convert(varbinary,'" + Pass + "') or convert(varbinary,UserName) = convert(varbinary, '" + Name_Email + "')  and convert(varbinary,PassWord) = convert(varbinary,'" + Pass + "')";
            SqlCommand com = new SqlCommand(query, MyCnt); // truy van cau lenh vao sql
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            MyCnt.Close();
            if (dt.Rows.Count > 0)
            {
                name = dt.Rows[0]["UserName"].ToString();
                email = dt.Rows[0]["Email"].ToString();
                pass = dt.Rows[0]["PassWord"].ToString();
            }
            else
            {
                return false;
            }
            // -----
            if ( (name == Name_Email || email == Name_Email) && pass == Pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsExistAccount(string Name_Email)
        {
            MyCnt.Open();
            string query = "select * from UserAccount where convert(varbinary,Email) = convert(varbinary,'" + Name_Email + "') " + " or convert(varbinary,UserName) = convert(varbinary, '" + Name_Email + "')";
            SqlCommand com = new SqlCommand(query, MyCnt); // truy van cau lenh vao sql
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            MyCnt.Close();

            //------
            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsExistEmail(string Email)
        {
            MyCnt.Open();
            string query = "select * from UserAccount where convert(varbinary,Email) = convert(varbinary,'" + Email + "')";
            SqlCommand com = new SqlCommand(query, MyCnt); // truy van cau lenh vao sql
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            MyCnt.Close();

            //-------
            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void CreateAccount(string Email, string Name, string Pass)
        {
            int maxID;
            MyCnt.Open();
            string query = "select Max(ID) as MAX_ID from UserAccount";
            SqlCommand com = new SqlCommand(query, MyCnt); // truy van cau lenh vao sql
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            MyCnt.Close();

            //--------
            if(dt.Rows.Count>0)
            {
                try
                {
                    maxID = Convert.ToInt32(dt.Rows[0]["MAX_ID"]);
                }  
                catch(Exception)
                {
                    maxID = 0;
                }
            } 
            else
            {
                maxID = 0;
            }

            MyCnt.Open();
            string insertString = "INSERT INTO UserAccount (ID,UserName,PassWord,Email,IsSave) VALUES (" + "'" + (++maxID).ToString() + "','" + Name + "','" + Pass + "','" + Email + "','" + "0')";
            SqlCommand com2 = new SqlCommand(insertString, MyCnt);
            com2.ExecuteNonQuery();
            MyCnt.Close();
        }
        public static void SendConfirmEmailToCreateAccount(string DestinationEmail, string VerifyCode)
        {
            string Subject = "CONFIRMATION ACCOUNT";
            string Body = "Thanks for using our application, this is your verify code: ";

            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.Credentials = new NetworkCredential(HostEmail, HostPass);
            MailMessage message = new MailMessage();
            message.To.Add(DestinationEmail);
            message.From = new MailAddress(HostEmail, "STUDY-E COMPANY");
            message.IsBodyHtml = true;
            message.Subject = Subject;
            message.Body = Body + "<h1>" + VerifyCode + "</h1>";
            mailClient.Send(message);
        }
        public static void SendConfirmEmailToResetPassword(string DestinationEmail, string VerifyCode)
        {
            string Subject = "VERIFY CODE";
            string Body = "This is your verify code: ";

            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.Credentials = new NetworkCredential(HostEmail, HostPass);
            //MailMessage message = new MailMessage(HostEmail, DestinationEmail);
            MailMessage message = new MailMessage();
            message.To.Add(DestinationEmail);
            message.From = new MailAddress(HostEmail, "STUDY-E COMPANY");
            message.IsBodyHtml = true;
            message.Subject = Subject;
            message.Body = Body + "<h1>" + VerifyCode + "</h1>";
            mailClient.Send(message);
        }
        public static string HashPassword(string Pass)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Pass);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            string Result = "";
            for(int i = 0;i<hash.Length; i++)
            {
                Result += hash[i].ToString();
            }    
            return Result;
        }
        public static void ResetPassword(string Email,string Name, string Pass)
        {
            MyCnt.Open();
            string replaceString = "Update UserAccount set PassWord = '" + Pass + "' where Email = '" + Email + "'";
            string replaceString2 = "Update UserAccount set UserName = '" + Name + "' where Email = '" + Email + "'";
            SqlCommand com2 = new SqlCommand(replaceString, MyCnt);
            SqlCommand com3 = new SqlCommand(replaceString2, MyCnt);
            com2.ExecuteNonQuery();
            com3.ExecuteNonQuery();
            MyCnt.Close();
        }
        public static void SaveAccount(string Name, string Pass)
        {
            MyCnt.Open();
            string replaceString = "Update UserAccount set IsSave = '" + "1" + "' where Email = '" + Name + "' or UserName = '" + Name + "'";
            SqlCommand com2 = new SqlCommand(replaceString, MyCnt);
            com2.ExecuteNonQuery();
            MyCnt.Close();
        }
        public static void UnSaveAccount(string Name)
        {
            MyCnt.Open();
            string replaceString = "Update UserAccount set IsSave = '" + "0" + "' where Email = '" + Name + "' or UserName = '" + Name + "'";
            SqlCommand com2 = new SqlCommand(replaceString, MyCnt);
            com2.ExecuteNonQuery();
            MyCnt.Close();
        }
        public static void UnSaveAccount()
        {
            MyCnt.Open();
            string replaceString = "Update UserAccount set IsSave = '" + "0" + "'";
            SqlCommand com2 = new SqlCommand(replaceString, MyCnt);
            com2.ExecuteNonQuery();
            MyCnt.Close();
        }
        public static DataTable FindSavedAccount()
        {
            DataTable Result = new DataTable();
            MyCnt.Open();
            string query = "select * from UserAccount where IsSave = 1";
            SqlCommand com = new SqlCommand(query, MyCnt);
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(Result);
            MyCnt.Close();
            return Result;
        }
    }
}
