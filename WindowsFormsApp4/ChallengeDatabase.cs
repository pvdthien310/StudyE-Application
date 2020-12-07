﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class ChallengeDatabase : Database
    {

        public ChallengeDatabase()
        {
            list = new List<Word>(500);
            this.LoadDataFromSQL();
        }
        public ChallengeDatabase(Word member)
        {
            list.Add(member);
        }
        protected override void LoadDataFromSQL()
        {
            list.Clear(); // Xóa dữ liệu để tránh bug ngoài ý muốn

<<<<<<< HEAD
            SqlConnection mycntSW = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True"); // Của Thắng
            //SqlConnection mycntSW = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=StudyE;Integrated Security=True"); // Của Thiên
=======
            SqlConnection mycntSW = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=StudyE;Integrated Security=True");
>>>>>>> b92f7063894f3466f19de90f07598dfb0e89cb1b
            mycntSW.Open();
            // lay het du lieu trong bang DTBQT 
            SqlCommand com = new SqlCommand("SELECT TOP 500 ID,NAME,MEANING FROM EV_Source ORDER BY NEWID()", mycntSW);
            //com.CommandTimeout = 150;
            //SqlCommand com = new SqlCommand("SELECT * FROM TableSource1", mycntSW); //bat dau truy van
            //com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho

            foreach (DataRow row in dt.Rows)
            {
                int ID = Convert.ToInt32(row["ID"].ToString());
                string Name = row["Name"].ToString();
                string Meaning = row["Meaning"].ToString();
                list.Add(new Word(ID, Name, Meaning));
            }
            mycntSW.Close();
        }
    }
}
