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
        private int currentSourse = 0;
        private string isSourse = "1";
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True"); //của thức
        //SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=StudyE;Integrated Security=True"); // của thắng
        DataTable datatable = new DataTable();
        private bool isInsert = false;

        public Picture_Dictionary()
        {
            InitializeComponent();
        }
        public Picture_Dictionary(mainForm parent)
        {
            this.Parent = parent;
            InitializeComponent();
        }
        private void TabChose_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                panel1.Visible = true;
                group = ((Guna.UI2.WinForms.Guna2Button)sender).Name;
                isSourse = ((Guna.UI2.WinForms.Guna2Button)sender).Text;
                cnn.Open();
                string sql = "select * from PICTURE_SOURSE WHERE GROUPPICTURE = '" + group + " ' ";
                SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve

                datatable.Clear();
                da.Fill(datatable);
                panel1.Visible = true;
                if (datatable.Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])datatable.Rows[currentSourse]["ENCODE"]);
                    Bitmap a = new Bitmap(Image.FromStream(ms));
                    a.MakeTransparent();

                    if (isSourse == "1")
                    {
                        pictureBox1.Image = a;
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        pictureBoxInsert.Visible = true;
                        pictureBoxInsert.BackgroundImage = a;
                    }

                }
                else 
                {
                    pictureBox1.Image = null;
                }
                       
               

                cnn.Close();
            }
            else if(e.Button == MouseButtons.Right)
            {
                menuStrip.Visible = true;
                menuStrip.Location = new Point(((Guna.UI2.WinForms.Guna2Button)sender).Location.X + 100, ((Guna.UI2.WinForms.Guna2Button)sender).Location.Y + 150);
                
            }
           
            

           
        }
        

        private void Pause_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            currentPicture = 0;
            pictureBoxInsert.Visible = false;
            pictureBox1.Visible = false;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            currentSourse++;
            if (currentSourse >= datatable.Rows.Count)
            {
                currentSourse = 0;
            }
            if (datatable.Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])datatable.Rows[currentSourse]["ENCODE"]);
                Bitmap a = new Bitmap(Image.FromStream(ms));
                a.MakeTransparent();

                if (isSourse == "1")
                {
                    pictureBox1.Image = a;
                }
                else
                {
                    pictureBoxInsert.BackgroundImage = a;
                }
            }
            

        }

        private void Left_Click(object sender, EventArgs e)
        {
            currentSourse--;
            if (currentSourse <0 )
            {
                currentSourse = datatable.Rows.Count-1;
            }
            if (datatable.Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])datatable.Rows[currentSourse]["ENCODE"]);
                Bitmap a = new Bitmap(Image.FromStream(ms));
                a.MakeTransparent();
               
                if(isSourse == "1")
                {
                    pictureBox1.Image = a;
                }
                else
                {
                    pictureBoxInsert.BackgroundImage = a;
                }
            }
                
        }

        private void Speak_Click(object sender, EventArgs e)
        {
            if (datatable.Rows.Count > 0)
            {
                string text = datatable.Rows[currentSourse]["NAME"].ToString();
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak(text);
            }
            
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
                string isSourse = dt.Rows[currentButton]["IS_SOURSE"].ToString();

                Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
                buttonImage b = new buttonImage();
                but.BackColor = Color.Blue;
               
                but = b.createButton(name, a, isSourse) ;
                but.MouseClick += new MouseEventHandler(TabChose_Click);
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
            string isSourse = dt.Rows[currentButton]["IS_SOURSE"].ToString();

            Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
            buttonImage b = new buttonImage();
            but.BackColor = Color.Transparent;
            but = b.createButton(name, a, isSourse);
            but.MouseClick += new MouseEventHandler(TabChose_Click);
            
            flowLayoutPanel1.Controls.Add(but);
            


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
            nameGroup.Text = "";
            guna2PictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.interface_77_512;
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
                    tem = dlg.FileName;
                    guna2PictureBox1.BackgroundImage = a;
                    string t = new FileInfo(dlg.FileName).Name;
                    nameGroup.Text = t.Remove(t.Length - 4, 4);
                    
                }

            }
        }
        private string tem = "";
        private void Add_Click(object sender, EventArgs e)
        {

            string sql = "insert into PICTURE_BUTTON(ID, NAME, ENCODE, IS_SOURSE) VALUES (@id, @name, @encode, @isSourse)";
            byte[] img = null;
            FileStream fs = new FileStream(tem, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            cnn.Open();
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = currentButton+1;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameGroup.Text;
                command.Parameters.Add("@encode", SqlDbType.Image).Value = img;
                command.Parameters.Add("@isSourse", SqlDbType.TinyInt).Value = 0;
                command.ExecuteNonQuery();
            }
            cnn.Close();
            
            load_Button(0);
            currentButton++;
            panel5.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            panel5.Visible = false; 
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                int i = datatable.Rows.Count - 1;
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                dlg.Multiselect = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    cnn.Open();

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

                            command.Parameters.Add("@group", SqlDbType.VarChar).Value = group;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = i;
                            command.Parameters.Add("@name", SqlDbType.VarChar).Value = tem.Remove(tem.Length - 4, 4); ;
                            command.Parameters.Add("@encode", SqlDbType.Image).Value = img;

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Thêm thành công!");

                    
                    string sql2 = "select * from PICTURE_SOURSE WHERE GROUPPICTURE = '" + group + " ' ";
                    SqlCommand com = new SqlCommand(sql2, cnn); //bat dau truy van
                    com.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve

                    datatable.Clear();
                    da.Fill(datatable);
                    cnn.Close();  
                    //cnn.Dispose();
                }


            }

        }
    }
}

