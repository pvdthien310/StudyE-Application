using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ResultForm2 : Form
    {
        public RoomChose parent;
        public List<string> result;
        public static SqlConnection Mycnt = new SqlConnection(@"Server=tcp:40.83.97.14,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=sa;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

        public ResultForm2()
        {
            InitializeComponent();
        }
        public ResultForm2(RoomChose parent,List<string> result)
        {
            InitializeComponent();
            this.parent = parent;
            this.result = result;
            //foreach (string pl in result)
            //{
            //    listView1.Items.Add(pl);

            //}
            
        }

        private void guna2Button_Back_Click(object sender, EventArgs e)
        {
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            } 
            string query = string.Format(" delete  FROM ROOMRESULT WHERE ROOMID = '{0}'" +
                "DELETE  FROM RoomQuestions WHERE ROOMID = '{0}'" +
                "DELETE  FROM RoomList WHERE ROOMID = '{0}'",result[0]);
            SqlCommand com = new SqlCommand(query, Mycnt);
            com.ExecuteNonQuery();
            Mycnt.Close();
            this.Dispose();
            this.parent.Show();
            
        }

        private void guna2Button_BackDictionary_Click(object sender, EventArgs e)
        {
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }
            string query = string.Format(" delete  FROM ROOMRESULT WHERE ROOMID = '{0}'" +
                " DELETE  FROM RoomQuestions WHERE ROOMID = '{0}'" +
                " DELETE  FROM RoomList WHERE ROOMID = '{0}'", result[0]);
            SqlCommand com = new SqlCommand(query, Mycnt);
            com.ExecuteNonQuery();
            Mycnt.Close();
            this.Close();
            this.parent.loginForm.parent.Show();
            this.parent.loginForm.Close();
            this.parent.Close(); 


        }
    }
}
