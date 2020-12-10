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

        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Parent.Show();
        }

        private void creatButton_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button but = new Guna.UI2.WinForms.Guna2Button();
            buttonImage b = new buttonImage();
            but = b.createButton();
            flowLayoutPanel1.Controls.Add(but);
        }
    }
}
