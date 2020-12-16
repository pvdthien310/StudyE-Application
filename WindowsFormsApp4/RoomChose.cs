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
        public string PlayerName;
        public List<Room> roomList; // danh sach phong hien co
        private Guna.UI2.WinForms.Guna2Button[] listbtn;
        private FlowLayoutPanel[] listpnl;
        private int number_pnl = 0;
        public RoomChose()
        {
            InitializeComponent();
        }
        public RoomChose(string playerName)
        {
            InitializeComponent();
            this.PlayerName = playerName;
            DoubleBuffered = true;
        }

        private void RoomChose_Load(object sender, EventArgs e)
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
                listbtn[i].Click += (s, k) =>
                {
                    int count = -1;
                    foreach (Guna.UI2.WinForms.Guna2Button x in listbtn)
                    {
                        count++;
                        string temp = x.Text.Substring(6);

                        if (s == x)
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
                                sql = String.Format("UPDATE ROOMLIST SET ISCLOSED = '1' WHERE ROOMID = '{0}'",temp);                           ;
                                com = new SqlCommand(sql, Mycnt); //bat dau truy van
                                com.ExecuteNonQuery();
                                Mycnt.Close();
                                MessageBox.Show("Vào Phòng Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                    }

                };
                
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

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
    }
}
