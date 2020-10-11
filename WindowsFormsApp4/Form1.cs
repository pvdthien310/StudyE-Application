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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }
        private void startButton_Click_1(object sender, EventArgs e)
        {
            mainForm temp = new mainForm(this);
            this.Hide();
            temp.Show();
        }
    }
}
