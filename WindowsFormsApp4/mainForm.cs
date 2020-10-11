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
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from DTBQT";  // lay het du lieu trong bang sinh vien
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
            ketnoicsdl();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
