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
        //thuc code
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
            dataGridView5.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from DTBQT";
            ketnoicsdl(sql);
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
        //end thuc code
    }
}
