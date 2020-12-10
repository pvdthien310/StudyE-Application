namespace WindowsFormsApp4
{
    partial class Picture_Dictionary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pause = new Guna.UI2.WinForms.Guna2Button();
            this.Speak = new Guna.UI2.WinForms.Guna2Button();
            this.Right = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Left = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.creatButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Giao_dien11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(984, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 666);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(862, 517);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 82);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(98, 517);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 82);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Pause);
            this.panel2.Controls.Add(this.Speak);
            this.panel2.Controls.Add(this.Right);
            this.panel2.Controls.Add(this.Left);
            this.panel2.Location = new System.Drawing.Point(312, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 115);
            this.panel2.TabIndex = 5;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.pause1;
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pause.BorderRadius = 12;
            this.Pause.CheckedState.Parent = this.Pause;
            this.Pause.CustomImages.Parent = this.Pause;
            this.Pause.FillColor = System.Drawing.Color.Transparent;
            this.Pause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pause.ForeColor = System.Drawing.Color.Transparent;
            this.Pause.HoverState.Parent = this.Pause;
            this.Pause.Location = new System.Drawing.Point(112, 6);
            this.Pause.Name = "Pause";
            this.Pause.ShadowDecoration.Parent = this.Pause;
            this.Pause.Size = new System.Drawing.Size(100, 102);
            this.Pause.TabIndex = 0;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Speak
            // 
            this.Speak.BackColor = System.Drawing.Color.Transparent;
            this.Speak.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.speak;
            this.Speak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Speak.BorderRadius = 12;
            this.Speak.CheckedState.Parent = this.Speak;
            this.Speak.CustomImages.Parent = this.Speak;
            this.Speak.FillColor = System.Drawing.Color.Transparent;
            this.Speak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Speak.ForeColor = System.Drawing.Color.Transparent;
            this.Speak.HoverState.Parent = this.Speak;
            this.Speak.Location = new System.Drawing.Point(218, 6);
            this.Speak.Name = "Speak";
            this.Speak.ShadowDecoration.Parent = this.Speak;
            this.Speak.Size = new System.Drawing.Size(100, 102);
            this.Speak.TabIndex = 4;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Transparent;
            this.Right.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.left1;
            this.Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Right.CheckedState.Parent = this.Right;
            this.Right.CustomImages.Parent = this.Right;
            this.Right.FillColor = System.Drawing.Color.Transparent;
            this.Right.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Right.ForeColor = System.Drawing.Color.Transparent;
            this.Right.HoverState.Parent = this.Right;
            this.Right.Location = new System.Drawing.Point(322, 6);
            this.Right.Name = "Right";
            this.Right.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Right.ShadowDecoration.Parent = this.Right;
            this.Right.Size = new System.Drawing.Size(100, 102);
            this.Right.TabIndex = 1;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Transparent;
            this.Left.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.a;
            this.Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Left.CheckedState.Parent = this.Left;
            this.Left.CustomImages.Parent = this.Left;
            this.Left.FillColor = System.Drawing.Color.Transparent;
            this.Left.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Left.ForeColor = System.Drawing.Color.Transparent;
            this.Left.HoverState.Parent = this.Left;
            this.Left.Location = new System.Drawing.Point(10, 6);
            this.Left.Name = "Left";
            this.Left.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Left.ShadowDecoration.Parent = this.Left;
            this.Left.Size = new System.Drawing.Size(100, 102);
            this.Left.TabIndex = 3;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(94, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(30, 546);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(64, 58);
            this.guna2Button1.TabIndex = 2;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.a1;
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(30, 612);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(38, 34);
            this.guna2CircleButton1.TabIndex = 3;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(109, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(849, 463);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // creatButton
            // 
            this.creatButton.CheckedState.Parent = this.creatButton;
            this.creatButton.CustomImages.Parent = this.creatButton;
            this.creatButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.creatButton.ForeColor = System.Drawing.Color.White;
            this.creatButton.HoverState.Parent = this.creatButton;
            this.creatButton.Location = new System.Drawing.Point(12, 517);
            this.creatButton.Name = "creatButton";
            this.creatButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.creatButton.ShadowDecoration.Parent = this.creatButton;
            this.creatButton.Size = new System.Drawing.Size(61, 58);
            this.creatButton.TabIndex = 5;
            this.creatButton.Text = "guna2CircleButton2";
            this.creatButton.Click += new System.EventHandler(this.creatButton_Click);
            // 
            // Picture_Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Giao_dien1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 665);
            this.ControlBox = false;
            this.Controls.Add(this.creatButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button1);
            this.DoubleBuffered = true;
            this.Name = "Picture_Dictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture_Dictionary";
            this.Load += new System.EventHandler(this.Picture_Dictionary_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.ImageList Animal;
        //private System.Windows.Forms.ImageList Bathroom;
        //private System.Windows.Forms.ImageList Body;
        //private System.Windows.Forms.ImageList Buidings;
        //private System.Windows.Forms.ImageList Clothes;
        //private System.Windows.Forms.ImageList Colors;
        //private System.Windows.Forms.ImageList Computers;
        //private System.Windows.Forms.ImageList Countries;
        //private System.Windows.Forms.ImageList Food;
        //private System.Windows.Forms.ImageList Garden;
        //private System.Windows.Forms.ImageList Home;
        //private System.Windows.Forms.ImageList Hospital;
        //private System.Windows.Forms.ImageList Jobs;
        //private System.Windows.Forms.ImageList Kitchen;
        //private System.Windows.Forms.ImageList Letters;
        //private System.Windows.Forms.ImageList Music;
        //private System.Windows.Forms.ImageList Nature;
        //private System.Windows.Forms.ImageList Number;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton Right;
        private Guna.UI2.WinForms.Guna2Button Pause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button Speak;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleButton Left;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton creatButton;
    }
}