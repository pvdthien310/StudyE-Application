using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class mainForm : Form
    {
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

        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=DTBQT;Integrated Security=True");
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
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from DTBQT";
            ketnoicsdl(sql);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = !button2.Enabled;
            string sql = "select * from DTBQT where NGUYENMAU = '" + textBox1.Text.Trim() + "' or QUAKHUDON = '" + textBox1.Text.Trim() + "' or QUAKHUPHANTU = '" + textBox1.Text.Trim() + "'";
            ketnoicsdl(sql);
            textBox1.Text = "";
            button2.Enabled = !button2.Enabled;
        }

  

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2_Click(sender, e);
            }

        }
    }
}
