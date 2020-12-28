using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp4
{
    public partial class GameForm : Form
    {
        public startGameForm parent;
        Bitmap gamebackground = new Bitmap("background.jpg");
        private Bitmap avatar;
        private Bitmap sprite;
        private Bitmap creep;
        private Bitmap alock;
        // Back buffer
        private Bitmap backBuffer;
        public Timer timer_;
        public Bitmap heart;


        public Timer timer_countdown; // dem thoi gian tra loi cau hoi
        public int score = 20;


        public Graphics graphics;
        // Số thự tự của frame (16 frame ảnh)
        private int index;
        // dòng hiện tại của frame
        private int curFrameColumn;
        // cột hiện tại của frame
        private int curFrameRow;

        private int location_char = 100; // vi tri ban dau con yasuo dung
        private int location_creep = 800;

        // bien check
        int Q_check = 0;
        int isCorrect = 0;
        int char_action_goback = 0; // 0 la da di ve roi 1 la chua di ve 2 la moi di ve -> chuyen cau khac
        public int user_lives;

        public ResultForm resultgameform;

        // Quan ly game 
        public GameManager gameManager;
        public int ismusicon1 = 1;

        public GameForm(int isChallenge, int whatCharacter, startGameForm parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            user_lives = 3;
            alock = new Bitmap("lock1.png");
            creep = new Bitmap("creep.png");

            heart = new Bitmap("heart.png");
            index = 0; // 0: chua tra loi, 1: dung, 2:sai
            gameManager = new GameManager(isChallenge, whatCharacter);
            LoadQuestion();
            sprite = gameManager.userCharacter.char_sprite;
            timer_ = new Timer();
            timer_.Interval = 500;
            timer_.Enabled = true;
            timer_.Tick += new EventHandler(timer_Tick);
            ///
            timer_countdown = new Timer();
            timer_countdown.Interval = 1000;
            timer_countdown.Enabled = true;
            timer_countdown.Tick += new EventHandler(timer_countdown_Tick);
            //
            gameManager.username = this.parent.guna2TextBox3.Text;
            //
            avatar = new Bitmap(gameManager.userCharacter.avatar);
            //pictureBox_avatar.BackColor = Color.Transparent;
            //gameManager.userCharacter.avatar.MakeTransparent();
            //pictureBox_avatar.Image = gameManager.userCharacter.avatar;
            //pictureBox_avatar.SizeMode = PictureBoxSizeMode.Zoom;

            //Bitmap heart = new Bitmap("heart.png");
            //heart.MakeTransparent();
            //pictureBox_heart1.BackColor = Color.Transparent;
            //pictureBox_heart2.BackColor = Color.Transparent;
            //pictureBox_heart3.BackColor = Color.Transparent;
            //pictureBox_heart1.Image = heart;
            //pictureBox_heart2.Image = heart;
            //pictureBox_heart3.Image = heart;
            //pictureBox_heart1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox_heart2.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox_heart3.SizeMode = PictureBoxSizeMode.Zoom;

            //username.Text = this.parent.guna2TextBox3.Text;

            //pictureBox_avatar.Image = gameManager.userCharacter.avatar;
            //username.Text = parent.guna2TextBox3.Text;




        }
        private void timer_countdown_Tick(object sender, EventArgs e)
        {
            score--;
            if (score == 0)
            {
                isCorrect = this.Check_Answer(99);
                //isCorrect = 2;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //if (isCorrect == 0 && char_action_goback == 0)
            //{
            //    timer.Enabled = false;
            //    return;
            //}
            if (isCorrect == 4)
            {
                OpenResultForm();
                timer_.Enabled = false;

            }
            timer_.Interval = 50;
            if (isCorrect == 1 || isCorrect == 2 || isCorrect == 3 || index1 == 0)
                this.Invalidate();
        }
        public int index1 = 0;
        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            // curFrameColumn = index % 4;
            Bitmap background_char = new Bitmap("background.jpg");

            if (isCorrect == 1)
            {
                timer_countdown.Enabled = false;
                gameManager.userCharacter.Correct_action(e, ref isCorrect, ref Q_check, ref char_action_goback, ref location_char, ref location_creep);              
                return;

            }
            else if (isCorrect == 2)
            {
                timer_countdown.Enabled = false;
                gameManager.userCharacter.Incorrect_action(e, ref isCorrect, ref Q_check, ref char_action_goback, ref location_char, ref location_creep);
                
                return;

            }
            if (char_action_goback == 0 && isCorrect == 0)
            {
                //e.graphics.drawimage(background_char, 2, 1);
                e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                e.Graphics.DrawImage(creep, location_creep, 430, new Rectangle(0, 0, 88, 110), GraphicsUnit.Pixel);
                e.Graphics.DrawImage(sprite, location_char, 385, new Rectangle(0, 0, 88, 108), GraphicsUnit.Pixel);
                e.Graphics.DrawImage(alock, new Rectangle(465, 142, 65, 70), new Rectangle(0, 0, 90, 90), GraphicsUnit.Pixel);
                e.Graphics.DrawString(gameManager.username, new Font("Segoe UI", 14f, FontStyle.Bold), Brushes.White, new Point(90, 510));
                if (score > 5)
                e.Graphics.DrawString(score.ToString(), new Font("Segoe UI", 14f, FontStyle.Bold), Brushes.MediumSeaGreen, new Point(482, 223));
                else
                e.Graphics.DrawString(score.ToString(), new Font("Segoe UI", 14f, FontStyle.Bold), Brushes.Red, new Point(482, 223));

                e.Graphics.DrawImage(avatar, new Rectangle(20, 500, 60, 60), new Rectangle(0, 0, 80, 85), GraphicsUnit.Pixel);
                if (user_lives > 0)                
                    e.Graphics.DrawImage(heart, new Rectangle(90, 535, 20, 20), new Rectangle(0, 0, 225, 225), GraphicsUnit.Pixel);
                if (user_lives > 1)
                    e.Graphics.DrawImage(heart, new Rectangle(112, 535, 20, 20), new Rectangle(0, 0, 225, 225), GraphicsUnit.Pixel);
                if (user_lives > 2)
                    e.Graphics.DrawImage(heart, new Rectangle(134, 535, 20, 20), new Rectangle(0, 0, 225, 225), GraphicsUnit.Pixel);
                //index1++;
                return;
            }
            if (char_action_goback == 0 && isCorrect == 3)
            {
                //e.graphics.drawimage(background_char, 2, 1);
                // e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 590), new Rectangle(0, 0, 929, 393), GraphicsUnit.Pixel);
                e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                e.Graphics.DrawImage(creep, location_creep, 430, new Rectangle(0, 0, 88, 110), GraphicsUnit.Pixel);
                e.Graphics.DrawImage(sprite, location_char, 385, new Rectangle(0, 0, 88, 113), GraphicsUnit.Pixel);              
                e.Graphics.DrawImage(alock, new Rectangle(465, 142, 65, 70), new Rectangle(0, 0, 90, 90), GraphicsUnit.Pixel);
                e.Graphics.DrawString(score.ToString(), new Font("Segoe UI", 14f, FontStyle.Bold), Brushes.MediumSeaGreen, new Point(482, 223));
                e.Graphics.DrawImage(avatar, new Rectangle(20, 500, 60, 60), new Rectangle(0, 0, 80, 85), GraphicsUnit.Pixel);
                if (user_lives > 0)
                    e.Graphics.DrawImage(heart, new Rectangle(90, 535, 20, 20), new Rectangle(0, 0, 225, 225), GraphicsUnit.Pixel);
                if (user_lives > 1)
                    e.Graphics.DrawImage(heart, new Rectangle(112, 535, 20, 20), new Rectangle(0, 0, 225, 225), GraphicsUnit.Pixel);
                if (user_lives > 2)
                    e.Graphics.DrawImage(heart, new Rectangle(134, 535, 20, 20), new Rectangle(0, 0, 225, 225), GraphicsUnit.Pixel);

                gameManager.current_ques_index++;
                LoadQuestion();
                Reset_Status();
                timer_countdown.Enabled = true;
                isCorrect = 0;
                score = 20;
                //index1++;
                return;
            }


        }
        private void Reset_Status()
        {
            game_btnA.Enabled = true;
            game_btnB.Enabled = true;
            game_btnC.Enabled = true;
            game_btnD.Enabled = true;
            this.game_btnD.FillColor = System.Drawing.Color.Teal;
            this.game_btnA.FillColor = System.Drawing.Color.Teal;
            this.game_btnB.FillColor = System.Drawing.Color.Teal;
            this.game_btnC.FillColor = System.Drawing.Color.Teal;

        }
        private void game_btnA_Click(object sender, EventArgs e)
        {
            this.gameManager.quesData.User_choose[this.gameManager.current_ques_index] = 1;
            game_btnB.FillColor = Color.Gray;
            game_btnC.FillColor = Color.Gray;
            game_btnD.FillColor = Color.Gray;
            isCorrect = this.Check_Answer(1);
            game_btnB.Enabled = false;
            game_btnC.Enabled = false;
            game_btnD.Enabled = false;


        }

        private void game_btnB_Click(object sender, EventArgs e)
        {
            this.gameManager.quesData.User_choose[this.gameManager.current_ques_index] = 2;

            game_btnA.FillColor = Color.Gray;
            game_btnC.FillColor = Color.Gray;
            game_btnD.FillColor = Color.Gray;
            isCorrect = this.Check_Answer(2); ;
            game_btnA.Enabled = false;
            game_btnC.Enabled = false;
            game_btnD.Enabled = false;

        }

        private void game_btnC_Click(object sender, EventArgs e)
        {
            this.gameManager.quesData.User_choose[this.gameManager.current_ques_index] = 3;

            game_btnB.FillColor = Color.Gray;
            game_btnA.FillColor = Color.Gray;
            game_btnD.FillColor = Color.Gray;
            isCorrect = this.Check_Answer(3);
            game_btnB.Enabled = false;
            game_btnA.Enabled = false;
            game_btnD.Enabled = false;

        }

        private void game_btnD_Click(object sender, EventArgs e)
        {
            this.gameManager.quesData.User_choose[this.gameManager.current_ques_index] = 4;

            game_btnB.FillColor = Color.Gray;
            game_btnC.FillColor = Color.Gray;
            game_btnA.FillColor = Color.Gray;
            isCorrect = this.Check_Answer(4);
            game_btnB.Enabled = false;
            game_btnC.Enabled = false;
            game_btnA.Enabled = false;

        }
        private void LoadQuestion()
        {
            if (gameManager.current_ques_index == gameManager.quesData.number_question)
            {
                OpenResultForm();
                return;
            }
            game_question.Text = gameManager.quesData.List[gameManager.current_ques_index].question + " ?";
            game_btnA.Text = "A. " + process_answer(gameManager.quesData.List[gameManager.current_ques_index].answerA);
            game_btnB.Text = "B. " + process_answer(gameManager.quesData.List[gameManager.current_ques_index].answerB);
            game_btnC.Text = "C. " + process_answer(gameManager.quesData.List[gameManager.current_ques_index].answerC);
            game_btnD.Text = "D. " + process_answer(gameManager.quesData.List[gameManager.current_ques_index].answerD);
        }
        public void OpenResultForm()
        {
            this.parent.music.controls.stop();
            this.Hide();
            this.parent.Hide();
            resultgameform = new ResultForm(this, this.parent, this.parent.parent);
            //resultgameform.TopLevel = false;
            resultgameform.FormBorderStyle = FormBorderStyle.None;
            resultgameform.Dock = DockStyle.Fill;
            //resultgameform.BringToFront();
            resultgameform.Show();
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
        private int Check_Answer(int user_answer)
        {
            if (user_answer > 4)
            {
                gameManager.quesData.Result[gameManager.current_ques_index] = 0;
                user_lives--;
                return 2;
            }

            if (user_answer == gameManager.quesData.List[gameManager.current_ques_index].correctIndex)
            {
                gameManager.quesData.Result[gameManager.current_ques_index] = 1;
                return 1;
            }
            else
            {
                gameManager.quesData.Result[gameManager.current_ques_index] = 0;
                user_lives--;
                return 2;
                
            }
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            if (ismusicon1 == 1)
            {
                this.parent.music.controls.stop();
                ismusicon1--;
            }
            else
            {
                this.parent.music.controls.play();
                ismusicon1++;
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.parent.music.controls.stop();
            this.Close();
            this.parent.parent.Show();
            this.parent.Close();
            
        }
    }
}
