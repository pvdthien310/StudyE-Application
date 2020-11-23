using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ResultForm : Form
    {
        private GameForm parent;
        private int current_question = 1;
        private Guna.UI2.WinForms.Guna2Button[] listbtn;
        //public ResultForm()
        //{
        //    InitializeComponent();
        //}
        public ResultForm(GameForm parent)
        {
            InitializeComponent();
            listbtn = new Guna.UI2.WinForms.Guna2Button[parent.gameManager.quesData.number_question];
            this.parent = parent;
            string a = "Câu ";
            for (int i = parent.gameManager.quesData.number_question-1; i >= 0; i--)
            {
                a = "Câu ";
                a = a + (i+1).ToString();
                listbtn[i] = new Guna.UI2.WinForms.Guna2Button() { Text = a, Size = new System.Drawing.Size(30, 50) };
                listbtn[i].BorderRadius = 20;
                listbtn[i].Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                listbtn[i].FillColor = System.Drawing.SystemColors.ActiveCaption;
                listbtn[i].ForeColor = System.Drawing.Color.White;
                panel_ListQuestion.Controls.Add(listbtn[i]);
                listbtn[i].Dock = DockStyle.Top;
                listbtn[i].Click += (s, e) =>
                {
                    panel_Question.BringToFront();
                    foreach (Guna.UI2.WinForms.Guna2Button x in listbtn)
                     {
                        if ( s == x)
                        {
                            string temp = x.Text.Substring(4);
                            current_question = Convert.ToInt32(temp);
                            OpenQuestion(Convert.ToInt32(temp)-1);
                        }
                    }
                   
                };
                if (i > this.parent.gameManager.current_ques_index)
                {
                    listbtn[i].Enabled = false;
                }
                //listbtn[i].CheckedChanged += (s, e) =>
                //{
                //    string temp = listbtn[i].Text.Substring(listbtn[i].Text.Length - 1, 1);
                //    OpenQuestion(Convert.ToInt32(temp));

                //};
            }
        }
        private void OpenQuestion(int i)
        {
            guna2Button_Question.Text = "Nghĩa Của Từ : " + parent.gameManager.quesData.List[i].question + " Là Gì ?";
            guna2ButtonA.Text = parent.process_answer(parent.gameManager.quesData.List[i].answerA);
            guna2ButtonB.Text = parent.process_answer(parent.gameManager.quesData.List[i].answerB);
            guna2ButtonC.Text = parent.process_answer(parent.gameManager.quesData.List[i].answerC);
            guna2ButtonD.Text = parent.process_answer(parent.gameManager.quesData.List[i].answerD);
        }


        private void guna2ButtonA_Click(object sender, EventArgs e)
        {
            panel_Question_2.BringToFront();
            try
            {
                guna2TextBox_SearchWord.Clear();
                Design_UI_Word_EV(parent.gameManager.quesData.List[current_question - 1].answerA);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void guna2ButtonB_Click(object sender, EventArgs e)
        {
            panel_Question_2.BringToFront();

            guna2TextBox_SearchWord.Clear();
            Design_UI_Word_EV(parent.gameManager.quesData.List[current_question - 1].answerB);
        }

        private void guna2ButtonC_Click(object sender, EventArgs e)
        {
            panel_Question_2.BringToFront();

            guna2TextBox_SearchWord.Clear();
            Design_UI_Word_EV(parent.gameManager.quesData.List[current_question - 1].answerC);
        }

        private void guna2ButtonD_Click(object sender, EventArgs e)
        {
            panel_Question_2.BringToFront();

            guna2TextBox_SearchWord.Clear();
            Design_UI_Word_EV(parent.gameManager.quesData.List[current_question - 1].answerD);
        }

        public void Design_UI_Word_EV(string temp)
        {

            string[] lines = temp.Split('|');
            string show_line = "";
            string fix_lines;
            for (int i = 1; i < lines.Length; i++)
            {
                fix_lines = lines[i];
                fix_lines = fix_lines.Substring(1);
                if (lines[i][0] == '@')
                {
                    show_line += fix_lines.Trim();
                }
                else if (lines[i][0] == '*')
                {

                    show_line += "\r\n" + "\t" + fix_lines.Trim();
                }
                else if (lines[i][0] == '-')
                {

                    show_line += "\r\n" + "\t\t" + "*" + fix_lines.Trim();
                }
                else if (lines[i][0] == '=')
                {

                    show_line += "\r\n" + "\t\t\t" + "-" + fix_lines.Trim();
                }
                else if (lines[i][0] == '+')
                {
                    show_line += ":" + fix_lines.Trim();
                }
            }
            guna2TextBox_SearchWord.Text = show_line.Trim();
        }

        private void CircleButton_back_Click(object sender, EventArgs e)
        {
            guna2TextBox_SearchWord.Clear();
            panel_Question.BringToFront();
        }
    }
}
