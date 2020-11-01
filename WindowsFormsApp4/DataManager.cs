using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp4
{
    public class DataManager
    {
        private static DataManager instance;

        public static DataManager Instance
        {
            get { if (instance == null) instance = new DataManager(); return instance; }
            private set { instance = value; }
        }
        private DataManager() { }
        public void UpdateIDForData(out int EVlength, out int VElength)
        {
            SqlConnection conVE = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=VESource;Integrated Security=True");
            SqlConnection conEV = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=EVSource;Integrated Security=True");

            // Cap nhap so ID cho tinh nang them tu moi 
            conVE.Open();
            string query1 = "select max(ID) from TableData";
            SqlCommand cmd1 = new SqlCommand(query1, conVE);
            VElength = Convert.ToInt32(cmd1.ExecuteScalar()) + 1; // doc ket qua truy van lay dong dau tien 
            conVE.Close();
            conVE.Dispose();

            // Cap nhat so ID cho tinh nang them tu moi 
            conEV.Open();
            string query2 = "select max(ID) from TableSource1";
            SqlCommand cmd2 = new SqlCommand(query2, conEV);
            EVlength = Convert.ToInt32(cmd2.ExecuteScalar()) + 1; // doc ket qua truy van lay dong dau tien
            conEV.Close();
            conEV.Dispose();
        }
        public void Upload_Searched_Word(string request, DataGridView dest)
        {
            SqlConnection mycntSW = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=SearchedWord;Integrated Security=True");
            mycntSW.Open();
            string query = "";
            if (request == "Anh - Việt")
            {
                query = "select * from EV_Word";
            }
            else if (request == "Việt - Anh")
            {
                query = "select * from VE_Word";
            }
            SqlCommand cmdSW = new SqlCommand(query, mycntSW);
            SqlDataAdapter adaSW = new SqlDataAdapter(cmdSW); // chuyen data tu sql ve trong ada
            DataTable dtSW = new DataTable();
            adaSW.Fill(dtSW);
            mycntSW.Close();
            dest.DataSource = dtSW;

        }
        public void InsertWordToSearchedTable(string Name, string Meaning, int check)
        {
            Meaning = Meaning.Replace("'", "`");
            SqlConnection mycntSW = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=SearchedWord;Integrated Security=True");
            mycntSW.Open();
            int ID;
            if (check == 1)
            {
                string queryID = "SELECT COUNT(*) FROM  EV_Word";
                SqlCommand cmd = new SqlCommand(queryID, mycntSW);
                ID = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                string queryInsert = "INSERT INTO EV_Word VALUES (" + ID.ToString() +",'" + Name + "',N'" + Meaning + "')";
                SqlCommand cmd2 = new SqlCommand(queryInsert, mycntSW);
                cmd2.ExecuteNonQuery();
            }
            else
            {
                string queryID = "SELECT COUNT(*) FROM  VE_Word";
                SqlCommand cmd = new SqlCommand(queryID, mycntSW);

                
              ID = Convert.ToInt32(cmd.ExecuteScalar()) + 1; 

                string queryInsert = "INSERT INTO VE_Word (ID,Name,Meaning) VALUES (" + ID.ToString() + ",N'" + Name + "',N'" + Meaning + "')";

                SqlCommand cmd2 = new SqlCommand(queryInsert, mycntSW);
                cmd2.ExecuteNonQuery();
            }
            mycntSW.Close();
            mycntSW.Dispose();
        }

        //public void UpdatDataGirbViewtoList(DataGridView x, searchedWordList host)
        //{
        //    host.list.Clear();
        //    for (int i = 0; i < x.Rows.Count; ++i)
        //    {
        //        if (i == x.NewRowIndex)
        //        {
        //            break;
        //        }
        //        string[] lines = new string[3];
        //        lines[0] = x.Rows[i].Cells[0].Value.ToString();
        //        lines[1] = x.Rows[i].Cells[1].Value.ToString();
        //        lines[2] = x.Rows[i].Cells[2].Value.ToString();
        //        host.list.Add(new Word(Int32.Parse(lines[0]), lines[1], lines[2]));
        //    }
        //}
        
        public void LoadSWToList(searchedWordList host)
        {
            host.list.Clear(); // Xóa dữ liệu để tránh bug ngoài ý muốn

            SqlConnection mycntSW = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=SearchedWord;Integrated Security=True");
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
                host.list.Add(new Word(ID, Name, Meaning));
            }
            mycntSW.Close();
        }

        public  string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
             "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a","d","e","e","e","e","e","e","e","e","e","e","e","i","i","i","i","i","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","u","u","u","u","u","u","u","u","u","u","u","y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                //text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        public  string RemoveSpecialCharacters(ref string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public bool checkIsSW(string nameCheck, searchedWordList SWlist)
        {
            foreach (var a in SWlist.list)
            {
                if (a.Name == nameCheck) return true;
            }
            return false;
        }
        public bool checkIsTW(string nameCheck, List<Word> TranslatedWord)
        {
            foreach (var a in TranslatedWord)
            {
                if (a.Name == nameCheck) return true;
            }
            return false;
        }
        public void TranslateParagraph(string[] words, DataGridView x, ref searchedWordList SWlist)
        {
            x.Rows.Clear();
            SqlConnection mycntEV = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
            mycntEV.Open();
            List<Word> TranslatedWord = new List<Word>(100);
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "") continue;

                string search = "select * from TableSource1 where Name = '" + words[i].Trim() + "'";
                SqlCommand com = new SqlCommand(search, mycntEV); // truy van cau lenh vao sql
                                                                  //com.CommandType = CommandType.Text;
                SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada                        
                DataTable dt = new DataTable();
                ada.Fill(dt); // do data tu ada va dt
                if (checkIsTW(words[i], TranslatedWord) && TranslatedWord.Count != 0)
                {
                    continue;
                }
                if (dt.Rows.Count > 0)
                {

                    if (!checkIsSW(dt.Rows[0]["Name"].ToString().Trim(), SWlist))
                    {
                        DataManager.Instance.InsertWordToSearchedTable(dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim(), 1);
                        SWlist.list.Add(new Word(Convert.ToInt32(dt.Rows[0]["ID"].ToString().Trim()), dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim()));
                    }
                    x.Rows.Add(dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim());
                    // Them tu vao class tu EV da tra
                    TranslatedWord.Add(new Word(Convert.ToInt32(0), words[i], ""));

                }
                else
                {
                    x.Rows.Add(words[i],"Không tìm thấy nghĩa từ :>>>");
                    TranslatedWord.Add(new Word(Convert.ToInt32(0), words[i], ""));

                }


            }
            x.Show();
            mycntEV.Close();
            mycntEV.Dispose();

        }
        public void Design_UI_Word_EV(string temp,ref TextBox x)
        {

            string[] lines = temp.Split('|');
            string show_line = "";
            string fix_lines;
            for (int i = 1; i < lines.Length; i++)
            {
                fix_lines = lines[i];
                fix_lines = fix_lines.Substring(1);
                if (lines[i][0] == '@')
                {
                    show_line += fix_lines.Trim();
                }
                else if (lines[i][0] == '*')
                {

                    show_line += "\r\n" + "\t" + fix_lines.Trim();
                }
                else if (lines[i][0] == '-')
                {

                    show_line += "\r\n" + "\t\t" + "*" + fix_lines.Trim();
                }
                else if (lines[i][0] == '=')
                {

                    show_line += "\r\n" + "\t\t\t" + "-" + fix_lines.Trim();
                }
                else if (lines[i][0] == '+')
                {
                    show_line += ":" + fix_lines.Trim();
                }
            }
            x.Text = show_line.Trim();

        }
        public void ConnectDatabseEV(string WordName,ref TextBox result)
        {
            SqlConnection mycntEV = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");

            mycntEV.Open(); // mo ket noi 
            string search = "select * from TableSource1 where Name = '" + WordName + "'";
            SqlCommand com = new SqlCommand(search, mycntEV); // truy van cau lenh vao sql
            //com.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            if (dt.Rows.Count > 0)
            {
                Design_UI_Word_EV(dt.Rows[0]["Meaning"].ToString().Trim(),ref result);
            }
            else
            {
                result.Text = "Không có dữ liệu hjhj :>>";
            }
            mycntEV.Close(); // đóng kết nối

        }
    }
}
