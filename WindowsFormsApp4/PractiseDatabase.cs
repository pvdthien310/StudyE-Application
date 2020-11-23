using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class PractiseDatabase : Database
    {

        public PractiseDatabase()
        {
            list = new List<Word>(100);
            this.LoadDataFromSQL();
        }
        public PractiseDatabase(Word member)
        {
            list.Add(member);
        }
        protected override void LoadDataFromSQL()
        {
            list.Clear(); // Xóa dữ liệu để tránh bug ngoài ý muốn

            SqlConnection mycntSW = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=SearchedWord;Integrated Security=True");
            mycntSW.Open();
            // lay het du lieu trong bang DTBQT
            SqlCommand com = new SqlCommand("SELECT * FROM EV_Word", mycntSW); //bat dau truy van
            com.CommandType = CommandType.Text;
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
