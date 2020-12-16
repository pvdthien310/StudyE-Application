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
    public partial class QuestionForm : Form
    {
        //public int[,] Result;
        public Start parent;
        public List<Question_Creep> list;
        public int isdraw;
        public QuestionForm(Start parent, ref List<Question_Creep> list, ref int isdraw)
        {
            InitializeComponent();
            //Result = new int[10,10];
            this.parent = parent;
            this.list = list;
            this.isdraw = isdraw;
        }
        private void Button_Click(object sender, EventArgs e)
        {

            this.parent.isdraw = 1;
            string[] temp = list[this.parent.game_host.current_question].question.GetQuestion();
            
            if (sender == guna2Button_answerA)
            {
                if (list[this.parent.game_host.current_question].type == 1)
                {
                    if (Convert.ToInt32(temp[5]) == 1)
                    {
                        list[this.parent.game_host.current_question].isCorrect = 1;
                    }
                    else
                    {
                        list[this.parent.game_host.current_question].isCorrect = 0;
                    }
                }
            }
            if (sender == guna2Button_answerB)
            {
                if (list[this.parent.game_host.current_question].type == 1)
                {
                    if (Convert.ToInt32(temp[5]) == 2)
                    {
                        list[this.parent.game_host.current_question].isCorrect = 1;
                    }
                    else
                    {
                        list[this.parent.game_host.current_question].isCorrect = 0;

                    }
                }

            }
            if (sender == guna2Button_answerC)
            {
                if (list[this.parent.game_host.current_question].type == 1)
                {
                    if (Convert.ToInt32(temp[5]) == 3)
                    {
                        list[this.parent.game_host.current_question].isCorrect = 1;
                    }
                    else
                    {
                        list[this.parent.game_host.current_question].isCorrect = 0;

                    }
                }

            }
            if (sender == guna2Button_answerD)
            {
                if (list[this.parent.game_host.current_question].type == 1)
                {
                    if (Convert.ToInt32(temp[5]) == 4)
                    {
                        list[this.parent.game_host.current_question].isCorrect = 1;
                    }
                    else
                    {
                        list[this.parent.game_host.current_question].isCorrect = 0;

                    }
                }

            }
            //if (sender == gunaButton_Submit)
            //{            
            //        if (list[this.parent.game_host.current_question].type == 2)
            //    {
            //        if (temp[1].ToLower() != guna2TextBox_answer2.Text.ToLower())
            //        {
            //            list[this.parent.game_host.current_question].isCorrect = 1;
            //        }
            //        else
            //        {
            //            list[this.parent.game_host.current_question].isCorrect = 0;
            //        }
            //    }
            //}
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = false;
            this.parent.gameForm.Invalidate();
        }
    }
}
