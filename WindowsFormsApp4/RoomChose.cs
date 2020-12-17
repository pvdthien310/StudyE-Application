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

namespace WindowsFormsApp4
{
    public partial class RoomChose : Form
    {
        //property
        public static SqlConnection Mycnt = new SqlConnection(@"Server=tcp:study-e.database.windows.net,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=study-e;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"); 
        public string PlayerName ="97";
        public List<Room> roomList; // danh sach phong hien co
        private Guna.UI2.WinForms.Guna2Button[] listbtn;
        private FlowLayoutPanel[] listpnl;
        private int number_pnl = 0;
        public RoomChose()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
        public RoomChose(string playerName)
        {
            InitializeComponent();
          // this.PlayerName = playerName;
            this.PlayerName = "99";
            DoubleBuffered = true;
        }

        public void RoomChose_Load(object sender, EventArgs e)
        {
            Mycnt.Open();
            // lay het du lieu trong bang DTBQT
            string sql = "SELECT * FROM ROOMLIST";
            SqlCommand com = new SqlCommand(sql, Mycnt); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            Mycnt.Close();  // đóng kết nối
            if (dt.Rows.Count < 1) return;
            else
            {
                if (dt.Rows.Count % 16 == 0)
                {
                    listpnl = new FlowLayoutPanel[dt.Rows.Count / 16];
                }
                else
                {
                    listpnl = new FlowLayoutPanel[dt.Rows.Count / 16 + 1];
                }
                roomList = new List<Room>();

                for ( int i = 0; i < dt.Rows.Count; i++)
                {
                    roomList.Add(new Room(dt.Rows[i]["RoomID"].ToString().Trim(), dt.Rows[i]["HostID"].ToString().Trim(), dt.Rows[i]["GuestID"].ToString().Trim(), Convert.ToInt32(dt.Rows[i]["IsClosed"].ToString().Trim()), Convert.ToInt32(dt.Rows[i]["IsReady"].ToString().Trim())));
                }
            }
            listbtn = new Guna.UI2.WinForms.Guna2Button[roomList.Count];

            for (int j = 0; j < listpnl.Length; j++)
            {
                listpnl[j] = new FlowLayoutPanel() { Location = new System.Drawing.Point(101, 167), Size = new System.Drawing.Size(785, 324) };
                // this.listpnl[j].BackColor = System.Drawing.Color.Transparent;
              this.listpnl[j].BackColor = System.Drawing.Color.Orchid;
                this.Controls.Add(listpnl[j]);
            }
            int number_room_inpanel = 0;
            int number_pnl = 0;
            for ( int i = 0;i< roomList.Count;i++)
            {
                string a = "Phòng ";

                a += roomList[i].RoomID;
                listbtn[i] = new Guna.UI2.WinForms.Guna2Button() { Text = a, Size = new System.Drawing.Size(150, 100) };
                listbtn[i].BorderRadius = 15;
                listbtn[i].Name = "Room" + i.ToString(); 
                listbtn[i].Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                listbtn[i].FillColor = System.Drawing.Color.MediumOrchid;
                if (number_room_inpanel == 16)
                {
                    number_room_inpanel = 0;
                    number_pnl++;
                }
                else
                {
                    number_room_inpanel++;
                }
                listpnl[number_pnl].Controls.Add(listbtn[i]);

                //////////// su kien click
                listbtn[i].Click += (s, k) =>
                {
                    Guna.UI2.WinForms.Guna2Button raised_controls = s as Guna.UI2.WinForms.Guna2Button;
                    int count = -1;
                    foreach (Guna.UI2.WinForms.Guna2Button x in listbtn)
                    {
                        count++;
                        string temp = x.Text.Substring(6);

                        if (raised_controls.Text == x.Text)
                        {
                            if (roomList[count].IsClosed == 1)
                            {
                                MessageBox.Show("Phòng đầy !","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                           else
                            {
                                roomList[count].GuestID = PlayerName;
                                roomList[count].IsClosed = 1;
                                roomList[count].IsReady = 0;
                                Mycnt.Open();
                                sql = String.Format("UPDATE ROOMLIST SET ISCLOSED = '0',IsReady = '0',GuestID = '' WHERE GuestID = '{0}'"+
                                    "UPDATE ROOMLIST SET ISCLOSED = '1',IsReady = '0',GuestID = '{0}' WHERE ROOMID = '{1}'",PlayerName,temp);                           
                                com = new SqlCommand(sql, Mycnt); //bat dau truy van
                                com.ExecuteNonQuery();
                                Mycnt.Close();
                                MessageBox.Show("Vào Phòng Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GameManager_2 game_host = new GameManager_2(null,this,GetQuestionFromRoom(temp));
                                RoomForm room = new RoomForm(this, roomList[count + 1], PlayerName, game_host, 0);
                                room.Show();
                                this.Hide();
                                int concat = 10;

                            }

                        }
                    }

                };
                
            }

        }
        private List<QuestionGame2> GetQuestionFromRoom( string RoomID)         ////////// lấy bộ câu hỏi của phòng đó ra bên ngoài 
        {
            List<QuestionGame2> temp = new List<QuestionGame2>();
            Mycnt.Open();
            string query = string.Format("Select * from RoomQuestions Where RoomID ='{0}'", RoomID);
            SqlCommand com = new SqlCommand(query, Mycnt);
            SqlDataAdapter da = new SqlDataAdapter(com);
            Mycnt.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow a in dt.Rows)
            {
                if (a["TypeQues"].ToString() == "1")
                {
                    temp.Add(new QuestionType1(a["Question"].ToString(), a["AnswerA"].ToString(), a["AnswerB"].ToString(), a["AnswerC"].ToString(), a["AnswerD"].ToString(), Convert.ToInt32(a["Correctindex"].ToString())));
                }
                else if (a["TypeQues"].ToString() == "2")
                {
                    temp.Add(new QuestionType2(a["Question"].ToString(), a["Correctindex"].ToString()));
                }
            }
            return temp;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //// Tao phong
            Mycnt.Open();

            
            string query = string.Format("update roomlist set HostID = '', Isclosed = '0', IsReady = '0' where hostid = '{0}'"
                + " update roomlist set GuestID = '', Isclosed = '0', IsReady = '0' where GuestID = '{0}'" +
                "delete from Roomlist where HostID = '' and GuestID = ''" 
               + "update RoomList set HostID = GuestID, GuestID = '', Isclosed = '0', IsReady = '0' where HostID = '' and GuestID != ''", PlayerName);
            SqlCommand cmd = new SqlCommand(query, Mycnt);
            cmd.ExecuteNonQuery();
            
            Random rd = new Random();
            int roomid = rd.Next(999);
            query = String.Format("INSERT INTO RoomList VALUES ('{0}','{1}','', '0','0')    ",roomid.ToString(),PlayerName);
          


            //// Tao bo cau hoi
            
            string s; // string tạm
            string[] temp;
            

            GameManager_2 game_host = new GameManager_2();
            int type = 1;
            for (int i = 0; i < 10; i++)
            {
                temp = game_host.list[i].GetQuestion(); // lay bo cau hoi ra
                for ( int j = 0;j < temp.Length;j ++)
                {
                    temp[j] = temp[j].Replace("'", "`");
                }
                if (i < game_host.n)  // Xu ly cau hoi loai 1
                {                   
                    s = String.Format("INSERT INTO RoomQuestions VALUES ('{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", roomid, type, temp[0],temp[1],temp[2],temp[3],temp[4],temp[5]);

                }
                else
                {
                    type = 2;
                    s = String.Format("INSERT INTO RoomQuestions VALUES ('{0}','{1}',N'{2}','{3}','{4}','{5}','{6}',N'{7}')", roomid, type, temp[0], "", "", "", "", temp[1].Trim());

                }
                query += s + "    ";
            }
            
            SqlCommand com = new SqlCommand(query, Mycnt); //bat dau truy van
            com.ExecuteNonQuery();
            Mycnt.Close();

            roomList.Add(new Room(roomid.ToString(), PlayerName, "", 0, 0));
            RoomForm roomform = new RoomForm(this,roomList[roomList.Count - 1], PlayerName, game_host, 1);
            roomform.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            foreach (var a in listbtn)
            {
                a.Dispose();
            }
            foreach (var a in listpnl)
            {
                a.Dispose();
            }
            this.RoomChose_Load(sender, e);
            MessageBox.Show("Reset roi ba oi !!");

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            number_pnl++;
            if (number_pnl == listpnl.Length) number_pnl = 0;
            listpnl[number_pnl].BringToFront();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            number_pnl--;
            if (number_pnl == -1) number_pnl = listpnl.Length-1;
            listpnl[number_pnl].BringToFront();
        }

        private void RoomChose_Activated(object sender, EventArgs e)
        {
            this.RoomChose_Load(sender, e);
        }

        private void RoomChose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mycnt.Open();
            string query = string.Format("update roomlist set HostID = '', Isclosed = '0', IsReady = '0' where hostid = '{0}'" 
                +" update roomlist set GuestID = '', Isclosed = '0', IsReady = '0' where GuestID = '{0}'" +
                "delete from Roomlist where HostID = '' and GuestID = ''" +
                "update RoomList set HostID = GuestID, GuestID = '', Isclosed = '0', IsReady = '0' where HostID = '' and GuestID != ''", PlayerName);
            SqlCommand cmd = new SqlCommand(query, Mycnt);
            cmd.ExecuteNonQuery();
            Mycnt.Close();
        }
    }
}
