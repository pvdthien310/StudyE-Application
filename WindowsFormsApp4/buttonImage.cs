﻿using System;
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
        public Guna.UI2.WinForms.Guna2Button createButton()
        {
            Guna.UI2.WinForms.Guna2Button temp = new Guna.UI2.WinForms.Guna2Button();
            temp.BackColor = Color.Red;
            //temp.BackgroundImage = ;
            temp.BackgroundImageLayout = ImageLayout.Stretch;
            temp.BorderRadius = 7;
            temp.CheckedState.Parent = temp;
            temp.CustomImages.Parent = temp;
            temp.FillColor = Color.Red;
            temp.Font = new Font("Segoe UI", 9F);
            temp.ForeColor = Color.White;
            temp.HoverState.Parent = temp;
            temp.Location = new Point(224, 505);
            temp.Name = "temp";
            temp.ShadowDecoration.Parent = temp;
            temp.Size = new Size(100, 100);
            temp.TabIndex = 0;
            //temp.Click += new EventHandler(TabChose_Click);
            return temp;
        }
    }
}
