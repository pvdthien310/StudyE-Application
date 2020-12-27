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
    public partial class RoomForm : Form
    {
        public RoomChose parent;
        public Room room_info;
        public string Playername;
        public GameManager_2 game_host;
        public int ishost;
        
        //public static SqlConnection Mycnt = new SqlConnection(@"Server=tcp:study-e.database.windows.net,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=study-e;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public static SqlConnection Mycnt = new SqlConnection(@"Server=tcp:40.83.97.14,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=sa;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
        //
        Timer check_timer;
        public RoomForm()
        {
            InitializeComponent();
        }
        public RoomForm(RoomChose parent, Room room, string Playername, GameManager_2 game_host, int ishost) // bien ishost xac dinh la day được gọi từ vào phòng hay tạo phòng 
        {

            this.parent = parent;
            this.room_info = room;
            this.Playername = Playername;
            this.game_host = game_host;
            this.ishost = ishost;
            InitializeComponent();
         //   Label_RoomID.Text = room_info.RoomID.ToString();
            check_timer = new Timer();
            check_timer.Tick += new EventHandler(timer_tick);
            check_timer.Interval = 300;
            check_timer.Enabled = true;
            if (ishost == 1)
            {
                guna2Button_Ready.Enabled = false;
                guna2Button_Start.Enabled = true;


            }
            else
            {
                guna2Button_Ready.Enabled = true;
                guna2Button_Start.Enabled = false;
            }
            guna2Button_Sophong.Text = "Phòng " + room_info.RoomID.ToString();

        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (check_timer.Enabled == false) return;
            string query, result;
            SqlCommand com;
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }
            query = string.Format("Select * from Roomlist Where RoomID = '{0}' ", room_info.RoomID);
            com = new SqlCommand(query, Mycnt);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            Mycnt.Close();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                room_info.RoomID = dt.Rows[0]["RoomID"].ToString();
                room_info.HostID = dt.Rows[0]["HostID"].ToString();
                room_info.GuestID = dt.Rows[0]["GuestID"].ToString();
                room_info.IsClosed = Convert.ToInt32(dt.Rows[0]["IsClosed"]);
                room_info.IsReady = Convert.ToInt32(dt.Rows[0]["IsReady"]);
                room_info.IsStart = Convert.ToInt32(dt.Rows[0]["IsStart"]);
            }


            if ( ishost == 1)
            {
                if (room_info.IsReady == 1 && room_info.IsStart == 0)
                {
                    guna2HtmlLabel1.Text = "Let's Start !!";
                    guna2HtmlLabel1.Visible = true;

                }
                else guna2HtmlLabel1.Text = "Your competitor is not ready !!";
            }

            else if (ishost == 0)
            {
                if (room_info.IsReady == 1 && room_info.IsStart == 1)
                {
                    
                    check_timer.Enabled = false;
                    Start game = new Start(this, game_host);
                    this.Hide();
                    game.Show();
                }
            }

            if (room_info.HostID == Playername && room_info.GuestID == "")
            {
                if (ishost == 0)
                {
                    ishost = 1;
                    guna2Button_Ready.Enabled = false;
                    guna2Button_Start.Enabled = true;
                    room_info.GuestID = "";
                    room_info.HostID = Playername;
                    room_info.IsClosed = room_info.IsReady = room_info.IsStart = 0;
                }
            }
            guna2HtmlLabel_name1.Text = room_info.HostID;
            guna2HtmlLabel_status1.Text = "Host";
           if (room_info.GuestID != "0")
            {
                pictureBox2.Visible = true;
                guna2HtmlLabel_name2.Text = room_info.GuestID;
                guna2HtmlLabel_name2.Visible = true;
                if (room_info.IsReady == 1)
                    guna2HtmlLabel_status2.Text = "Ready";
                else
                    guna2HtmlLabel_status2.Text = "Not Ready";
                guna2HtmlLabel_status2.Visible = true;
                guna2HtmlLabel1.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
                guna2HtmlLabel_name2.Visible = false;      
                guna2HtmlLabel_status2.Visible = false;
                guna2HtmlLabel1.Visible = false;
            }



            //if (ishost == 1)
            //{
            //     query = string.Format("Select Count(*) from RoomList Where RoomID ='{0}' and IsReady ='1' and IsStart = '0'", room_info.RoomID);
            //    if (Mycnt.State != ConnectionState.Open)
            //    {
            //        Mycnt.Open();
            //    }
            //    com = new SqlCommand(query, Mycnt);
            //     result = com.ExecuteScalar().ToString();
            //    if ( result == "1")
            //    label_readycheck.Text = "Vao thoi con di lon";
            //    else label_readycheck.Text = "Doi thu chua san sang ong noi oi ";
            //    Mycnt.Close();

            //}
            //else if (ishost == 0)
            //{
            //     query = string.Format("Select Count(*) from RoomList Where RoomID ='{0}' and IsReady ='1' and IsStart = '1'", room_info.RoomID);
            //    if (Mycnt.State != ConnectionState.Open)
            //    {
            //        Mycnt.Open();
            //    }
            //    com = new SqlCommand(query, Mycnt);
            //     result = com.ExecuteScalar().ToString();
            //    Mycnt.Close();
            //    if (result =="1")
            //    {
            //        MessageBox.Show("Tro choi bat dau");
            //    }


            //}

            //query = string.Format("Select Count(*) from RoomList Where RoomID ='{0}' and HostID = '{1}' and GuestID =''",room_info.RoomID,Playername);
            //if (Mycnt.State != ConnectionState.Open)
            //{
            //    Mycnt.Open();
            //}
            //com = new SqlCommand(query, Mycnt);
            // result = com.ExecuteScalar().ToString();
            //Mycnt.Close();
            //if (result == "1" && ishost == 0)
            //{
            //    ishost = 1;
            //    guna2Button_Ready.Enabled = false;
            //    guna2Button_Start.Enabled = true;
            //    room_info.GuestID = "";
            //    room_info.HostID = Playername;
            //    room_info.IsClosed = room_info.IsReady = room_info.IsStart = 0;
            //}



        }
    
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }
           
            SqlCommand com;
            string query;
            if (ishost == 1)
            {
                room_info.HostID = "";
                query = string.Format("Update Roomlist set HostID ='',IsClosed ='0',IsReady ='0',IsStart ='0' where RoomID ='{0}'", room_info.RoomID);
                com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();

            }
            else
            {
                room_info.GuestID = "";
                query = string.Format("Update Roomlist set GuestID ='',IsClosed ='0',IsReady ='0',IsStart ='0' where RoomID ='{0}'", room_info.RoomID);
                com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
            }

            query = string.Format( "update RoomList set HostID = GuestID, GuestID = ''where HostID = '' and GuestID != ''" +
                "  delete from RoomQuestions Where RoomID in (select RoomID from RoomList Where HostId = '' and guestID = '')" 
                + "delete from Roomlist where HostID = '' and GuestID = ''" );
            com = new SqlCommand(query, Mycnt);
            com.ExecuteNonQuery();
            Mycnt.Close();
            this.Close();
            this.parent.Close();
            RoomChose newroomchose = new RoomChose(Playername);
            newroomchose.Show();
            

        }

        private void guna2Button_Ready_Click(object sender, EventArgs e)
        {
           
            if (guna2Button_Ready.FillColor == Color.Red)
            {
               string query = string.Format("update RoomList set IsReady ='0' Where RoomID = '{0}'", room_info.RoomID);
                if (Mycnt.State != ConnectionState.Open)
                {
                    Mycnt.Open();
                }
                SqlCommand com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
                Mycnt.Close();
                this.guna2Button_Ready.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
              //  label_readycheck.Text = "Chua san sang";
            
            }
            else
            {
                string query = string.Format("update RoomList set IsReady ='1' Where RoomID = '{0}'", room_info.RoomID);
                if (Mycnt.State != ConnectionState.Open)
                {
                    Mycnt.Open();
                }
                SqlCommand com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
                Mycnt.Close();
                guna2Button_Ready.FillColor = Color.Red;
            //    label_readycheck.Text = "Da san sang";
            }

        }

        private void guna2Button_Start_Click(object sender, EventArgs e)
        {        
            string query = string.Format("Select Count(*) from RoomList Where RoomID ='{0}' and  IsClosed ='1' and IsReady ='1' and IsStart = '0'", room_info.RoomID);
            if (Mycnt.State != ConnectionState.Open)
            {
                Mycnt.Open();
            }
            
            SqlCommand com = new SqlCommand(query, Mycnt);
            string result = com.ExecuteScalar().ToString();
            if (result == "1")
            {
                query = string.Format("update RoomList set isStart ='1' Where RoomID = '{0}'", room_info.RoomID);
                 com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
                
                check_timer.Enabled = true;
                Start game = new Start(this, game_host);
                this.Hide();
                game.Show();
            }
            else if(result == "0")
            {
                MessageBox.Show("Đối Thủ Chưa Sẵn Sàng !! ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Mycnt.Close();

        }
    }
}
