using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Room
    {
        public string RoomID;
        public string HostID;
        public string GuestID;
        public int IsClosed;
        public int IsReady;
        public Room(string RoomID,string HostID, string GuestID, int IsClosed, int IsReady)
        {
            this.RoomID = RoomID;
            this.HostID = HostID;
            this.GuestID = GuestID;
            this.IsClosed = IsClosed;
            this.IsReady = IsReady;
        }
    }
    
}
