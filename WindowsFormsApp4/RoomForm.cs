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
        public static SqlConnection Mycnt = new SqlConnection(@"Server=tcp:study-e.database.windows.net,1433;Initial Catalog=StudyE;Persist Security Info=False;User ID=study-e;Password=ThangThienThuc123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public RoomForm()
        {
            InitializeComponent();
        }
        public RoomForm(RoomChose parent,Room room, string Playername,GameManager_2 game_host,int ishost) // bien ishost xac dinh la day được gọi từ vào phòng hay tạo phòng 
        {
            this.parent = parent;
            this.room_info = room;
            this.Playername = Playername;
            this.game_host = game_host;
            this.ishost = ishost;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Mycnt.Open();
            SqlCommand com;
            string query;
            if (ishost == 1)
            {
                room_info.HostID = "";
                query = string.Format("Update Roomlist set HostID ='',IsClosed ='0',IsReady ='0' where RoomID ='{0}'", room_info.RoomID);
                com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();

            }
            else
            {
                room_info.GuestID = "";
                query = string.Format("Update Roomlist set GuestID ='',IsClosed ='0',IsReady ='0' where RoomID ='{0}'", room_info.RoomID);
                com = new SqlCommand(query, Mycnt);
                com.ExecuteNonQuery();
            }
          
            query = string.Format("delete from Roomlist where HostID = '' and GuestID = ''" +
                " update RoomList set HostID = GuestID, GuestID = ''where HostID = '' and GuestID != ''" +
                " delete from RoomQuestions where RoomID ='{0}'",room_info.RoomID);
            com = new SqlCommand(query, Mycnt);
            com.ExecuteNonQuery();         
            Mycnt.Close();
            this.Close();
            this.parent.Show();

        }
    }
}
