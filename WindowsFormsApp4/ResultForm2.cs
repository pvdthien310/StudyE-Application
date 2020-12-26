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
    public partial class ResultForm2 : Form
    {
        public RoomChose parent;
        public List<string> result;
        public ResultForm2()
        {
            InitializeComponent();
        }
        public ResultForm2(RoomChose parent,List<string> result)
        {
            InitializeComponent();
            this.parent = parent;
            this.result = result;
            var listViewItem = new ListViewItem(result.ToArray());
            listView1.Items.Add(listViewItem);
        }
    }
}
