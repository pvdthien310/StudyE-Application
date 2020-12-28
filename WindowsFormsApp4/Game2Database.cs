using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Game2Database
    {
        public List<Word> list; // chua cau hoi type 1
        public List<Sentences> list2;  // chua cau hoi cua type 2
        static string path = Environment.CurrentDirectory;
        static string collabString = @ConfigurationManager.AppSettings["ConnectString_Head"] + path + "\\" + ConfigurationManager.AppSettings["Name"] + ConfigurationManager.AppSettings["ConnectString_Tail"];
        SqlConnection mycntSW = new SqlConnection(collabString);

        public Game2Database()
        {
            list = new List<Word>(100);
            list2 = new List<Sentences>();
            this.LoadDataFromSQL();

        }
        protected void LoadDataFromSQL()
        {
            list.Clear(); // Xóa dữ liệu để tránh bug ngoài ý muốn
           // Của Thiên

            // SqlConnection mycntSW = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=StudyE;Integrated Security=True"); // Của Thắng
            //SqlConnection mycntSW = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=StudyE;Integrated Security=True"); // Của Thiên
            mycntSW.Open();
            // lay het du lieu trong bang DTBQT 
            SqlCommand com = new SqlCommand("SELECT TOP 100 ID,NAME,MEANING FROM EV_Source ORDER BY NEWID()", mycntSW);
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

            com = new SqlCommand("SELECT TOP 10 Question,Answer FROM QuestionType2 ORDER BY NEWID()", mycntSW);
            //com.CommandTimeout = 150;
            //SqlCommand com = new SqlCommand("SELECT * FROM TableSource1", mycntSW); //bat dau truy van
            //com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com); //chuyen du lieu ve
            dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            foreach (DataRow row in dt.Rows)
            {

                string Question = row["Question"].ToString();
                string Answer = row["Answer"].ToString();
                list2.Add(new Sentences(Question, Answer));
            }
            mycntSW.Close();
        }
    }
}

