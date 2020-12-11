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
            this.Or_label = new System.Windows.Forms.Label();
            this.ForgerYourPass_label = new System.Windows.Forms.Label();
            this.Name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pass_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameOrMail_label = new System.Windows.Forms.Label();
            this.Pass_label = new System.Windows.Forms.Label();
            this.ViewPass_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Save_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // SignIn_button
            // 
            this.SignIn_button.BorderRadius = 15;
            this.SignIn_button.CheckedState.Parent = this.SignIn_button;
            this.SignIn_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_button.CustomImages.Parent = this.SignIn_button;
            this.SignIn_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignIn_button.ForeColor = System.Drawing.Color.White;
            this.SignIn_button.HoverState.Parent = this.SignIn_button;
            this.SignIn_button.Location = new System.Drawing.Point(81, 176);
            this.SignIn_button.Name = "SignIn_button";
            this.SignIn_button.ShadowDecoration.Parent = this.SignIn_button;
            this.SignIn_button.Size = new System.Drawing.Size(136, 33);
            this.SignIn_button.TabIndex = 4;
            this.SignIn_button.Text = "Sign In";
            this.SignIn_button.Click += new System.EventHandler(this.SignIn_button_Click);
            // 
            // SignUp_button
            // 
            this.SignUp_button.BorderRadius = 15;
            this.SignUp_button.CheckedState.Parent = this.SignUp_button;
            this.SignUp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_button.CustomImages.Parent = this.SignUp_button;
            this.SignUp_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUp_button.ForeColor = System.Drawing.Color.White;
            this.SignUp_button.HoverState.Parent = this.SignUp_button;
            this.SignUp_button.Location = new System.Drawing.Point(81, 226);
            this.SignUp_button.Name = "SignUp_button";
            this.SignUp_button.ShadowDecoration.Parent = this.SignUp_button;
            this.SignUp_button.Size = new System.Drawing.Size(136, 33);
            this.SignUp_button.TabIndex = 5;
            this.SignUp_button.Text = "Sign Up";
            this.SignUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // Or_label
            // 
            this.Or_label.AutoSize = true;
            this.Or_label.Location = new System.Drawing.Point(142, 210);
            this.Or_label.Name = "Or_label";
            this.Or_label.Size = new System.Drawing.Size(16, 13);
            this.Or_label.TabIndex = 20;
            this.Or_label.Text = "or";
            // 
            // ForgerYourPass_label
            // 
            this.ForgerYourPass_label.AutoSize = true;
            this.ForgerYourPass_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgerYourPass_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgerYourPass_label.Location = new System.Drawing.Point(85, 264);
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
            this.Name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_textbox.DefaultText = "";
            this.Name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_textbox.DisabledState.Parent = this.Name_textbox;
            this.Name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_textbox.FocusedState.Parent = this.Name_textbox;
            this.Name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_textbox.HoverState.Parent = this.Name_textbox;
            this.Name_textbox.Location = new System.Drawing.Point(80, 47);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.PasswordChar = '\0';
            this.Name_textbox.PlaceholderText = "";
            this.Name_textbox.SelectedText = "";
            this.Name_textbox.ShadowDecoration.Parent = this.Name_textbox;
            this.Name_textbox.Size = new System.Drawing.Size(200, 36);
            this.Name_textbox.TabIndex = 0;
            this.Name_textbox.TextChanged += new System.EventHandler(this.Name_textbox_TextChanged);
            this.Name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_textbox_KeyPress);
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass_textbox.DefaultText = "";
            this.Pass_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pass_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pass_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass_textbox.DisabledState.Parent = this.Pass_textbox;
            this.Pass_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass_textbox.FocusedState.Parent = this.Pass_textbox;
            this.Pass_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass_textbox.HoverState.Parent = this.Pass_textbox;
            this.Pass_textbox.Location = new System.Drawing.Point(80, 105);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.PasswordChar = '\0';
            this.Pass_textbox.PlaceholderText = "";
            this.Pass_textbox.SelectedText = "";
            this.Pass_textbox.ShadowDecoration.Parent = this.Pass_textbox;
            this.Pass_textbox.Size = new System.Drawing.Size(200, 36);
            this.Pass_textbox.TabIndex = 1;
            this.Pass_textbox.UseSystemPasswordChar = true;
            this.Pass_textbox.TextChanged += new System.EventHandler(this.Name_textbox_TextChanged);
            this.Pass_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pass_textbox_KeyPress);
            // 
            // NameOrMail_label
            // 
            this.NameOrMail_label.AutoSize = true;
            this.NameOrMail_label.Location = new System.Drawing.Point(5, 58);
            this.NameOrMail_label.Name = "NameOrMail_label";
            this.NameOrMail_label.Size = new System.Drawing.Size(59, 13);
            this.NameOrMail_label.TabIndex = 7;
            this.NameOrMail_label.Text = "Name/Mail";
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Location = new System.Drawing.Point(23, 115);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(53, 13);
            this.Pass_label.TabIndex = 7;
            this.Pass_label.Text = "Password";
            // 
            // ViewPass_checkbox
            // 
            this.ViewPass_checkbox.AutoSize = true;
            this.ViewPass_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.CheckedState.BorderRadius = 2;
            this.ViewPass_checkbox.CheckedState.BorderThickness = 0;
            this.ViewPass_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.Location = new System.Drawing.Point(182, 147);
            this.ViewPass_checkbox.Name = "ViewPass_checkbox";
            this.ViewPass_checkbox.Size = new System.Drawing.Size(98, 17);
            this.ViewPass_checkbox.TabIndex = 3;
            this.ViewPass_checkbox.Text = "View Password";
            this.ViewPass_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass_checkbox.UncheckedState.BorderRadius = 2;
            this.ViewPass_checkbox.UncheckedState.BorderThickness = 0;
            this.ViewPass_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass_checkbox.UseVisualStyleBackColor = true;
            this.ViewPass_checkbox.CheckedChanged += new System.EventHandler(this.ViewPass_checkbox_CheckedChanged);
            // 
            // Save_checkbox
            // 
            this.Save_checkbox.AutoSize = true;
            this.Save_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_checkbox.CheckedState.BorderRadius = 2;
            this.Save_checkbox.CheckedState.BorderThickness = 0;
            this.Save_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_checkbox.Location = new System.Drawing.Point(81, 147);
            this.Save_checkbox.Name = "Save_checkbox";
            this.Save_checkbox.Size = new System.Drawing.Size(51, 17);
            this.Save_checkbox.TabIndex = 2;
            this.Save_checkbox.Text = "Save";
            this.Save_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Save_checkbox.UncheckedState.BorderRadius = 2;
            this.Save_checkbox.UncheckedState.BorderThickness = 0;
            this.Save_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Save_checkbox.UseVisualStyleBackColor = true;
            this.Save_checkbox.CheckedChanged += new System.EventHandler(this.Save_checkbox_CheckedChanged);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 348);
            this.Controls.Add(this.Save_checkbox);
            this.Controls.Add(this.ViewPass_checkbox);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.NameOrMail_label);
            this.Controls.Add(this.Pass_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.ForgerYourPass_label);
            this.Controls.Add(this.Or_label);
            this.Controls.Add(this.SignUp_button);
            this.Controls.Add(this.SignIn_button);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Activated += new System.EventHandler(this.LogInForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button SignIn_button;
        private Guna.UI2.WinForms.Guna2Button SignUp_button;
        private System.Windows.Forms.Label Or_label;
        private System.Windows.Forms.Label ForgerYourPass_label;
        private System.Windows.Forms.Label NameOrMail_label;
        private System.Windows.Forms.Label Pass_label;
        private Guna.UI2.WinForms.Guna2CheckBox ViewPass_checkbox;
        private Guna.UI2.WinForms.Guna2CheckBox Save_checkbox;
        public Guna.UI2.WinForms.Guna2TextBox Name_textbox;
        public Guna.UI2.WinForms.Guna2TextBox Pass_textbox;
    }
}