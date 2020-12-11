namespace WindowsFormsApp4
{
    partial class SignUpForm
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
            this.Pass_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Pass_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignUp_button = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmPass_label = new System.Windows.Forms.Label();
            this.ConfirmPass_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cancel_button = new Guna.UI2.WinForms.Guna2Button();
            this.ViewPass_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ViewPass2_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Location = new System.Drawing.Point(27, 155);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(53, 13);
            this.Pass_label.TabIndex = 15;
            this.Pass_label.Text = "Password";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(26, 103);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 14;
            this.Name_label.Text = "Name";
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
            this.Pass_textbox.Location = new System.Drawing.Point(84, 146);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.PasswordChar = '\0';
            this.Pass_textbox.PlaceholderText = "";
            this.Pass_textbox.SelectedText = "";
            this.Pass_textbox.ShadowDecoration.Parent = this.Pass_textbox;
            this.Pass_textbox.Size = new System.Drawing.Size(200, 36);
            this.Pass_textbox.TabIndex = 13;
            this.Pass_textbox.UseSystemPasswordChar = true;
            this.Pass_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pass_textbox_KeyPress);
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
            this.Name_textbox.Location = new System.Drawing.Point(84, 92);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.PasswordChar = '\0';
            this.Name_textbox.PlaceholderText = "";
            this.Name_textbox.SelectedText = "";
            this.Name_textbox.ShadowDecoration.Parent = this.Name_textbox;
            this.Name_textbox.Size = new System.Drawing.Size(200, 36);
            this.Name_textbox.TabIndex = 12;
            this.Name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_textbox_KeyPress);
            // 
            // SignUp_button
            // 
            this.SignUp_button.BorderRadius = 15;
            this.SignUp_button.CheckedState.Parent = this.SignUp_button;
            this.SignUp_button.CustomImages.Parent = this.SignUp_button;
            this.SignUp_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUp_button.ForeColor = System.Drawing.Color.White;
            this.SignUp_button.HoverState.Parent = this.SignUp_button;
            this.SignUp_button.Location = new System.Drawing.Point(84, 265);
            this.SignUp_button.Name = "SignUp_button";
            this.SignUp_button.ShadowDecoration.Parent = this.SignUp_button;
            this.SignUp_button.Size = new System.Drawing.Size(136, 33);
            this.SignUp_button.TabIndex = 9;
            this.SignUp_button.Text = "Sign Up";
            this.SignUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // ConfirmPass_label
            // 
            this.ConfirmPass_label.AutoSize = true;
            this.ConfirmPass_label.Location = new System.Drawing.Point(9, 208);
            this.ConfirmPass_label.Name = "ConfirmPass_label";
            this.ConfirmPass_label.Size = new System.Drawing.Size(68, 13);
            this.ConfirmPass_label.TabIndex = 17;
            this.ConfirmPass_label.Text = "Confirm Pass";
            // 
            // ConfirmPass_textbox
            // 
            this.ConfirmPass_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPass_textbox.DefaultText = "";
            this.ConfirmPass_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPass_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPass_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPass_textbox.DisabledState.Parent = this.ConfirmPass_textbox;
            this.ConfirmPass_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPass_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPass_textbox.FocusedState.Parent = this.ConfirmPass_textbox;
            this.ConfirmPass_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPass_textbox.HoverState.Parent = this.ConfirmPass_textbox;
            this.ConfirmPass_textbox.Location = new System.Drawing.Point(83, 209);
            this.ConfirmPass_textbox.Name = "ConfirmPass_textbox";
            this.ConfirmPass_textbox.PasswordChar = '\0';
            this.ConfirmPass_textbox.PlaceholderText = "";
            this.ConfirmPass_textbox.SelectedText = "";
            this.ConfirmPass_textbox.ShadowDecoration.Parent = this.ConfirmPass_textbox;
            this.ConfirmPass_textbox.Size = new System.Drawing.Size(200, 36);
            this.ConfirmPass_textbox.TabIndex = 16;
            this.ConfirmPass_textbox.UseSystemPasswordChar = true;
            this.ConfirmPass_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmPass_textbox_KeyPress);
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(24, 51);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(32, 13);
            this.Email_label.TabIndex = 19;
            this.Email_label.Text = "Email";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_textbox.DefaultText = "";
            this.Email_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_textbox.DisabledState.Parent = this.Email_textbox;
            this.Email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_textbox.FocusedState.Parent = this.Email_textbox;
            this.Email_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_textbox.HoverState.Parent = this.Email_textbox;
            this.Email_textbox.Location = new System.Drawing.Point(82, 40);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.PasswordChar = '\0';
            this.Email_textbox.PlaceholderText = "";
            this.Email_textbox.SelectedText = "";
            this.Email_textbox.ShadowDecoration.Parent = this.Email_textbox;
            this.Email_textbox.Size = new System.Drawing.Size(200, 36);
            this.Email_textbox.TabIndex = 18;
            this.Email_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Email_textbox_KeyPress);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BorderRadius = 15;
            this.Cancel_button.CheckedState.Parent = this.Cancel_button;
            this.Cancel_button.CustomImages.Parent = this.Cancel_button;
            this.Cancel_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancel_button.ForeColor = System.Drawing.Color.White;
            this.Cancel_button.HoverState.Parent = this.Cancel_button;
            this.Cancel_button.Location = new System.Drawing.Point(12, 303);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.ShadowDecoration.Parent = this.Cancel_button;
            this.Cancel_button.Size = new System.Drawing.Size(65, 33);
            this.Cancel_button.TabIndex = 20;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ViewPass_checkbox
            // 
            this.ViewPass_checkbox.AutoSize = true;
            this.ViewPass_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.CheckedState.BorderRadius = 2;
            this.ViewPass_checkbox.CheckedState.BorderThickness = 0;
            this.ViewPass_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.Location = new System.Drawing.Point(194, 186);
            this.ViewPass_checkbox.Name = "ViewPass_checkbox";
            this.ViewPass_checkbox.Size = new System.Drawing.Size(98, 17);
            this.ViewPass_checkbox.TabIndex = 21;
            this.ViewPass_checkbox.Text = "View Password";
            this.ViewPass_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass_checkbox.UncheckedState.BorderRadius = 2;
            this.ViewPass_checkbox.UncheckedState.BorderThickness = 0;
            this.ViewPass_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass_checkbox.UseVisualStyleBackColor = true;
            this.ViewPass_checkbox.CheckedChanged += new System.EventHandler(this.ViewPass_checkbox_CheckedChanged);
            // 
            // ViewPass2_checkbox
            // 
            this.ViewPass2_checkbox.AutoSize = true;
            this.ViewPass2_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass2_checkbox.CheckedState.BorderRadius = 2;
            this.ViewPass2_checkbox.CheckedState.BorderThickness = 0;
            this.ViewPass2_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass2_checkbox.Location = new System.Drawing.Point(191, 245);
            this.ViewPass2_checkbox.Name = "ViewPass2_checkbox";
            this.ViewPass2_checkbox.Size = new System.Drawing.Size(98, 17);
            this.ViewPass2_checkbox.TabIndex = 22;
            this.ViewPass2_checkbox.Text = "View Password";
            this.ViewPass2_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass2_checkbox.UncheckedState.BorderRadius = 2;
            this.ViewPass2_checkbox.UncheckedState.BorderThickness = 0;
            this.ViewPass2_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass2_checkbox.UseVisualStyleBackColor = true;
            this.ViewPass2_checkbox.CheckedChanged += new System.EventHandler(this.ViewPass2_checkbox_CheckedChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 348);
            this.Controls.Add(this.ViewPass2_checkbox);
            this.Controls.Add(this.ViewPass_checkbox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.ConfirmPass_label);
            this.Controls.Add(this.ConfirmPass_textbox);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Pass_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.SignUp_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Activated += new System.EventHandler(this.SignUpForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.Label Name_label;
        private Guna.UI2.WinForms.Guna2Button SignUp_button;
        private System.Windows.Forms.Label ConfirmPass_label;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPass_textbox;
        private System.Windows.Forms.Label Email_label;
        private Guna.UI2.WinForms.Guna2Button Cancel_button;
        public Guna.UI2.WinForms.Guna2TextBox Name_textbox;
        private Guna.UI2.WinForms.Guna2CheckBox ViewPass_checkbox;
        private Guna.UI2.WinForms.Guna2CheckBox ViewPass2_checkbox;
        public Guna.UI2.WinForms.Guna2TextBox Pass_textbox;
        public Guna.UI2.WinForms.Guna2TextBox Email_textbox;
    }
}