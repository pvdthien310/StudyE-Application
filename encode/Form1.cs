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
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
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
                    cnn.Open();
                    using (StreamWriter sw = new StreamWriter("D:/sourt.txt", true))
                    {


                        foreach (string temp in dlg.FileNames)
                        {

                            byte[] img = null;
                            FileStream fs = new FileStream(temp, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);

                            string sql = "insert into PICTURE_SOURSE(GROUPPICTURE, ID, NAME, ENCODE) VALUES (@group, @id, @name, @encode)";
                            i++;
                            string tem = Path.GetFileName(temp);
                            using (SqlCommand command = new SqlCommand(sql, cnn))
                            {

                                command.Parameters.Add("@group", SqlDbType.VarChar).Value = new DirectoryInfo(temp).Parent.Name; 
                                command.Parameters.Add("@id", SqlDbType.Int).Value = i;
                                command.Parameters.Add("@name", SqlDbType.VarChar).Value = tem.Remove(tem.Length - 4, 4); ;
                                command.Parameters.Add("@encode", SqlDbType.Image).Value = img;     

                                command.ExecuteNonQuery();
                            }

                           /* i++;
                            string tem = Path.GetFileName(temp);
                            byte[] img = null;
                            FileStream fs = new FileStream(temp, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);
                            string sql = "insert into PICTURE_SOURSE(GROUPPICTURE, ID, NAME, ENCODE) VALUES ('" + new DirectoryInfo(temp).Parent.Name + "',' " + i + "',' " + tem.Remove(tem.Length - 4, 4) + "','" + img + "')";

                            sw.WriteLine(sql);*/


                        }
                    }
                    MessageBox.Show("Nhin tieu de", "Nhin noi dung");
                    cnn.Close();  // đóng kết nối
                    //cnn.Dispose();
                }

                
            }
            
            
        }
        int curentID = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            /* DataClasses1DataContext mydd = new DataClasses1DataContext();
             PICTURE_SOURSE picS = mydd.PICTURE_SOURSEs.Where(em => em.NAME=="cat").FirstOrDefault();

             MemoryStream ms = new MemoryStream(picS.ENCODE.ToArray());
             Image img = Image.FromStream(ms);
             pictureBox1.Image = img;
*/

                        cnn.Open();
            string sql = "select * from PICTURE_SOURSE where NAME = 'cat'"; 
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                /*MemoryStream ms = new MemoryStream((row["ENCODE"].));
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img; */
                //textBox1.Text = row[3].ToString();
            }
            
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
                        /*i++;
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
                        mydd.SubmitChanges();*/




                        FileInfo fileInfo = new FileInfo(temp);

                        
                        string newName = fileInfo.Name;
                        newName = newName.Remove(newName.Length - 4, 4);
                        fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newName +".jpg");
                        
                        

                    }
                    MessageBox.Show("Nhin tieu de", "Nhin noi dung");
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "select * from PICTURE_SOURSE  ";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            //cnn.Close();  // đóng kết nối
            //dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["ENCODE"]);
            //Image a = Image.FromStream(ms);
            Bitmap a = new Bitmap(Image.FromStream(ms));
            a.MakeTransparent();
            //Image a = byteArrayToImage((byte[])dt.Rows[0]["ENCODE"]);
            pictureBox1.BackgroundImage = a;

            cnn.Close();
            cnn.Dispose();
        }
        
        
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
