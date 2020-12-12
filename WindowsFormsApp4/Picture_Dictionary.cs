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
using System.Speech.Synthesis;
using System.Drawing.Imaging;

namespace WindowsFormsApp4
{
    public partial class Picture_Dictionary : Form
    {
        private mainForm Parent;
        private string group = "";
        private int currentPicture = 0;
        private FileInfo[] nameImage;
        private int numberOfGroup = 0;
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
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
            group = "";


            /*DirectoryInfo dGroup = new DirectoryInfo("./PictureImage/" + group);
            nameImage = dGroup.GetFiles();
            panel1.Visible = true;
            pictureBox1.Image = Image.FromFile(nameImage[0].FullName);*/
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            currentPicture = 0;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (currentPicture < nameImage.Count() - 1)
            {
                currentPicture++;
            }
            else
            {
                currentPicture = 0;
            }
            pictureBox1.Image = Image.FromFile(nameImage[currentPicture].FullName);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (currentPicture > 0)
            {
                currentPicture--;
            }
            else
            {
                currentPicture = nameImage.Count() - 1;
            }
            pictureBox1.Image = Image.FromFile(nameImage[currentPicture].FullName);
        }

        private void Speak_Click(object sender, EventArgs e)
        {
            string text = nameImage[currentPicture].Name;
            text = text.Remove(text.Length - 3, 3);
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(text);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Parent.Show();
        }

        private void Picture_Dictionary_Load(object sender, EventArgs e)
        {
            load_Button();
        }
        private int currentButton = 0;
        private void load_Button()
        {
            cnn.Open();
            string sql = "select * from PICTURE_BUTTON  ";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);

            for(int i=0; i<dt.Rows.Count; i++)
            {
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[i]["ENCODE"]);
                Bitmap a = new Bitmap(Image.FromStream(ms));
                a.MakeTransparent();
                string name = dt.Rows[i]["NAME"].ToString();

                Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
                buttonImage b = new buttonImage();
                but.BackColor = Color.Transparent;
                but = b.createButton(name, a) ;
                but.Click += new EventHandler(TabChose_Click);
                flowLayoutPanel1.Controls.Add(but);
                currentButton++;
            }
           
          

            cnn.Close();
        }

        private void load_Button(int k)
        {
            cnn.Open();
            string sql = "select * from PICTURE_BUTTON  ";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);


            MemoryStream ms = new MemoryStream((byte[])dt.Rows[currentButton]["ENCODE"]);
            Bitmap a = new Bitmap(Image.FromStream(ms));
            a.MakeTransparent();
            string name = dt.Rows[currentButton]["NAME"].ToString();

            Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
            buttonImage b = new buttonImage();
            but.BackColor = Color.Transparent;
            but = b.createButton(name, a);
            but.Click += new EventHandler(TabChose_Click);
            flowLayoutPanel1.Controls.Add(but);
            currentButton++;


            cnn.Close();
            
        }
        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Parent.Show();
        }

        private void creatButton_Click(object sender, EventArgs e)
        {          
            panel5.Visible = true;
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                int i = 0;
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                //dlg.Multiselect = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap a = new Bitmap(Image.FromFile(dlg.FileName));
                    a.MakeTransparent();
                    
                    guna2PictureBox1.BackgroundImage = a;
                    
                    
                }

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string sql = "insert into PICTURE_BUTTON(ID, NAME, ENCODE) VALUES (@id, @name, @encode)";
            //i++;
            MemoryStream stream = new MemoryStream();
            Image a = guna2PictureBox1.BackgroundImage;
            a.Save(stream, ImageFormat.Jpeg);
            cnn.Open();
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = currentButton+1;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameGroup.Text;
                command.Parameters.Add("@encode", SqlDbType.Image).Value = stream.ToArray();

                command.ExecuteNonQuery();
            }
            cnn.Close();

            load_Button(0);
            panel5.Visible = false;
        }

        
    }
}

