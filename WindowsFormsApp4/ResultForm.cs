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
        public mainForm grand_parent_parent;
        public startGameForm  grand_parent;
        public GameForm parent;
        private int current_question = 1;
        private Guna.UI2.WinForms.Guna2Button[] listbtn;
        private Guna.UI2.WinForms.Guna2Panel[] listpnl;
       
        
        private int pnl_member = 8; // so luong btn trong panel
        private int pnl_number ; // luc khoi tao thi dung de tao panel con luc chay thi dung de xac dinh dang o panel nao
        //public ResultForm()
        //{
        //    InitializeComponent();
        //}
        public ResultForm(GameForm parent,startGameForm grand_parent,mainForm grand_parent_parent)
        {
            InitializeComponent();
            listbtn = new Guna.UI2.WinForms.Guna2Button[parent.gameManager.quesData.number_question];
            this.grand_parent = grand_parent;
            this.grand_parent_parent = grand_parent_parent;
            this.parent = parent;
            string a = "Câu ";
            // Tao so luong panel;
            if (parent.gameManager.quesData.number_question % 8 == 0 )
            {
                listpnl = new Guna.UI2.WinForms.Guna2Panel[parent.gameManager.quesData.number_question / 8];
            }
            else
            {
                listpnl = new Guna.UI2.WinForms.Guna2Panel[parent.gameManager.quesData.number_question / 8 + 1];
            }
            for ( int j = 0; j < listpnl.Length; j++)
            {
                listpnl[j] = new Guna.UI2.WinForms.Guna2Panel() { Location = new System.Drawing.Point(27, 120), Size = new System.Drawing.Size(284, 428) };
                this.listpnl[j].BackColor = System.Drawing.Color.Transparent;
                this.Controls.Add(listpnl[j]);
            }
            pnl_number = 0;
            // Tao btn
            //for (int i = 0; i < parent.gameManager.quesData.number_question; i++)
            //{
            //    a = "Câu ";
            //    a = a + (i + 1).ToString();
            //    listbtn[i] = new Guna.UI2.WinForms.Guna2Button() { Text = a, Size = new System.Drawing.Size(30, 50) };
            //    listbtn[i].BorderRadius = 20;
            //    listbtn[i].Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            //    if (this.parent.gameManager.quesData.Result[i] == 1)
            //    {
            //        //listbtn[i].FillColor = System.Drawing.SystemColors.ActiveCaption;
            //        listbtn[i].FillColor = System.Drawing.Color.MediumSeaGreen;
            //    }
            //    else
            //    {
            //        listbtn[i].FillColor = System.Drawing.Color.IndianRed;

            //    }
            //    listbtn[i].ForeColor = System.Drawing.Color.White;
            //    listpnl[pnl_number].Controls.Add(listbtn[i]);

            //    if (pnl_member == 8)
            //    {
            //        pnl_member = 1;
            //        pnl_number++;
            //    }
            //    else
            //    {
            //        pnl_member++;
            //    }
            //    listbtn[i].Dock = DockStyle.Top;
            //    listbtn[i].Click += (s, e) =>
            //    {
            //        //listpnl[current_question/8].BringToFront();
            //        foreach (Guna.UI2.WinForms.Guna2Button x in listbtn)
            //        {
            //            if (s == x)
            //            {
            //                string temp = x.Text.Substring(4);
            //                current_question = Convert.ToInt32(temp);
            //                OpenQuestion(Convert.ToInt32(temp) - 1);
            //            }
            //        }

            //    };
            //    //if (i > this.parent.gameManager.current_ques_index)
            //    //{
            //    //    listbtn[i].Enabled = false;
            //    //}

            //    //listbtn[i].CheckedChanged += (s, e) =>
            //    //{
            //    //    string temp = listbtn[i].Text.Substring(listbtn[i].Text.Length - 1, 1);
            //    //    OpenQuestion(Convert.ToInt32(temp));

            //    //};
            //}
            //pnl_number = 0; // khoi tao khi mo form thi se mo panel 0
            //listpnl[0].BringToFront();
            for (int i = 0; listbtn[parent.gameManager.quesData.number_question-1]== null; )
            {
                if (pnl_member + 8 * pnl_number > parent.gameManager.quesData.number_question)
                {
                    pnl_member--;
                    continue;
                }
                a = "Câu ";
                a = a + (pnl_member + 8*pnl_number).ToString();
                listbtn[i] = new Guna.UI2.WinForms.Guna2Button() { Text = a, Size = new System.Drawing.Size(30, 50) };
                listbtn[i].BorderRadius = 20;
                listbtn[i].Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                if (this.parent.gameManager.quesData.Result[Convert.ToInt32(listbtn[i].Text.Substring(4)) - 1] == 1)
                {
                    //listbtn[i].FillColor = System.Drawing.SystemColors.ActiveCaption;
                    listbtn[i].FillColor = System.Drawing.Color.MediumSeaGreen;
                }
                else
                {
                    listbtn[i].FillColor = System.Drawing.Color.IndianRed;

                }
                listbtn[i].ForeColor = System.Drawing.Color.White;
                listpnl[pnl_number].Controls.Add(listbtn[i]);

                if (pnl_member <= 1)
                {
                    pnl_member = 8;
                    pnl_number++;
                }
                else
                {
                    pnl_member--;
                }
                listbtn[i].Dock = DockStyle.Top;
                listbtn[i].Click += (s, e) =>
                {
                    panel_Question.BringToFront();
                    foreach (Guna.UI2.WinForms.Guna2Button x in listbtn)
                    {
                        if (s == x)
                        {
                            string temp = x.Text.Substring(4);
                            current_question = Convert.ToInt32(temp);
                            OpenQuestion(Convert.ToInt32(temp) - 1);
                        }
                    }

                };
                string k = listbtn[i].Text.Substring(4);
                if (Convert.ToInt32(k) - 1 > this.parent.gameManager.current_ques_index)
                {
                    //listbtn[i].Enabled = false;
                    listbtn[i].FillColor = System.Drawing.Color.LightSlateGray;
                }
                i++;
                //listbtn[i].CheckedChanged += (s, e) =>
                //{
                //    string temp = listbtn[i].Text.Substring(listbtn[i].Text.Length - 1, 1);
                //    OpenQuestion(Convert.ToInt32(temp));

                //};
            }
            pnl_number = 0; // khoi tao khi mo form thi se mo panel 0
            listpnl[0].BringToFront();
            OpenQuestion(0); // vua mo len la load cau so 1 len lien :3
        }
        private void OpenQuestion(int i)
        {
            
            this.guna2ButtonA.FillColor = System.Drawing.Color.Teal;
            this.guna2ButtonB.FillColor = System.Drawing.Color.Teal;
            this.guna2ButtonC.FillColor = System.Drawing.Color.Teal;
            this.guna2ButtonD.FillColor = System.Drawing.Color.Teal;
            //this.guna2ButtonA.FillColor = System.Drawing.SystemColors.ActiveCaption;
            //this.guna2ButtonB.FillColor = System.Drawing.SystemColors.ActiveCaption;
            //this.guna2ButtonC.FillColor = System.Drawing.SystemColors.ActiveCaption;
            //this.guna2ButtonD.FillColor = System.Drawing.SystemColors.ActiveCaption;
            guna2Button_Question.Text =  current_question.ToString() + ". Nghĩa Của Từ : " + parent.gameManager.quesData.List[i].question + " Là Gì ?";
            if (this.parent.gameManager.quesData.Result[i] == 1)
            {
                switch (this.parent.gameManager.quesData.User_choose[i])
                {
                    case 1:
                        {
                            this.guna2ButtonA.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                    case 2:
                        {
                            this.guna2ButtonB.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                    case 3:
                        {
                            this.guna2ButtonC.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                    case 4:
                        {
                            this.guna2ButtonD.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                }
            }
            if (this.parent.gameManager.quesData.Result[i] == 0)
            {
                switch (this.parent.gameManager.quesData.User_choose[i])
                {
                    case 1:
                        {
                            this.guna2ButtonA.FillColor = System.Drawing.Color.IndianRed;
                            break;
                        }
                    case 2:
                        {
                            this.guna2ButtonB.FillColor = System.Drawing.Color.IndianRed;
                            break;
                        }
                    case 3:
                        {
                            this.guna2ButtonC.FillColor = System.Drawing.Color.IndianRed;
                            break;
                        }
                    case 4:
                        {
                            this.guna2ButtonD.FillColor = System.Drawing.Color.IndianRed;
                            break;
                        }
                }
                switch (this.parent.gameManager.quesData.List[i].correctIndex)
                {
                    case 1:
                        {
                            this.guna2ButtonA.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                    case 2:
                        {
                            this.guna2ButtonB.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                    case 3:
                        {
                            this.guna2ButtonC.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                    case 4:
                        {
                            this.guna2ButtonD.FillColor = System.Drawing.Color.MediumSeaGreen;
                            break;
                        }
                }
            }
            guna2ButtonA.Text = "A. " + parent.process_answer(parent.gameManager.quesData.List[i].answerA);
            guna2ButtonB.Text = "B. " + parent.process_answer(parent.gameManager.quesData.List[i].answerB);
            guna2ButtonC.Text = "C. " + parent.process_answer(parent.gameManager.quesData.List[i].answerC);
            guna2ButtonD.Text = "D. " + parent.process_answer(parent.gameManager.quesData.List[i].answerD);
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

            //  listpnl[current_question / 8].BringToFront();

            guna2TextBox_SearchWord.Clear();
            Design_UI_Word_EV(parent.gameManager.quesData.List[current_question - 1].answerB);
        }

        private void guna2ButtonC_Click(object sender, EventArgs e)
        {
            panel_Question_2.BringToFront();

            // listpnl[current_question / 8].BringToFront();

          
            guna2TextBox_SearchWord.Clear();
            Design_UI_Word_EV(parent.gameManager.quesData.List[current_question - 1].answerC);
        }

        private void guna2ButtonD_Click(object sender, EventArgs e)
        {
            panel_Question_2.BringToFront();

            //listpnl[current_question / 8].BringToFront();

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

        private void CircleButton_Exit_Click(object sender, EventArgs e)
        {
            this.grand_parent_parent.Show();
            this.parent.Close();
            this.grand_parent.Close();
            this.Close();
            //mainForm newmainForm = new mainForm();
            //newmainForm.Show();
        }

        private void CircleButton_Again_Click(object sender, EventArgs e)
        {
            startGameForm newgame = new startGameForm(this.grand_parent_parent);
            this.parent.Close();
            this.grand_parent.Close();
            this.grand_parent_parent.Hide();
            this.Close();
            newgame.Show();
            
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            /// Luu y phan nay bi nguoc // Do dung lenh Dock.Top nen cac button trong thu tu cac panel bi nguoc
            ///  vd panel 0 chua cac btn tu 17 -> 25 thay vi chua 0 -> 8
            if (pnl_number < listpnl.Length - 1)
            {
                pnl_number++;
            }
            else
            {
                pnl_number = 0;
            }
            listpnl[pnl_number].BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            /// Luu y phan nay bi nguoc // Do dung lenh Dock.Top nen cac button trong thu tu cac panel bi nguoc
            ///  vd panel 0 chua cac btn tu 17 -> 25 thay vi chua 0 -> 8
           

            if (pnl_number > 0)
            {
                pnl_number--;
            }
            else
            {
                pnl_number = listpnl.Length - 1;
            }
            listpnl[pnl_number].BringToFront();
        }
    }
}
