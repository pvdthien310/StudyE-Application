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

namespace WindowsFormsApp4
{
    public partial class mainForm : Form
    {
        SqlConnection mycntVE = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=V-ESource;Integrated Security=True");
        SqlConnection mycntEV = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=E-VSource;Integrated Security=True");
        public startForm parent;
        public mainForm()
        {
            InitializeComponent();
        }
        public mainForm(startForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }

       
        
        
        /// <summary>
        /// // Thien code 
        /// </summary>
        private void ConnectDatabseEV()
        {
            mycntEV.Open(); // mo ket noi 

            string search = "select * from TableSource1 where Name = '" + textBox1.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(search, mycntEV); // truy van cau lenh vao sql
            //com.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            if (dt.Rows.Count > 0)
            {
                Design_UI_Word_EV(dt.Rows[0]["Meaning"].ToString().Trim());


                // Thuc hien chuyen string tu database sang dang form tieu chuan (Viet - Anh)
                //Design_UI_Word_VE(dt.Rows[0]["Meaning"].ToString().Trim());



                //word = dt.Rows[0]["Meaning"].ToString().Trim();
                //textBox1.Text = dt.Rows[1]["Meaning"].ToString().Trim();
            }
            else
            {
                resultBox1.Text = "Đéo có dữ liệu hjhj :>>";
            }
           
            mycntEV.Close();

        }
        private void ConnectDatabseVE()
        {
            mycntVE.Open(); // mo ket noi 

            string search = "select * from TableData where Name = N'@" + textBox2.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(search, mycntVE); // truy van cau lenh vao sql
            //com.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            
            if (dt.Rows.Count > 0)
            {
                Design_UI_Word_VE(dt.Rows[0]["Meaning"].ToString().Trim());


                // Thuc hien chuyen string tu database sang dang form tieu chuan (Viet - Anh)
                //Design_UI_Word_VE(dt.Rows[0]["Meaning"].ToString().Trim());



                //word = dt.Rows[0]["Meaning"].ToString().Trim();
                //textBox1.Text = dt.Rows[1]["Meaning"].ToString().Trim();
            }
            else
            {
               resultBox1.Text = "Đéo có dữ liệu :>>";
            }
            
            mycntVE.Close();

        }
        private void Design_UI_Word_VE(string temp)
        {

            string[] lines = temp.Split('|');
            // show_lines là chuỗi result 
            string show_line = "";
            // lưu chuỗi để thực hiện các tao thác tách và xét 
            string fix_lines;
            for (int i = 1; i < lines.Length; i++)
            {
                fix_lines = lines[i];
                // Tác chuỗi lấy từ vị trí thứ 1 trong chuỗi ( ý nghĩa là tách các kí tự phân định design @ * - = ra khỏi chuỗi )
                fix_lines = fix_lines.Substring(1);
                if (lines[i][0] == '*')
                {
                    show_line += fix_lines.Trim();
                }
                else if (lines[i][0] == '-')
                {
                    show_line += "\r\n" + "\t" + "*" + fix_lines.Trim();
                }
                else if (lines[i][0] == '=')
                {

                    show_line += "\r\n" + "\t\t" + "-" + fix_lines.Trim();
                }
                else if (lines[i][0] == '+')
                {
                    show_line += ":" + fix_lines.Trim();
                }

            }
            // xuất ra ngoài 
            resultBox2.Text = show_line.Trim();

        }

        private void Design_UI_Word_EV(string temp)
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
            resultBox1.Text = show_line.Trim();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDatabseEV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDatabseVE();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2_Click(sender, e);
            }
        }

        
        /// <summary>
        /// // Thien code end
        /// </summary>
    }
}
