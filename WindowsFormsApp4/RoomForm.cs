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
            Label_RoomID.Text = room_info.RoomID.ToString();
            testData();
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

        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (ishost == 1)
            {
                string query = string.Format("Select Count(*) from RoomList Where RoomID ='{0}' and IsReady ='1' and IsStart = '0'", room_info.RoomID);
                Mycnt.Open();
                SqlCommand com = new SqlCommand(query, Mycnt);
                string result = com.ExecuteScalar().ToString();
                if ( result == "1")
                label_readycheck.Text = "Vao thoi con di lon";
                else label_readycheck.Text = "Doi thu chua san sang ong noi oi ";
                Mycnt.Close();

            }
            else if (ishost == 0)
            {
                string query = string.Format("Select Count(*) from RoomList Where RoomID ='{0}' and IsReady ='1' and IsStart = '1'", room_info.RoomID);
                Mycnt.Open();
                SqlCommand com = new SqlCommand(query, Mycnt);
                string result = com.ExecuteScalar().ToString();
                Mycnt.Close();
                if (result =="1")
                {
                    MessageBox.Show("Tro choi bat dau");
                }
              
                
            }
            
            

        }
        private void testData()
        {
            foreach (QuestionGame2 a in game_host.list)
            {
                string[] line = a.GetQuestion();
                //if (line.Length > 2)
                dataGridView_test.Rows.Add(line);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Mycnt.Open();
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
                Mycnt.Open();
                SqlCommand com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
                Mycnt.Close();
                this.guna2Button_Ready.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            }
            else
            {
                string query = string.Format("update RoomList set IsReady ='1' Where RoomID = '{0}'", room_info.RoomID);
                Mycnt.Open();
                SqlCommand com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
                Mycnt.Close();
                guna2Button_Ready.FillColor = Color.Red;
            }

        }

        private void guna2Button_Start_Click(object sender, EventArgs e)
        {
            string query = string.Format("Select Count(*) from RoomList Where RoomID ='{0}' and  IsClosed ='1' and IsReady ='1' and IsStart = '0'", room_info.RoomID);
            Mycnt.Open();
            SqlCommand com = new SqlCommand(query, Mycnt);
            string result = com.ExecuteScalar().ToString();
            if (result == "1")
            {
                query = string.Format("update RoomList set isStart ='1' Where RoomID = '{0}'", room_info.RoomID);
                com.ExecuteNonQuery();
                MessageBox.Show("Tro choi bat dau");
            }
            else if(result == "0")
            {
                MessageBox.Show("Đối Thủ Chưa Sẵn Sàng !! ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Mycnt.Close();

        }
    }
}
