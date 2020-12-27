namespace WindowsFormsApp4
{
    partial class LogInForm
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
            this.SignIn_button = new Guna.UI2.WinForms.Guna2Button();
            this.SignUp_button = new Guna.UI2.WinForms.Guna2Button();
            this.ForgerYourPass_label = new System.Windows.Forms.Label();
            this.Name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pass_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameOrMail_label = new System.Windows.Forms.Label();
            this.Pass_label = new System.Windows.Forms.Label();
            this.ViewPass_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Save_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignIn_button
            // 
            this.SignIn_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SignIn_button.BorderRadius = 15;
            this.SignIn_button.CheckedState.Parent = this.SignIn_button;
            this.SignIn_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_button.CustomImages.Parent = this.SignIn_button;
            this.SignIn_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignIn_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_button.ForeColor = System.Drawing.Color.White;
            this.SignIn_button.HoverState.Parent = this.SignIn_button;
            this.SignIn_button.Location = new System.Drawing.Point(132, 246);
            this.SignIn_button.Name = "SignIn_button";
            this.SignIn_button.ShadowDecoration.Parent = this.SignIn_button;
            this.SignIn_button.Size = new System.Drawing.Size(155, 33);
            this.SignIn_button.TabIndex = 2;
            this.SignIn_button.Text = "Sign In";
            this.SignIn_button.Click += new System.EventHandler(this.SignIn_button_Click);
            // 
            // SignUp_button
            // 
            this.SignUp_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SignUp_button.BorderRadius = 15;
            this.SignUp_button.CheckedState.Parent = this.SignUp_button;
            this.SignUp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_button.CustomImages.Parent = this.SignUp_button;
            this.SignUp_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUp_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_button.ForeColor = System.Drawing.Color.White;
            this.SignUp_button.HoverState.Parent = this.SignUp_button;
            this.SignUp_button.Location = new System.Drawing.Point(132, 285);
            this.SignUp_button.Name = "SignUp_button";
            this.SignUp_button.ShadowDecoration.Parent = this.SignUp_button;
            this.SignUp_button.Size = new System.Drawing.Size(155, 33);
            this.SignUp_button.TabIndex = 3;
            this.SignUp_button.Text = "Sign Up";
            this.SignUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // ForgerYourPass_label
            // 
            this.ForgerYourPass_label.AutoSize = true;
            this.ForgerYourPass_label.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ForgerYourPass_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgerYourPass_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgerYourPass_label.Location = new System.Drawing.Point(157, 321);
            this.ForgerYourPass_label.Name = "ForgerYourPass_label";
            this.ForgerYourPass_label.Size = new System.Drawing.Size(126, 15);
            this.ForgerYourPass_label.TabIndex = 6;
            this.ForgerYourPass_label.Text = "Forget your password?";
            this.ForgerYourPass_label.Click += new System.EventHandler(this.ForgerYourPass_label_Click);
            this.ForgerYourPass_label.MouseEnter += new System.EventHandler(this.ForgerYourPass_label_MouseEnter);
            this.ForgerYourPass_label.MouseLeave += new System.EventHandler(this.ForgerYourPass_label_MouseLeave);
            // 
            // Name_textbox
            // 
            this.Name_textbox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Name_textbox.BorderRadius = 15;
            this.Name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_textbox.DefaultText = "";
            this.Name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_textbox.DisabledState.Parent = this.Name_textbox;
            this.Name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_textbox.FocusedState.Parent = this.Name_textbox;
            this.Name_textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_textbox.HoverState.Parent = this.Name_textbox;
            this.Name_textbox.Location = new System.Drawing.Point(121, 107);
            this.Name_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.PasswordChar = '\0';
            this.Name_textbox.PlaceholderText = "";
            this.Name_textbox.SelectedText = "";
            this.Name_textbox.ShadowDecoration.Parent = this.Name_textbox;
            this.Name_textbox.Size = new System.Drawing.Size(209, 36);
            this.Name_textbox.TabIndex = 0;
            this.Name_textbox.TextChanged += new System.EventHandler(this.Name_textbox_TextChanged);
            this.Name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_textbox_KeyPress);
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Pass_textbox.BorderRadius = 15;
            this.Pass_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass_textbox.DefaultText = "";
            this.Pass_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pass_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pass_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass_textbox.DisabledState.Parent = this.Pass_textbox;
            this.Pass_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass_textbox.FocusedState.Parent = this.Pass_textbox;
            this.Pass_textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass_textbox.HoverState.Parent = this.Pass_textbox;
            this.Pass_textbox.Location = new System.Drawing.Point(437, 159);
            this.Pass_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.PasswordChar = '\0';
            this.Pass_textbox.PlaceholderText = "";
            this.Pass_textbox.SelectedText = "";
            this.Pass_textbox.ShadowDecoration.Parent = this.Pass_textbox;
            this.Pass_textbox.Size = new System.Drawing.Size(209, 36);
            this.Pass_textbox.TabIndex = 1;
            this.Pass_textbox.UseSystemPasswordChar = true;
            this.Pass_textbox.TextChanged += new System.EventHandler(this.Name_textbox_TextChanged);
            this.Pass_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pass_textbox_KeyPress);
            // 
            // NameOrMail_label
            // 
            this.NameOrMail_label.AutoSize = true;
            this.NameOrMail_label.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NameOrMail_label.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOrMail_label.ForeColor = System.Drawing.Color.MintCream;
            this.NameOrMail_label.Location = new System.Drawing.Point(25, 116);
            this.NameOrMail_label.Name = "NameOrMail_label";
            this.NameOrMail_label.Size = new System.Drawing.Size(90, 18);
            this.NameOrMail_label.TabIndex = 7;
            this.NameOrMail_label.Text = "Name/Mail";
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Pass_label.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_label.ForeColor = System.Drawing.Color.MintCream;
            this.Pass_label.Location = new System.Drawing.Point(345, 170);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(91, 18);
            this.Pass_label.TabIndex = 7;
            this.Pass_label.Text = "Password";
            // 
            // ViewPass_checkbox
            // 
            this.ViewPass_checkbox.AutoSize = true;
            this.ViewPass_checkbox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ViewPass_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.CheckedState.BorderRadius = 2;
            this.ViewPass_checkbox.CheckedState.BorderThickness = 0;
            this.ViewPass_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPass_checkbox.ForeColor = System.Drawing.Color.MintCream;
            this.ViewPass_checkbox.Location = new System.Drawing.Point(535, 209);
            this.ViewPass_checkbox.Name = "ViewPass_checkbox";
            this.ViewPass_checkbox.Size = new System.Drawing.Size(128, 19);
            this.ViewPass_checkbox.TabIndex = 3;
            this.ViewPass_checkbox.Text = "View Password";
            this.ViewPass_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass_checkbox.UncheckedState.BorderRadius = 2;
            this.ViewPass_checkbox.UncheckedState.BorderThickness = 0;
            this.ViewPass_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass_checkbox.UseVisualStyleBackColor = false;
            this.ViewPass_checkbox.CheckedChanged += new System.EventHandler(this.ViewPass_checkbox_CheckedChanged);
            // 
            // Save_checkbox
            // 
            this.Save_checkbox.AutoSize = true;
            this.Save_checkbox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Save_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_checkbox.CheckedState.BorderRadius = 2;
            this.Save_checkbox.CheckedState.BorderThickness = 0;
            this.Save_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_checkbox.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_checkbox.ForeColor = System.Drawing.Color.MintCream;
            this.Save_checkbox.Location = new System.Drawing.Point(447, 209);
            this.Save_checkbox.Name = "Save_checkbox";
            this.Save_checkbox.Size = new System.Drawing.Size(55, 19);
            this.Save_checkbox.TabIndex = 2;
            this.Save_checkbox.Text = "Save";
            this.Save_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Save_checkbox.UncheckedState.BorderRadius = 2;
            this.Save_checkbox.UncheckedState.BorderThickness = 0;
            this.Save_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Save_checkbox.UseVisualStyleBackColor = false;
            this.Save_checkbox.CheckedChanged += new System.EventHandler(this.Save_checkbox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.guna2CircleButton4);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Controls.Add(this.ForgerYourPass_label);
            this.panel2.Controls.Add(this.SignIn_button);
            this.panel2.Controls.Add(this.Name_textbox);
            this.panel2.Controls.Add(this.NameOrMail_label);
            this.panel2.Controls.Add(this.SignUp_button);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(315, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 350);
            this.panel2.TabIndex = 22;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(137, 41);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(145, 32);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "User Login ";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.MintCream;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(49, 283);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(148, 148);
            this.guna2CircleButton1.TabIndex = 23;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BackColor = System.Drawing.Color.MintCream;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Teal;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(-90, 47);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(148, 148);
            this.guna2CircleButton2.TabIndex = 24;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.BackColor = System.Drawing.Color.MintCream;
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(122, -48);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(173, 119);
            this.guna2CircleButton3.TabIndex = 25;
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.CheckedState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.CustomImages.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.HoverState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Image = global::WindowsFormsApp4.Properties.Resources.home3;
            this.guna2CircleButton4.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton4.Location = new System.Drawing.Point(12, 14);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.ShadowDecoration.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Size = new System.Drawing.Size(54, 51);
            this.guna2CircleButton4.TabIndex = 9;
            this.guna2CircleButton4.Click += new System.EventHandler(this.guna2CircleButton4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.c7de824e_b549_4802_90eb_b7e2e5378a77_200x20011;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(49, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 221);
            this.panel1.TabIndex = 21;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(689, 348);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.Save_checkbox);
            this.Controls.Add(this.ViewPass_checkbox);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.Pass_textbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Activated += new System.EventHandler(this.LogInForm_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button SignIn_button;
        private Guna.UI2.WinForms.Guna2Button SignUp_button;
        private System.Windows.Forms.Label ForgerYourPass_label;
        private System.Windows.Forms.Label NameOrMail_label;
        private System.Windows.Forms.Label Pass_label;
        private Guna.UI2.WinForms.Guna2CheckBox ViewPass_checkbox;
        private Guna.UI2.WinForms.Guna2CheckBox Save_checkbox;
        public Guna.UI2.WinForms.Guna2TextBox Name_textbox;
        public Guna.UI2.WinForms.Guna2TextBox Pass_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
    }
}