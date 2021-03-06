﻿using System;
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
        //private int currentPicture = 0;
        private int lastIdSourse = 0;
        private int currentSourse = 0;
        private string isSourse = "1";
        //private int numberOfButton = 0;
        public static SqlConnection cnn = new SqlConnection(@"Server=tcp:40.83.97.14,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=sa;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

        //SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True"); //của thức
        //SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-E6SJOH8;Initial Catalog=StudyE;Integrated Security=True"); // của thắng
        DataTable datatable = new DataTable();
        private bool isInsert = false;
        private int lastId = 0;


        private string[] listNameButton = new string[100];
        private string[] listSourst = new string[150];
        private FlowLayoutPanel[] listFlowPanel;
        private List<Guna.UI2.WinForms.Guna2Button> listButon = new List<Guna.UI2.WinForms.Guna2Button>(100);
        private int numberOfPanel = 0;
        private int numberOfButton = 0;
        private int currentPanel = 0;

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
                /*menuStrip.Visible = false;
                currentSourse = 0;
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
                    MemoryStream ms = new MemoryStream((byte[])datatable.Rows[0]["ENCODE"]);
                    Bitmap a = new Bitmap(Image.FromStream(ms));
                    a.MakeTransparent();
                    string text = datatable.Rows[0]["NAME"].ToString();

                    if (isSourse == "1")
                    {
                        pictureBox1.Image = a;
                        pictureBox1.Visible = true;
                        textName.Visible = false;
                        guna2CircleButton2.Visible = false;
                        
                    }
                    else
                    {
                        pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.nen;
                        pictureBox1.Image = null;
                        pictureBox1.Visible = true;
                        guna2CircleButton2.Visible = true;
                        pictureBoxInsert.Visible = true;
                        pictureBoxInsert.BackgroundImage = a;
                        textName.Text = text;
                        textName.Visible = true;

                       
                    }

                }
                else 
                {
                    textName.Text = "";
                    pictureBox1.Visible = true;
                    pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.nen;
                }
                       
               

                cnn.Close();*/

                panel1.BringToFront();
                menuStrip.Visible = false;
                panel1.Visible = true;

                currentSourse = 0;
                isSourse = ((Guna.UI2.WinForms.Guna2Button)sender).Text;
                panel1.Visible = true;
                group = ((Guna.UI2.WinForms.Guna2Button)sender).Name;
                string path = "";
                if (isSourse == "1")
                {
                    path = "./PictureImage/" + group;
                }
                else
                {
                    path = "./PictureImageInsert/" + group;
                }

                listSourst = Directory.GetFiles(path);

                if (listSourst.Length > 0)
                {

                    Bitmap a;
                    using (var stream = File.Open(listSourst[0], FileMode.Open))
                    {
                        a = new Bitmap(Image.FromStream(stream));
                        stream.Close();
                    }
                    a.MakeTransparent();
                    string text = Path.GetFileName(listSourst[0]);
                    text = text.Remove(text.Length - 4, 4);


                    if (isSourse == "1")
                    {
                        pictureBox1.Image = a;
                        pictureBox1.Visible = true;
                        textName.Visible = false;
                        guna2CircleButton2.Visible = false;

                    }
                    else
                    {
                        pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.nen;
                        pictureBox1.Image = null;
                        pictureBox1.Visible = true;
                        guna2CircleButton2.Visible = true;
                        pictureBoxInsert.Visible = true;
                        pictureBoxInsert.BackgroundImage = a;
                        textName.Text = text;
                        textName.Visible = true;


                    }

                }
                else
                {
                    textName.Text = "";
                    pictureBox1.Visible = true;
                    pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.nen;
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                menuStrip.Visible = true;
                menuStrip.Location = new Point(((Guna.UI2.WinForms.Guna2Button)sender).Location.X + 135, ((Guna.UI2.WinForms.Guna2Button)sender).Location.Y + 150);

                isSourse = ((Guna.UI2.WinForms.Guna2Button)sender).Text;
                group = ((Guna.UI2.WinForms.Guna2Button)sender).Name;

                if (isSourse == "1")
                {

                    Delete.Enabled = false;
                }
                else
                {

                    Delete.Enabled = true;
                }
            }




        }


        private void Pause_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            currentSourse = 0;
            pictureBoxInsert.Visible = false;
            pictureBox1.Visible = false;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            currentSourse++;
            if (currentSourse >= listSourst.Length)
            {
                currentSourse = 0;
            }
            if (listSourst.Length > 0)
            {
                Bitmap a;
                using (var stream = File.Open(listSourst[currentSourse], FileMode.Open))
                {
                    a = new Bitmap(Image.FromStream(stream));
                    stream.Close();
                }

                a.MakeTransparent();
                string text = Path.GetFileName(listSourst[currentSourse]);
                text = text.Remove(text.Length - 4, 4);

                if (isSourse == "1")
                {
                    pictureBox1.Image = a;
                }
                else
                {
                    pictureBoxInsert.BackgroundImage = a;
                    textName.Text = text;
                }
            }


        }

        private void Left_Click(object sender, EventArgs e)
        {
            currentSourse--;
            if (currentSourse < 0)
            {

                currentSourse = listSourst.Length - 1;
            }
            if (listSourst.Length > 0)
            {
                Bitmap a;
                using (var stream = File.Open(listSourst[currentSourse], FileMode.Open))
                {
                    a = new Bitmap(Image.FromStream(stream));
                    stream.Close();
                }
                a.MakeTransparent();
                string text = Path.GetFileName(listSourst[currentSourse]);
                text = text.Remove(text.Length - 4, 4);

                if (isSourse == "1")
                {
                    pictureBox1.Image = a;
                }
                else
                {
                    pictureBoxInsert.BackgroundImage = a;
                    textName.Text = text;
                }
            }

        }

        private void Speak_Click(object sender, EventArgs e)
        {
            if (listSourst.Length > 0)
            {
                string text = Path.GetFileName(listSourst[currentSourse]);
                text = text.Remove(text.Length - 4, 4);
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
            panel1.BringToFront();
        }




        private void load_Button()
        {

            /* cnn.Open();
             string sql = "select * from PICTURE_BUTTON ";
             SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
             com.CommandType = CommandType.Text;
             SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
             DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
             da.Fill(dt);

             int n = dt.Rows.Count - 1;
             MemoryStream ms = new MemoryStream((byte[])dt.Rows[n]["ENCODE"]);
             Bitmap a = new Bitmap(Image.FromStream(ms));
             a.MakeTransparent();
             string name = dt.Rows[n]["NAME"].ToString();
             string isSourse = dt.Rows[n]["IS_SOURSE"].ToString();

             Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
             buttonImage b = new buttonImage();
             but.BackColor = Color.Transparent;
             but = b.createButton(name, a, "0");
             but.MouseClick += new MouseEventHandler(TabChose_Click);

             flowLayoutPanel1.Controls.Add(but);



             cnn.Close();*/
            listButon.Clear();
            numberOfButton = 0;
            numberOfPanel = 0;

            string path = "./Group";
            string name = "";
            listNameButton = Directory.GetFiles(path);
            foreach (string f in listNameButton)
            {
                name = Path.GetFileName(f);
                name = name.Remove(name.Length - 4, 4);


                Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
                buttonImage b = new buttonImage();
                but.BackColor = Color.Transparent;
                Bitmap a;
                using (var stream = File.Open(f, FileMode.Open))
                {
                    a = new Bitmap(Image.FromStream(stream));
                    stream.Close();
                }


                but = b.createButton(name, a, "1");
                but.MouseClick += new MouseEventHandler(TabChose_Click);
                numberOfButton++;
                listButon.Add(but);


            }
            path = "./GroupInsert";
            listNameButton = Directory.GetFiles(path);
            foreach (string f in listNameButton)
            {
                name = Path.GetFileName(f);
                name = name.Remove(name.Length - 4, 4);


                Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
                buttonImage b = new buttonImage();
                but.BackColor = Color.Transparent;
                Bitmap a;
                using (var stream = File.Open(f, FileMode.Open))
                {
                    a = new Bitmap(Image.FromStream(stream));
                    stream.Close();
                }




                but = b.createButton(name, a, "0");
                but.MouseClick += new MouseEventHandler(TabChose_Click);
                numberOfButton++;
                listButon.Add(but);


            }





            if (numberOfButton % 32 != 0)
            {
                numberOfPanel = numberOfButton / 32 + 1;
            }
            else if (numberOfButton % 32 == 0)
            {
                numberOfPanel = numberOfButton / 32;
            }

            listFlowPanel = new FlowLayoutPanel[numberOfPanel];
            for (int i = 0; i < numberOfPanel; i++)
            {
                listFlowPanel[i] = new FlowLayoutPanel();
                listFlowPanel[i].BackColor = Color.Transparent;
                listFlowPanel[i].Location = new Point(110, 120);
                listFlowPanel[i].Size = new Size(480, 250);
                listFlowPanel[i].Click += new System.EventHandler(this.flowLayoutPanel1_Click);
                listFlowPanel[i].BringToFront();
                listFlowPanel[i].Visible = true;
                this.Controls.Add(listFlowPanel[i]);


            }
            int numberInPanel = 0;
            currentPanel = 0;
            for (int i = 0; i < numberOfButton; i++)
            {
                if (numberInPanel == 32)
                {
                    numberInPanel = 0;
                    currentPanel++;
                }
                else
                {
                    numberInPanel++;
                }
                listFlowPanel[currentPanel].Controls.Add(listButon[i]);
            }




        }
        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Parent.Show();
        }

        private void creatButton_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel5.BringToFront();
            nameGroup.Text = "";
            //guna2PictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.interface_77_512;
            guna2PictureBox1.Visible = false;
            addImage.Visible = true;
        }

        private string tem = "";
        private void Add_Click(object sender, EventArgs e)
        {

            /*string sql = "insert into PICTURE_BUTTON(ID, NAME, ENCODE, IS_SOURSE) VALUES (@id, @name, @encode, @isSourse)";
            byte[] img = null;
            FileStream fs = new FileStream(tem, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            cnn.Open();
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = lastId+1;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameGroup.Text;
                command.Parameters.Add("@encode", SqlDbType.Image).Value = img;
                command.Parameters.Add("@isSourse", SqlDbType.TinyInt).Value = 0;
                command.ExecuteNonQuery();
            }
            cnn.Close();*/
            //numberOfButton++;
            //lastId++;
            //load_Button(0);
            if (addImage.Visible == false && nameGroup.Text != "")
            {
                string path = "./GroupInsert/" + nameGroup.Text + ".png";
                if (File.Exists(path))
                {
                    MessageBox.Show("File exist", "File exist");
                }
                else
                {
                    File.Copy(tem, path);
                    panel5.Visible = false;

                    for (int i = 0; i < numberOfPanel; i++)
                    {
                        listFlowPanel[i].Visible = false;
                        listFlowPanel[i].Controls.Clear();
                    }

                    load_Button();
                    for (int i = 0; i < numberOfPanel; i++)
                    {
                        listFlowPanel[i].Visible = true;
                    }


                    path = path = "./PictureImageInsert/" + nameGroup.Text;
                    Directory.CreateDirectory(path);
                }

            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                /*int i = 0;
                if (datatable.Rows.Count > 0)
                {
                    int n = datatable.Rows.Count - 1;
                     i = (int)datatable.Rows[n]["ID"];
                }
                
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
                if (datatable.Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])datatable.Rows[0]["ENCODE"]);
                    Bitmap a = new Bitmap(Image.FromStream(ms));
                    a.MakeTransparent();
                    string text = datatable.Rows[0]["NAME"].ToString();

                    if (isSourse == "1")
                    {
                        pictureBox1.Image = a;
                        pictureBox1.Visible = true;
                        textName.Visible = false;
                    }
                    else
                    {
                        pictureBoxInsert.Visible = true;
                        pictureBoxInsert.BackgroundImage = a;
                        textName.Text = text;
                        textName.Visible = true;
                    }

                }
                else
                {
                    pictureBox1.Image = null;
                }*/
                dlg.Multiselect = true;
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string path;
                    int flag = 0;

                    foreach (string temp in dlg.FileNames)
                    {
                        string name = Path.GetFileName(temp);
                        name = name.Remove(name.Length - 4, 4);
                        path = "./PictureImageInsert/" + group + "/" + name + ".png";
                        if (!File.Exists(path))
                        {
                            File.Copy(temp, path);
                        }
                        else
                        {
                            flag++;
                        }
                    }
                    if (flag != 0)
                    {
                        MessageBox.Show("Several image names already exist!", "Some image were not inserted!");
                    }


                    path = "./PictureImageInsert/" + group;
                    listSourst = Directory.GetFiles(path);

                    Bitmap a;
                    using (var stream = File.Open(listSourst[0], FileMode.Open))
                    {
                        a = new Bitmap(Image.FromStream(stream));
                        stream.Close();
                    }
                    a.MakeTransparent();
                    pictureBoxInsert.BackgroundImage = a;
                    pictureBoxInsert.Visible = true;
                    string nam = Path.GetFileName(listSourst[0]);
                    nam = nam.Remove(nam.Length - 4, 4);
                    textName.Text = nam;
                    textName.Visible = true;
                    MessageBox.Show("Inserted successfully");


                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            /* cnn.Open();

             string sql = "delete from PICTURE_BUTTON where NAME = @name";

             using (SqlCommand command = new SqlCommand(sql, cnn))
             {

                 command.Parameters.Add("@name", SqlDbType.VarChar).Value = group;                

                 command.ExecuteNonQuery();
             }

             sql = "delete from PICTURE_SOURSE where GROUPPICTURE = @name";

             using (SqlCommand command = new SqlCommand(sql, cnn))
             {
                 command.Parameters.Add("@name", SqlDbType.VarChar).Value = group;
                 command.ExecuteNonQuery();
             }

             cnn.Close();*/

            string path = "./GroupInsert/" + group + ".png";
            listButon.Clear();

            menuStrip.Visible = false;

            for (int i = 0; i < numberOfPanel; i++)
            {
                listFlowPanel[i].Visible = false;
                listFlowPanel[i].Controls.Clear();
            }
            File.Delete(path);
            path = "./PictureImageInsert/" + group;
            Directory.Delete(path, true);
            load_Button();
            for (int i = 0; i < numberOfPanel; i++)
            {
                listFlowPanel[i].Visible = true;
            }
        }

        private void Picture_Dictionary_Click(object sender, EventArgs e)
        {
            menuStrip.Visible = false;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            menuStrip.Visible = false;
        }

        private void deleteOneSourse_Click(object sender, EventArgs e)
        {
            /*cnn.Open();

            string sql = "delete from PICTURE_SOURSE where NAME = @name";

            using (SqlCommand command = new SqlCommand(sql, cnn))
            {

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = textName.Text;
                command.ExecuteNonQuery();
            }
            for(int i=0; i<datatable.Rows.Count; i++)
            {
                if( (string)datatable.Rows[i]["NAME"]== textName.Text)
                {
                    datatable.Rows.RemoveAt(i);
                }
            }
            int n = datatable.Rows.Count - 1;
            if (n > -1)
            {
                lastIdSourse = (int)datatable.Rows[n]["ID"];


                //right lick
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
                    string text = datatable.Rows[currentSourse]["NAME"].ToString();

                    if (isSourse == "1")
                    {
                        pictureBox1.Image = a;
                    }
                    else
                    {
                        pictureBoxInsert.BackgroundImage = a;
                        textName.Text = text;
                    }
                }
                //right click
            }*/

            if (listSourst.Length == 1)
            {
                File.Delete(listSourst[currentSourse]);

                string path = "./PictureImageInsert/" + group;
                listSourst = Directory.GetFiles(path);
                pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.nen;
                pictureBoxInsert.Visible = false;
                textName.Text = "";
            }
            else if (listSourst.Length == 0)
            {
                pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.nen;
                pictureBoxInsert.Visible = false;
                textName.Text = "";
            }
            else
            {
                File.Delete(listSourst[currentSourse]);
                //right lick
                string path = "./PictureImageInsert/" + group;
                listSourst = Directory.GetFiles(path);
                // currentSourse++;
                if (currentSourse >= listSourst.Length)
                {
                    currentSourse = 0;
                }
                if (listSourst.Length > 0)
                {
                    Bitmap a;
                    using (var stream = File.Open(listSourst[currentSourse], FileMode.Open))
                    {
                        a = new Bitmap(Image.FromStream(stream));
                        stream.Close();
                    }

                    a.MakeTransparent();
                    string text = Path.GetFileName(listSourst[currentSourse]);
                    text = text.Remove(text.Length - 4, 4);

                    if (isSourse == "1")
                    {
                        pictureBox1.Image = a;
                    }
                    else
                    {
                        pictureBoxInsert.BackgroundImage = a;
                        textName.Text = text;
                    }
                }
                //right click


            }




            cnn.Close();
            //datatable.Rows.Remove()
            paneloneSourse.Visible = false;
        }

        private void pictureBoxInsert_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                paneloneSourse.Visible = true;
                paneloneSourse.Location = new Point(e.X + 250, e.Y + 60);
            }
        }

        private void checkVN()
        {
            //if (textName.Text == "") dataGridView3.Rows.Clear();
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
             "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ","0","1","2","3","4","5","6","7","8","9",};
            int n = nameGroup.Text.Length;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (nameGroup.Text.IndexOf(arr1[i]) != -1)
                {
                    /*label3_1.Text = "Bạn vừa nhập chuỗi có dấu hoặc có số. Vui lòng kiểm tra hoặc chúng tôi sẽ thực hiện chuyển kiểu tự động khi bạn thực hiện dịch đoạn !";
                    label3_1.ForeColor = Color.Red;*/
                    Add.Enabled = false;
                    return;
                }
            }

            Add.Enabled = true;
        }

        private void nameGroup_TextChanged(object sender, EventArgs e)
        {
            checkVN();
        }

        public string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
             "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y", };
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                //text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Click(object sender, EventArgs e)
        {
            currentPanel--;
            if (currentPanel == -1)
            {
                currentPanel = numberOfPanel - 1;
            }
            listFlowPanel[currentPanel].BringToFront();
            creatButton.BringToFront();
        }

        private void rightPannel_Click(object sender, EventArgs e)
        {
            currentPanel++;
            if (currentPanel == numberOfPanel)
            {
                currentPanel = 0;
            }
            listFlowPanel[currentPanel].BringToFront();
            creatButton.BringToFront();
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
                    //string t = new FileInfo(dlg.FileName).Name;
                    string t = Path.GetFileName(dlg.FileName);
                    t = RemoveUnicode(t);
                    //t = RemoveSpecialCharacters(t);
                    nameGroup.Text = t.Remove(t.Length - 4, 4);

                }

            }
        }

        private void addImage_Click(object sender, EventArgs e)
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
                    //string t = new FileInfo(dlg.FileName).Name;
                    string t = Path.GetFileName(dlg.FileName);
                    t = RemoveUnicode(t);
                    //t = RemoveSpecialCharacters(t);
                    nameGroup.Text = t.Remove(t.Length - 4, 4);
                    addImage.Visible = false;
                    guna2PictureBox1.Visible = true;

                }

            }

        }
    }
}

