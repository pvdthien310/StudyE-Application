using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public Timer timer3;  // dem thoi gian tranh truong hop nguoi choi treo may
        public int isdraw;
        public double time;
        //
        public List<string> result;
        public int isupdate = 1;
        public GameManager_2 game_host;
        public List<Question_Creep> game_creep;
        public static SqlConnection Mycnt = new SqlConnection(@"Server=tcp:40.83.97.14,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=sa;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
        //public Start()
        //{
        //    InitializeComponent();
        //    this.IsMdiContainer = true;
        //    yasuo_sprite = new Bitmap("yasuosprite.png");
        //    background = new Bitmap("background_1.jpg");
        //    creep = new Bitmap("creep.png");
        //    X_yasuo = Y_yasuo = 20;
        //    whatframes = direction = 0; // 0 phai 1 trai 2 tren 3 duoi 4 dung yen 
        //    DoubleBuffered = true;
        //    isdraw = 1;




        //}
        public Start(RoomForm roomform, GameManager_2 game_host)
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
            this.game_host = game_host;
            result = new List<string>();
            this.roomform = roomform;
            

            timer = new Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = 100;
            timer.Enabled = true;
            time = 0;

            timer3 = new Timer();
            timer3.Tick += new EventHandler(timer3_tick);
            timer3.Interval = 100;
            timer3.Enabled = true;
            




        }
        private void timer3_tick(object sender, EventArgs e)
        {
            time += 0.1;
            if (time > 200)
            {
                push_result_to_data();
                gameForm.Invalidate();
                isdraw = 0;
            }
        }
            private void push_room_data()
        {
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }
            string query = string.Format("Insert into RoomResult values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",roomform.room_info.RoomID, roomform.room_info.HostID, roomform.room_info.GuestID,0,0,0,0,0,0);
            SqlCommand com = new SqlCommand(query, Mycnt);
            com.ExecuteNonQuery();
            Mycnt.Close();

        }
        private void timer_tick(object sender, EventArgs e)
        {
            

            //gameForm.time_label.Text = time.ToString();
            //gameForm.Invalidate();
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }
            string query = string.Format("SELECT * FROM ROOMRESULT WHERE ROOMID = '{0}'",roomform.room_info.RoomID);
            SqlCommand com = new SqlCommand(query, Mycnt);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count < 1) return;
            else
            {
                result.Clear();
                for (int i = 0;i < 9;i++)
                result.Add(dt.Rows[0][i].ToString());
            }
            Mycnt.Close();
        
        }
        private int check_result()
        {
           
                if (Convert.ToInt32(result[3]) > Convert.ToInt32(result[4]))
                {
                     if (roomform.ishost == 1)  return 1;
                      else return 0;
                }
                else if (Convert.ToInt32(result[3]) == Convert.ToInt32(result[4]))
                 {
                if (Convert.ToInt32(result[5]) > Convert.ToInt32(result[6]))
                {
                    if (roomform.ishost == 1) return 1;
                    else return 0;
                }
                else if (Convert.ToInt32(result[5]) < Convert.ToInt32(result[6]))
                {
                    if (roomform.ishost == 1) return 0;
                    else return 1;
                }
                else if (Convert.ToInt32(result[5]) == Convert.ToInt32(result[6])) return 2;
                 }
                else if (Convert.ToInt32(result[3]) < Convert.ToInt32(result[4]))
            {
                if (roomform.ishost == 1) return 0;
                else return 1;
            }

                ////
            return 0;
           
        }
        private void check()
        {
            int s = 0; // dem xem 2 nguoi choi d a choi xong chua 
            if(result.Count > 0)
             if (result[1] !="" && result[2] != "" && result[7] !="0" && result[8]!= "0")
            {
                s = 8;
            }
            // foreach( string a in result)
            //{
            //    if (a != "0") s++;
            //}
                
            if (s >= 8)
                {
                push_result_to_data();
                timer.Enabled = false;
                ResultForm2 resultform = new ResultForm2(roomform.parent, result);
                switch (check_result())
                {
                    case 1:
                        {
                            if (roomform.ishost == 1)
                            resultform.guna2HtmlLabel1.Text = roomform.room_info.HostID;
                            else resultform.guna2HtmlLabel1.Text = roomform.room_info.GuestID;
                            resultform.guna2HtmlLabel2.Text = "VICTORY";                           
                            resultform.guna2HtmlLabel2.ForeColor = System.Drawing.Color.ForestGreen;                               
                            break;
                        }
                    case 2:
                        {
                            if (roomform.ishost == 1)
                                resultform.guna2HtmlLabel1.Text = roomform.room_info.HostID;
                            else resultform.guna2HtmlLabel1.Text = roomform.room_info.GuestID;
                            resultform.guna2HtmlLabel2.Text = "DRAW";
                            resultform.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkOrange;
                            
                            break;
                        }
                    case 0:
                        {
                            if (roomform.ishost == 1)
                                resultform.guna2HtmlLabel1.Text = roomform.room_info.HostID;
                            else resultform.guna2HtmlLabel1.Text = roomform.room_info.GuestID;
                            resultform.guna2HtmlLabel2.Text = "DEFEAT";
                            resultform.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkOliveGreen;
                           
                            break;
                        }
                }
                if (roomform.ishost == 1)
                resultform.guna2HtmlLabel_Score.Text = result[3];
                else resultform.guna2HtmlLabel_Score.Text = result[4];
                this.Close();
                resultform.Show();
                timer2.Enabled = false;
            }         
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
                                questionForm.guna2TextBox_answer2.Focus();
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

        //public void questionForm_paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.DrawString(time.ToString(), new Font("Serif", 24, FontStyle.Bold),Brushes.Black,new Point(10,590));
        //}
        static int count = 0; // dem so cau dung
        static int count_question = 0;  // dem so cau da tra loi
        public void gameForm_paint(object sender, PaintEventArgs e)
        {
            count_question = 0;
            check();
            if (whatframes == 3) whatframes = 0;
            else whatframes++;
            if (isupdate == 0)
            {
                e.Graphics.DrawString("Xin vui long cho ket qua", new Font("Serif", 60f, FontStyle.Bold), Brushes.Black, new Point(300, 300));
            }
            e.Graphics.DrawImage(background, new Rectangle(0, 0, 1000, 590), new Rectangle(0, 0, 500, 400), GraphicsUnit.Pixel);
            e.Graphics.DrawImage(yasuo_sprite, new Rectangle(X_yasuo,Y_yasuo,60,80), new Rectangle(whatframes * 95, direction * 120, 95, 110), GraphicsUnit.Pixel);
         
            for ( int i = 0; i< 10;i++)
            {
                if (game_creep[i].isCorrect == 2)
                    e.Graphics.DrawImage(creep, new Rectangle(game_creep[i].X_creep, game_creep[i].Y_creep, 60, 45), new Rectangle(0, 0, 90, 70), GraphicsUnit.Pixel);
                else
                {                    
                    count_question++;
                }
               
                if (count_question == 10)
                {
                   

                    push_result_to_data();

                    //DialogResult dialogResult = MessageBox.Show("Hay qua dkmm !! {0}", (count - 10).ToString(),MessageBoxButtons.OK);
                    //if (dialogResult == DialogResult.OK)
                    //{
                       
                    //}
                }
               
            }
            //if (time > 100)
            //{
            //    push_result_to_data();
            //}
        }
        Timer timer2;
         
        public void push_result_to_data()
        {
            string query =  "";
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }

            for (int j = 0; j < 10; j++)
            {
                if (game_creep[j].isCorrect == 1) count++;
            }
            if (roomform.ishost == 1 && isupdate != 0)
            {
                query = string.Format("UPDATE ROOMRESULT" +
                    " SET Host_Ques = '{0}', HostGoal = '{1}', HostTime = '{2}' WHERE ROOMID ='{3}'",count_question,count*30,Convert.ToInt32(time),result[0]);
                SqlCommand com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
                Mycnt.Close();
            }
            else if (roomform.ishost == 0 && isupdate != 0)
            {
                query = string.Format("UPDATE ROOMRESULT" +
                   " SET GUEST_Ques = '{0}', GUESTGoal = '{1}', GUESTTime = '{2}' WHERE ROOMID ='{3}'", count_question, count*30, Convert.ToInt32(time), result[0]);
                SqlCommand com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
                Mycnt.Close();
            }
            isupdate = 0;
          
            timer.Enabled = false;
            timer3.Enabled = false;
            // mo form result
            timer2 = new Timer();
            timer2.Interval = 100;
            timer2.Tick += new EventHandler(timer2_tick);
            timer2.Enabled = true;
        }
        private void timer2_tick(object sender, EventArgs e)
        {
            isdraw = 0;
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }
            string query = string.Format("SELECT * FROM ROOMRESULT WHERE ROOMID = '{0}'", roomform.room_info.RoomID);
            SqlCommand com = new SqlCommand(query, Mycnt);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count < 1) return;
            else
            {
                result.Clear();
                for (int i = 0; i < 9; i++)
                    result.Add(dt.Rows[0][i].ToString());
            }
            Mycnt.Close();
            gameForm.Invalidate();
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
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
            //questionForm.Paint += questionForm_paint;
            questionForm.Show();

            //
            if (roomform.ishost == 1)
                push_room_data();   
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
