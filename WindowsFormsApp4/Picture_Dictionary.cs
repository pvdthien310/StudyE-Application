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
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Picture_Dictionary : Form
    {
        private mainForm Parent;
        private int currentPicture = 0;
        private FileInfo[] nameImage;
        private string group;
        SqlConnection mycnt = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
        public Picture_Dictionary()
        {
            InitializeComponent();
        }
        public Picture_Dictionary(mainForm parent)
        {
            this.Parent = parent;
            InitializeComponent();
        }
        private void TabChose_Click(object sender, EventArgs e)
        {
            if (sender == b1)
            {
                group = "Animal";
                DirectoryInfo dGroup = new DirectoryInfo("./PictureImage/Animal");
                nameImage = dGroup.GetFiles();
                panel1.Visible = true;
            }
            else if (sender == b2)
            {

            }
        }
        private void ConnectDatabsePicture()
        {
            mycnt.Open(); // mo ket noi 
            String path;
            string search = "select * from PICTURE where GROUPS = '" + group + "' and STT = " + currentPicture + "";
            SqlCommand com = new SqlCommand(search, mycnt); // truy van cau lenh vao sql
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            if (dt.Rows.Count > 0)
            {
                path = "./" + group + "/" + dt.Rows[0][""].ToString().Trim() + ".png";   //"./group/name.png"
                
            }
            else
            {

            }

            //textBox1.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug

            mycnt.Close(); // đóng kết nối
        }
        
        private void Pause_Click(object sender, EventArgs e)
        {

        }

        private void Right_Click(object sender, EventArgs e)
        {
            if(currentPicture< nameImage.Count() - 1 )
            {
                currentPicture++;
            }
            else
            {
                currentPicture = 0;
            }
            pictureBox1.Image = Image.FromFile(nameImage[currentPicture].FullName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       
    }
}
