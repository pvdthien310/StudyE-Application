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
    public partial class Start : Form
    {
        public GameForm2 gameForm;
        public QuestionForm  questionForm;
        public RoomForm roomform;
        //
        public Bitmap background;
        public Bitmap yasuo_sprite;
        public Bitmap creep;
        public int direction; // xac dinh phuong huong
        public int X_yasuo;
        public int Y_yasuo;
        public int whatframes; // khung hinh thu bao nhieu 
        public Timer timer;
        public int isdraw;
        //
        public GameManager_2 game_host;
        public List<Question_Creep> game_creep;
        
        public Start()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            yasuo_sprite = new Bitmap("yasuosprite.png");
            background = new Bitmap("background_1.jpg");
            creep = new Bitmap("creep.png");
            X_yasuo = Y_yasuo = 20;
            whatframes = direction = 0; // 0 phai 1 trai 2 tren 3 duoi 4 dung yen 
            DoubleBuffered = true;
            isdraw = 1;




        }
        public Start(RoomForm roomform, GameManager_2 gameForm)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            yasuo_sprite = new Bitmap("yasuosprite.png");
            background = new Bitmap("background_1.jpg");
            creep = new Bitmap("creep.png");
            X_yasuo = Y_yasuo = 20;
            whatframes = direction = 0; // 0 phai 1 trai 2 tren 3 duoi 4 dung yen 
            DoubleBuffered = true;
            isdraw = 1;




        }
        private void check()
        {
            for (int i = 0; i < 10 ;i++)
            {
                if (Math.Abs(X_yasuo - game_creep[i].X_creep) <= 50 && Math.Abs(Y_yasuo - game_creep[i].Y_creep)<= 50 && game_creep[i].isCorrect == 2)
                {
                    game_host.current_question = i;
                    string[] value = game_creep[i].question.GetQuestion();
                    switch (game_creep[i].type)
                    {
                        case 1:
                            {
                                questionForm.guna2Panel1.Visible = true;
                                questionForm.guna2Panel1.BringToFront();
                                questionForm.guna2Button_question1.Text = value[0];
                                questionForm.guna2Button_answerA.Text = process_answer(value[1]);
                                questionForm.guna2Button_answerB.Text = process_answer(value[2]);
                                questionForm.guna2Button_answerC.Text = process_answer(value[3]);
                                questionForm.guna2Button_answerD.Text = process_answer(value[4]);
                                
                                break;
                            }
                        case 2:
                            {
                                questionForm.guna2Panel2.Visible = true;
                                questionForm.guna2TextBox_answer2.Clear();
                                questionForm.guna2Panel2.BringToFront();
                                questionForm.guna2Button_question2.Text = value[0];                              
                                break;
                            }
                    }
                    isdraw = 0;
                    return;
                    
                }
            }
        }
     
        
        public void gameForm_paint(object sender, PaintEventArgs e)
        {
            int count = 0;
            check();
            if (whatframes == 3) whatframes = 0;
            else whatframes++;
            e.Graphics.DrawImage(background, new Rectangle(0, 0, 1000, 590), new Rectangle(0, 0, 500, 400), GraphicsUnit.Pixel);
            e.Graphics.DrawImage(yasuo_sprite, new Rectangle(X_yasuo,Y_yasuo,60,80), new Rectangle(whatframes * 95, direction * 120, 95, 110), GraphicsUnit.Pixel);
            for ( int i = 0; i< 10;i++)
            {
                if (game_creep[i].isCorrect == 2)
                    e.Graphics.DrawImage(creep, new Rectangle(game_creep[i].X_creep, game_creep[i].Y_creep, 60, 45), new Rectangle(0, 0, 90, 70), GraphicsUnit.Pixel);
                else count++;

                if (count == 10)
                {
                    for ( int j = 0;j < 10; j++)
                    {
                        if (game_creep[j].isCorrect == 1) count++;
                    }
                    
                    DialogResult dialogResult = MessageBox.Show("Hay qua dkmm !! {0}", (count - 10).ToString(),MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //
            game_host = new GameManager_2(this);
            //
            gameForm = new GameForm2(this);
            gameForm.FormBorderStyle = FormBorderStyle.None;
            gameForm.BackColor = Color.Red;
            gameForm.Paint += gameForm_paint;
            gameForm.MdiParent = this;           
            gameForm.Show();           
            gameForm.Dock = DockStyle.Left;
            //

            CreateCreep();
            //

            questionForm = new QuestionForm(this, ref game_creep,ref isdraw);
            questionForm.FormBorderStyle = FormBorderStyle.None;
            questionForm.MdiParent = this;
            questionForm.Dock = DockStyle.Right;
            questionForm.Show();

            //

            gameForm.Invalidate();



        }
        private void CreateCreep()
        {
            game_creep = new List<Question_Creep>();
            for ( int i = 0;i < 10;i++)
            {
                game_creep.Add(new Question_Creep(game_host.list[i]));
            }
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (isdraw == 0) return;
            if (e.KeyCode == Keys.D)
            {
                direction = 0;
                if (X_yasuo <= gameForm.Size.Width-50)
                X_yasuo += 20;
                gameForm.Invalidate();
            }
            if (e.KeyCode == Keys.W)
            {
                direction = 3;
                if (Y_yasuo >= 0)
                    Y_yasuo -= 20;
                gameForm.Invalidate();
            }
            if (e.KeyCode == Keys.S)
            {
                direction = 2;
                if (Y_yasuo <= gameForm.Size.Height - 70) 
                    Y_yasuo += 20;
                gameForm.Invalidate();
            }
            else if (e.KeyCode == Keys.A)
            {
                direction = 1;
               if (X_yasuo >= 0) 
                X_yasuo -= 20;
                gameForm.Invalidate();
            }
           
           
        }
        public string process_answer(string unprocessed_string)
        {
            string[] lines = unprocessed_string.Split('|');
            string show_line = "";
            string fix_lines;
            int index = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                fix_lines = lines[i];
                fix_lines = fix_lines.Substring(1);
                if (lines[i][0] == '*')
                {

                    show_line += fix_lines.Trim();
                    index++;
                    if (index == 1) show_line += " - ";
                }
                else if (lines[i][0] == '-')
                {

                    show_line += fix_lines.Trim();
                    index++;
                    if (index == 1) show_line += " - ";
                }
                if (index == 2) break;
            }
            return show_line;
        }

    }
}
