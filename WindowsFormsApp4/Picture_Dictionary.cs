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
            if (sender == b1)
            {
                group = "Animal";
                
            }
            else if (sender == b2)
            {
                group = "Nature";
            }
            else if (sender == b3)
            {
                group = "Stationery";
            }
            else if (sender == b4)
            {
                group = "Music";
            }
            else if (sender == b5)
            {
                group = "Transport";
            }
            else if (sender == b6)
            {
                group = "Hospital";
            }
            else if (sender == b7)
            {
                group = "Buildings";
            }
            else if (sender == b8)
            {
                group = "Places";
            }
            else if (sender == b9)
            {
                group = "Subjects";
            }
            else if (sender == b10)
            {
                group = "Numbers";
            }
            else if (sender == b11)
            {
                group = "Counties";
            }
            else if (sender == b12)
            {
                group = "Home";
            }
            else if (sender == b13)
            {
                group = "Garden";
            }
            else if (sender == b14)
            {
                group = "Things";
            }
            else if (sender == b15)
            {
                group = "Colors";
            }
            else if (sender == b16)
            {
                group = "Letters";
            }
            else if (sender == b17)
            {
                group = "Kitchen";
            }
            else if (sender == b18)
            {
                group = "Body";
            }
            else if (sender == b19)
            {
                group = "Clothes";
            }
            else if (sender == b20)
            {
                group = "Food";
            }
            else if (sender == b21)
            {
                group = "Personal";
            }
            else if (sender == b22)
            {
                group = "Jobs";
            }
            else if (sender == b23)
            {
                group = "Bathroom";
            }
            else if (sender == b24)
            {
                group = "Sports";
            }
            else if (sender == b25)
            {
                group = "Computer";
            }
            DirectoryInfo dGroup = new DirectoryInfo("./PictureImage/" + group);
            nameImage = dGroup.GetFiles();
            panel1.Visible = true;
            pictureBox1.Image = Image.FromFile(nameImage[0].FullName);
        }
       
        private void Pause_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            currentPicture = 0;
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
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (currentPicture >0)
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
    }
}
