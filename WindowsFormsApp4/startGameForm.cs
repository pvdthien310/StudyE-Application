using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace WindowsFormsApp4
{
    public partial class startGameForm : Form
    {
        Bitmap gamebackground = new Bitmap("background.jpg");
        private Bitmap sprite;
        private Bitmap creep;
        // Back buffer
        private Bitmap backBuffer;
        private Timer timer;
        public Graphics graphics;
        // Số thự tự của frame (16 frame ảnh)
        private int index;
        // dòng hiện tại của frame
        private int curFrameColumn;
        // cột hiện tại của frame
        private int curFrameRow;

        private int location_char = 100; // vi tri ban dau con yasuo dung
        private int location_creep = 600;
        
        // bien check
        int Q_check = 0;
        int isCorrect = 1;
        int char_action_goback = 0;
        int Q_finish_delay = 1000;
        public GameForm childgameform;
        public mainForm parent;
        public int ismusicon = 1;

        // Quan ly game
        
        private int isChallenge; // che do nao challenge hay practise // kho qua dkm 
        private int whatCharacter = 1; // 1- darius 2 - phantheon 3 - yasuo

        // nhac
        
        public WindowsMediaPlayer music = new WindowsMediaPlayer();
        public startGameForm()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            //DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            // Tạo back buffer
            backBuffer = new Bitmap(this.ClientSize.Width,this.ClientSize.Height);
            // Lấy ảnh sprite
            sprite = new Bitmap("yasuosprite.png");
            creep = new Bitmap("creep.png");
            index = 0; // 0: chua tra loi, 1: dung, 2:sai
            //this.ControlBox = false;
            this.Text = String.Empty;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ///
            music.URL = "FallenKingdom.mp3";
            music.settings.volume = 30;
            music.controls.play();

           
            //pictureBox1.BackColor = Color.Transparent;
            
          



        }
        public startGameForm(mainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            graphics = this.CreateGraphics();
            //DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            // Tạo back buffer
            backBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            // Lấy ảnh sprite
            sprite = new Bitmap("yasuosprite.png");
            creep = new Bitmap("creep.png");
            index = 0; // 0: chua tra loi, 1: dung, 2:sai
            //this.ControlBox = false;
            this.Text = String.Empty;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ///
            music.URL = "FallenKingdom.mp3";
            music.settings.volume = 30;
            music.controls.play();


            //pictureBox1.BackColor = Color.Transparent;





        }

        //private void Render()
        //{
        //    Graphics g = Graphics.FromImage(backBuffer);

        //    // Xác dịnh số dòng, cột của một frame trên ảnh sprite
        //    curFrameColumn = index % 4;
        //    // Vẽ lên buffer
        //    //backBuffer.MakeTransparent();

        //    //g.Clear(Color.White);
        //    Bitmap background_char = new Bitmap("background_char.jpg");
        //    if (Q_check == 1 && char_action_goback == 1)
        //    {
        //        if (location_char == 100)
        //        {
        //            g.DrawImage(background_char, 2, 1);
        //            g.SmoothingMode = SmoothingMode.AntiAlias;
        //            g.DrawImage(sprite, location_char, 210, new Rectangle(0, 0, 88, 113), GraphicsUnit.Pixel);
        //            g.Dispose();

        //            Q_check = 0;
        //            char_action_goback = 0;
        //            location_creep = 600;
        //            location_char = 100;
        //        }
        //        else
        //        {
        //            g.DrawImage(background_char, 2, 1);
        //            g.SmoothingMode = SmoothingMode.AntiAlias;
        //            g.DrawImage(sprite, location_char, 210, new Rectangle(curFrameColumn * 88, 120, 84, 110), GraphicsUnit.Pixel);
        //            g.Dispose();
        //            location_char -= 20;
        //        }
        //        if (index > 16)
        //            index = 0;
        //        else
        //            index++;
        //        return;
        //    }
        //    else if( char_action_goback == 0 && (isCorrect == 1 || isCorrect == 2))
        //    {
        //        // Lấy đối tượng graphics để vẽ lên back buffer

        //        g.DrawImage(background_char, 2, 1);
        //        g.SmoothingMode = SmoothingMode.AntiAlias;
        //        g.DrawImage(sprite, location_char, 210, new Rectangle(curFrameColumn * 88, 0, 84, 111), GraphicsUnit.Pixel);
        //        g.DrawImage(creep, location_creep, 250, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);

        //        g.Dispose();


        //        //guna2Panel3.BackgroundImage = gamebackground;
        //        //guna2Panel3.BackgroundImageLayout = ImageLayout.Stretch;

        //        // Tăng thứ tự frame để lấy frame tiếp theo

        //        if (index > 16)
        //            index = 0;
        //        else
        //        { index++; }        
        //        location_char += 20;
        //        location_creep -= 20;


        //    }





        //}
        //private void timer_Tick(object sender, EventArgs e)
        // {
        //     if (location_char >= (location_creep -30) && isCorrect == 1 && Q_finish_delay > 0)
        //     {

        //         Bitmap char_action = new Bitmap("yasuosprite_action.png");

        //         Bitmap creep_death = new Bitmap("creep_death.png");
        //         creep = new Bitmap("creep.png");
        //         Graphics g = Graphics.FromImage(backBuffer);
        //         Bitmap background_char = new Bitmap("background_char.jpg");
        //         background_char.MakeTransparent();
        //         g.DrawImage(background_char, 2, 1);
        //         g.SmoothingMode = SmoothingMode.AntiAlias;
        //         g.DrawImage(char_action, location_char, 210, new Rectangle(0, 0, 200, 110), GraphicsUnit.Pixel);
        //         if (Q_finish_delay == 500) g.DrawImage(creep, location_creep, 250, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
        //         else
        //             g.DrawImage(creep_death, location_creep + 60, 250, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
        //         g.Dispose();

        //         isCorrect--;
        //         if (Q_finish_delay == 0) Q_check = 0;
        //         else Q_finish_delay--;// da chem xong ;
        //         char_action_goback = 1; // check xem char da ve vi tri ban dau chua
        //         graphics.DrawImageUnscaled(backBuffer, 0, 0);
        //         return;
        //     }
        //     else if (location_char >= 330 && isCorrect == 0)
        //     {

        //         Bitmap char_action = new Bitmap("yasuosprite_action.png");

        //         Bitmap creep_death = new Bitmap("creep_death.png");
        //         Graphics g = Graphics.FromImage(backBuffer);
        //         Bitmap background_char = new Bitmap("background_char.jpg");
        //         background_char.MakeTransparent();
        //         g.DrawImage(background_char, 2, 1);
        //         g.SmoothingMode = SmoothingMode.AntiAlias;
        //         g.DrawImage(char_action, location_char, 210, new Rectangle(0, 0, 200, 110), GraphicsUnit.Pixel);
        //         g.DrawImage(creep_death, location_creep + 60, 250, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
        //         g.Dispose();
        //         graphics.DrawImageUnscaled(backBuffer, 0, 0);
        //         isCorrect--;
        //         Q_check = 1; // da chem xong ;
        //         char_action_goback = 1; // check xem char da ve vi tri ban dau chua
        //     }

        //     //backBuffer.Dispose();
        //     //backBuffer = new Bitmap(this.ClientSize.Width,this.ClientSize.Height);    
        //     Render();
        //     // Vẽ lên màn hình
        //     graphics.DrawImageUnscaled(backBuffer, 0, 0);



        // }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            //guna2Panel3.Visible = false;

            //timer = new Timer();
            //timer.Enabled = true;
            //timer.Interval = 300;
            //timer.Tick += new EventHandler(timer_Tick);
            //childgameform = new GameForm(this);
            // this.Hide();

            if (childgameform != null)
            {
                childgameform.Close();
            }

            childgameform = new GameForm(isChallenge, whatCharacter, this);
            childgameform.TopLevel = false;
            childgameform.FormBorderStyle = FormBorderStyle.None;
            childgameform.Dock = DockStyle.Fill;
            guna2Panel3.Controls.Add(childgameform);
            guna2Panel3.Tag = childgameform;
            childgameform.BringToFront();
            childgameform.Show();




        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            music.controls.stop();
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = true;
            guna2Circle_music.BringToFront();
            music.URL = "panel2_3_music.mp3";
            music.controls.play();
        }
        private void guna2Button2_Challange_Click(object sender, EventArgs e)
        {
            isChallenge = 1;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = true;
            guna2Circle_music.BringToFront();
            Bitmap darius_char = new Bitmap(@"darius.png");
            guna2PictureBox3.BackColor = Color.Transparent;
            darius_char.MakeTransparent();
            guna2PictureBox3.Image = darius_char;

            Bitmap pantheon_char = new Bitmap(@"pantheon.png");
            guna2PictureBox3_2.BackColor = Color.Transparent;
            pantheon_char.MakeTransparent();
            guna2PictureBox3_2.Image = pantheon_char;

            Bitmap yasuo_char = new Bitmap(@"yasuo.png");
            guna2PictureBox3_3.BackColor = Color.Transparent;
            yasuo_char.MakeTransparent();
            guna2PictureBox3_3.Image = yasuo_char;

            Bitmap arrow_choose = new Bitmap(@"arrow1.png");
            guna2PictureBox3_Ar1.BackColor = Color.Transparent;
            guna2PictureBox3_Ar2.BackColor = Color.Transparent;
            guna2PictureBox3_Ar3.BackColor = Color.Transparent;
            arrow_choose.MakeTransparent();
            guna2PictureBox3_Ar1.Image = arrow_choose;
            guna2PictureBox3_Ar2.Image = arrow_choose;
            guna2PictureBox3_Ar3.Image = arrow_choose;

            guna2PictureBox3_Ar2.Visible = false;
            guna2PictureBox3_Ar3.Visible = false;



        }

        private void guna2Button3_Left_Click(object sender, EventArgs e)
        {
            if (guna2PictureBox3_Ar3.Visible == true)
            {
                whatCharacter = 2; // chon phantheon
                guna2PictureBox3_Ar3.Visible = false;
                guna2PictureBox3_Ar2.Visible = true;
            }
            else if (guna2PictureBox3_Ar2.Visible == true)
            {
                whatCharacter = 1; // chon darius
                guna2PictureBox3_Ar2.Visible = false;
                guna2PictureBox3_Ar1.Visible = true;
            }
        }

        private void guna2Button3_Right_Click(object sender, EventArgs e)
        {
            if (guna2PictureBox3_Ar1.Visible == true)
            {
                whatCharacter = 2; // chon pantheon
                guna2PictureBox3_Ar1.Visible = false;
                guna2PictureBox3_Ar2.Visible = true;
            }
            else if (guna2PictureBox3_Ar2.Visible == true)
            {
                whatCharacter = 3; // yasuo
                guna2PictureBox3_Ar2.Visible = false;
                guna2PictureBox3_Ar3.Visible = true;
            }
        }

        private void guna2Button3_Choose_Click(object sender, EventArgs e)
        {
            music.controls.stop();
            music.URL = "game_music1.mp3";
            music.controls.play();
            if (guna2PictureBox3_Ar1.Visible == true)
            {
                Bitmap darius_char = new Bitmap(@"darius.png");
                guna2PictureBox3_2.BackColor = Color.Transparent;
                darius_char.MakeTransparent();
                guna2PictureBox3_2.Image = darius_char;
                guna2PictureBox3_Ar1.Visible = false;
                guna2HtmlLabel3_Speech.Text = "They will regret opposing me.";
            }
            else if (guna2PictureBox3_Ar3.Visible == true)
            {
                Bitmap yasuo_char = new Bitmap(@"yasuo.png");
                guna2PictureBox3_2.BackColor = Color.Transparent;
                yasuo_char.MakeTransparent();
                guna2PictureBox3_2.Image = yasuo_char;
                guna2PictureBox3_Ar3.Visible = false;
                guna2HtmlLabel3_Speech.Text = "Death is like the wind - always by my side";
            }
            else
            {
                guna2PictureBox3_Ar2.Visible = false;
                guna2HtmlLabel3_Speech.Text = "Flee, and the spear will find your back.";
            }
            guna2PictureBox3.Visible = false;
            guna2PictureBox3_3.Visible = false;
            guna2Button3_Choose.Visible = false;
            timer1 = new Timer();
            timer1.Enabled = true;
            timer1.Interval = 600;
            timer1.Tick += new EventHandler(timer1_Tick);

        }

       

        private void guna2Panel3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (guna2PictureBox3_Ar3.Visible == true)
                {
                    guna2PictureBox3_Ar3.Visible = false;
                    guna2PictureBox3_Ar2.Visible = true;
                }
                else if (guna2PictureBox3_Ar2.Visible == true)
                {
                    guna2PictureBox3_Ar2.Visible = false;
                    guna2PictureBox3_Ar1.Visible = true;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (guna2PictureBox3_Ar3.Visible == true)
                {
                    guna2PictureBox3_Ar3.Visible = false;
                    guna2PictureBox3_Ar2.Visible = true;
                }
                else if (guna2PictureBox3_Ar2.Visible == true)
                {
                    guna2PictureBox3_Ar2.Visible = false;
                    guna2PictureBox3_Ar1.Visible = true;
                }
            }
        }

        private void guna2Button2_Practise_Click(object sender, EventArgs e)
        {
            if (this.parent.EV_SWlist.list.Count < 100)
            {
                MessageBox.Show("Your Look-Up Words List Isn't Enough To Start The Game !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isChallenge = 0;
            
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = true;
            Bitmap darius_char = new Bitmap(@"darius.png");
            guna2PictureBox3.BackColor = Color.Transparent;
            darius_char.MakeTransparent();
            guna2PictureBox3.Image = darius_char;

            Bitmap pantheon_char = new Bitmap(@"pantheon.png");
            guna2PictureBox3_2.BackColor = Color.Transparent;
            pantheon_char.MakeTransparent();
            guna2PictureBox3_2.Image = pantheon_char;

            Bitmap yasuo_char = new Bitmap(@"yasuo.png");
            guna2PictureBox3_3.BackColor = Color.Transparent;
            yasuo_char.MakeTransparent();
            guna2PictureBox3_3.Image = yasuo_char;

            Bitmap arrow_choose = new Bitmap(@"arrow1.png");
            guna2PictureBox3_Ar1.BackColor = Color.Transparent;
            guna2PictureBox3_Ar2.BackColor = Color.Transparent;
            guna2PictureBox3_Ar3.BackColor = Color.Transparent;
            arrow_choose.MakeTransparent();
            guna2PictureBox3_Ar1.Image = arrow_choose;
            guna2PictureBox3_Ar2.Image = arrow_choose;
            guna2PictureBox3_Ar3.Image = arrow_choose;

            guna2PictureBox3_Ar2.Visible = false;
            guna2PictureBox3_Ar3.Visible = false;


        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.ForeColor = Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.guna2Button1.Location = new System.Drawing.Point(337, 204);
            this.guna2Button1.Location = new System.Drawing.Point(guna2Button1.Location.X-20, guna2Button1.Location.Y-10);
            this.guna2Button1.Size = new System.Drawing.Size(250,80);
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.ForeColor = Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.Location = new System.Drawing.Point(383, 258);
            //this.guna2Button1.Location = new System.Drawing.Point(guna2Button1.Location.X, guna2Button1.Location.Y);

            this.guna2Button1.Size = new System.Drawing.Size(210, 57);
        }

        private void guna2Button2_Challange_MouseEnter(object sender, EventArgs e)
        {
            guna2Button2_Challange.ForeColor = Color.Black;
            this.guna2Button2_Challange.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.guna2Button2_Challange.Location = new System.Drawing.Point(340, 90);
            this.guna2Button2_Challange.Location = new System.Drawing.Point(guna2Button2_Challange.Location.X-10, guna2Button2_Challange.Location.Y-10);

            this.guna2Button2_Challange.Size = new System.Drawing.Size(200, 90);
            guna2panel2_challenge.Visible = true;
            this.label_challenge_intro.Margin = new System.Windows.Forms.Padding(20, 100, 10, 10);
            label_challenge_intro.Text = "Challenge yourself with over 100.000 different questions. ";
            label_challenge_intro.Visible = true;
           // guna2panel2_challenge_effect.Visible = false;
        }

        private void guna2Button2_Challange_MouseLeave(object sender, EventArgs e)
        {
            guna2Button2_Challange.ForeColor = Color.White;
            this.guna2Button2_Challange.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2_Challange.Location = new System.Drawing.Point(400, 200);
            this.guna2Button2_Challange.Size = new System.Drawing.Size(180, 70);
            guna2panel2_challenge.Visible = false;
            label_challenge_intro.Text = " Challenge yourself with over 100.000 different questions. ";
            this.label_challenge_intro.Margin = new System.Windows.Forms.Padding(20, 100, 10, 10);
            label_challenge_intro.Visible = false;
            //guna2panel2_challenge_effect.Visible = false;

        }

        private void guna2Button2_Practise_MouseEnter(object sender, EventArgs e)
        {
            guna2Button2_Practise.ForeColor = Color.Black;
            this.guna2Button2_Practise.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2_Practise.Location = new System.Drawing.Point(guna2Button2_Practise.Location.X-10, guna2Button2_Practise.Location.Y-10);

            // this.guna2Button2_Practise.Location = new System.Drawing.Point(340, 200);
            this.guna2Button2_Practise.Size = new System.Drawing.Size(200, 90);
            guna2panel2_practise.Visible = true;
            label_practise_intro.Text = " Challenge yourself with your look-up words. ( Your look-up words (in E-V) must comprise more than 100 ) ";
            this.label_practise_intro.Margin = new System.Windows.Forms.Padding(15, 20, 10, 10);
            label_practise_intro.Visible = true;
           // guna2panel2_practise_effect.Visible = false;

        }

        private void guna2Button2_Practise_MouseLeave(object sender, EventArgs e)
        {
            guna2Button2_Practise.ForeColor = Color.White;
            this.guna2Button2_Practise.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.guna2Button2_Practise.Location = new System.Drawing.Point(400, 300);
            //this.guna2Button2_Practise.Location = new System.Drawing.Point(guna2Button2_Practise.Location.X, guna2Button2_Practise.Location.Y);

            this.guna2Button2_Practise.Size = new System.Drawing.Size(180, 70);
            guna2panel2_practise.Visible = false;
            label_practise_intro.Text = " Challenge yourself with your look-up words. ( Your look-up words (in E-V) must comprise more than 100 ) ";
            this.label_practise_intro.Margin = new System.Windows.Forms.Padding(15, 20, 10, 10);
            label_practise_intro.Visible = false;
          //  guna2panel2_practise_effect.Visible = false;

        }

        private void ControlBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            music.controls.stop();
            if ( this.parent!= null) this.parent.Close();
            mainForm newmainform = new mainForm();
            newmainform.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void guna2Circle_music_Click(object sender, EventArgs e)
        {
            if (ismusicon == 1)
            {
                music.controls.stop();
                ismusicon--;
            }
            else
            {
                music.controls.play();
                ismusicon++;
            }
            
        }
    }
}
