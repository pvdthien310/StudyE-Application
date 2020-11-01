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
    public partial class supportForm : Form
    {
        mainForm parent;
        public supportForm()
        {
            InitializeComponent();
        }
        public supportForm(mainForm parent, string word)
        {
            InitializeComponent();
            textBox_support1.Text = word;
            this.parent = parent;
            DataManager.Instance.ConnectDatabseEV(word,ref textBox_support);
            
        }
    }
}
