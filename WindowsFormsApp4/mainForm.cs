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
        SqlConnection mycntVE = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=VE;Integrated Security=True");
        SqlConnection mycntEV = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=EV;Integrated Security=True");
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
        //thuc code
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=dTBQT1;Integrated Security=True");
        private void ketnoicsdl(string sql)
        {
            cnn.Open();
              // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView5.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("  dfd ");
            string sql = "select * from DTBQT";
            ketnoicsdl(sql);
        }
       
        /// <summary>
        /// // Thien code 
        /// </summary>
        private void ConnectDatabseEV()
        {
            mycntEV.Open(); // mo ket noi 
            if (textBox1.Text == "")
            {
                // kiểm tra exception
                resultBox1.Text = "Vui lòng nhập từ cần tra !!";
                mycntEV.Close();
                return;
            }
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
            textBox1.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug

            mycntEV.Close(); // đóng kết nối

        }
        private void ConnectDatabseVE()
        {
            mycntVE.Open(); // mo ket noi 

            if (textBox2.Text == "")
            {
                resultBox2.Text = "Vui lòng nhập từ cần tra !!";
                mycntVE.Close();
                return;
            }

            string search2 = "select * from TableData where Name = N'@" + textBox2.Text.Trim() + "'";
            SqlCommand com2 = new SqlCommand(search2, mycntVE); // truy van cau lenh vao sql
            //com.CommandType = CommandType.Text;
            SqlDataAdapter ada2 = new SqlDataAdapter(com2); // chuyen data tu sql ve trong ada2
            DataTable dt2 = new DataTable();
            ada2.Fill(dt2); // do data tu ada2 va0 dt2
            
            if (dt2.Rows.Count > 0)
            {

                // Thuc hien chuyen string tu database sang dang form tieu chuan (Viet - Anh)
                Design_UI_Word_VE(dt2.Rows[0]["Meaning"].ToString().Trim());

//<<<<<<< HEAD



                //word = dt.Rows[0]["Meaning"].ToString().Trim();
                //textBox1.Text = dt.Rows[1]["Meaning"].ToString().Trim();
            }
            else
            {
               resultBox2.Text = "Đéo có dữ liệu :>>";
            }
            textBox2.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug


            mycntVE.Close(); // đóng kết nối
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = !button5.Enabled;
            string sql = "select * from DTBQT where NGUYENMAU = '" + textBox5.Text.Trim() + "' or QUAKHUDON = '" + textBox5.Text.Trim() + "' or QUAKHUPHANTU = '" + textBox5.Text.Trim() + "'";
            ketnoicsdl(sql);
            textBox5.Text = "";
            button5.Enabled = !button5.Enabled;
        }


        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
        	if (e.KeyCode == Keys.Enter)
            {
                this.button5_Click(sender, e);
            }
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
//<<<<<<< HEAD
            button1.Enabled = !button1.Enabled;
            ConnectDatabseEV();
            button1.Enabled = !button1.Enabled;
        }
        private void button2_Click(object sender, EventArgs e)
        {
//<<<<<<< HEAD
            button2.Enabled = !button2.Enabled;
            ConnectDatabseVE();
            button2.Enabled = !button2.Enabled;

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
