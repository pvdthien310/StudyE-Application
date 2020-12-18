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
    public partial class Menustrip : UserControl
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True"); //của thức
        //SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=StudyE;Integrated Security=True"); // của thắng
        private Guna.UI2.WinForms.Guna2Button button;
        public Menustrip()
        {
            InitializeComponent();
        }
        public Menustrip(Guna.UI2.WinForms.Guna2Button b)
        {
            this.button = b;
            
            InitializeComponent();
        }
        
        private void Delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from PICTURE_BUTTON WHERE NAME = '" + button.Name + "'";
            cnn.Open();

            using (SqlCommand command = new SqlCommand("delete from PICTURE_BUTTON WHERE NAME = '" + button.Name + "'", cnn))
            {
                command.ExecuteNonQuery();
            }
            cnn.Close();

        }
    }
}
