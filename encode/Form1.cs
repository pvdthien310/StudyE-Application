using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string url = "";

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                int i = 0;
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string temp in dlg.FileNames)
                    {
                        i++;
                        MemoryStream stream = new MemoryStream();
                        Image a = Image.FromFile(temp);
                        a.Save(stream, ImageFormat.Jpeg);
                        DataClasses1DataContext mydd = new DataClasses1DataContext();
                        PICTURE_SOURSE picS = new PICTURE_SOURSE();
                        string tem = Path.GetFileName(temp);


                        picS.GROUPPICTURE = new DirectoryInfo(temp).Parent.Name;
                        picS.ID = i;
                        picS.NAME = tem.Remove(tem.Length - 4, 4);
                        picS.ENCODE = stream.ToArray();


                        mydd.PICTURE_SOURSEs.InsertOnSubmit(picS);
                        mydd.SubmitChanges();

                    }
                    MessageBox.Show("Nhin tieu de", "Nhin noi dung");
                }

                
            }
            
            
        }
        int curentID = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext mydd = new DataClasses1DataContext();
            PICTURE_SOURSE picS = mydd.PICTURE_SOURSEs.Where(em => em.NAME=="cat").FirstOrDefault();

            MemoryStream ms = new MemoryStream(picS.ENCODE.ToArray());
            Image img = Image.FromStream(ms);
            pictureBox1.Image = img;

            /*if (picS == null)
            {
                curentID = 0;
                picS = mydd.PICTURE_SOURSEs.Where(em => em.ID == curentID).FirstOrDefault();
            }
            else
            {
                MemoryStream ms = new MemoryStream(picS.ENCODE.ToArray());
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                int i = 0;
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string temp in dlg.FileNames)
                    {
                        i++;
                        MemoryStream stream = new MemoryStream();
                        Image a = Image.FromFile(temp);
                        a.Save(stream, ImageFormat.Jpeg);
                        DataClasses1DataContext mydd = new DataClasses1DataContext();
                        PICTURE_SOURSE picS = new PICTURE_SOURSE();
                        string tem = Path.GetFileName(temp);


                        picS.GROUPPICTURE = new DirectoryInfo(temp).Parent.Name;
                        picS.ID = i;
                        picS.NAME = tem.Remove(tem.Length - 4, 4);
                        picS.ENCODE = stream.ToArray();


                        mydd.PICTURE_SOURSEs.InsertOnSubmit(picS);
                        mydd.SubmitChanges();

                    }
                    MessageBox.Show("Nhin tieu de", "Nhin noi dung");
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from PICTURE_SOURSE";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
    }
}
