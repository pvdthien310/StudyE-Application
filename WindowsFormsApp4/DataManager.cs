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
            dest.DataSource = dtSW;

        }
        public void InsertWordToSearchedTable(string Name, string Meaning, int check)
        {
            Meaning = Meaning.Replace("'", "`");
            SqlConnection mycntSW = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=SearchedWord;Integrated Security=True");
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
    }
}
