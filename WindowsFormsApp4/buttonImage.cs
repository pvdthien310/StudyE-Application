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
using System.IO;

namespace WindowsFormsApp4
{
    public class buttonImage
    {
        public Guna.UI2.WinForms.Guna2Button createButton(string name, Bitmap b)
        {
           
            Guna.UI2.WinForms.Guna2Button temp = new Guna.UI2.WinForms.Guna2Button();
            temp.BackColor = Color.Transparent;
            temp.BackgroundImage = b;
            temp.BackgroundImageLayout = ImageLayout.Stretch;
            temp.BorderRadius = 7;
            temp.CheckedState.Parent = temp;
            temp.CustomImages.Parent = temp;
            temp.FillColor = Color.Transparent;
            //temp.Font = new Font("Segoe UI", 9F);
            //temp.ForeColor = Color.White;
            temp.HoverState.Parent = temp;
            //temp.Location = new Point(224, 505);
            temp.Name = name;
            temp.ShadowDecoration.Parent = temp;
            temp.Size = new Size(60,60);
            temp.TabIndex = 0;
            
            return temp;
        }
    }
}
