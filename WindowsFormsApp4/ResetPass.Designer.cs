namespace WindowsFormsApp4
{
    partial class ResetPass
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
            this.components = new System.ComponentModel.Container();
            this.ConfirmCode_label = new System.Windows.Forms.Label();
            this.ConfirmCode_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewPass_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPass_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConfirmPass_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ResetPass_button = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel_button = new Guna.UI2.WinForms.Guna2Button();
            this.Email = new System.Windows.Forms.Label();
            this.Email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendCode_button = new Guna.UI2.WinForms.Guna2Button();
            this.CountdownResend_label = new System.Windows.Forms.Label();
            this.ResendCountdown_timer = new System.Windows.Forms.Timer(this.components);
            this.ViewPass_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ViewPass2_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ConfirmCode_label
            // 
            this.ConfirmCode_label.AutoSize = true;
            this.ConfirmCode_label.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmCode_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConfirmCode_label.Location = new System.Drawing.Point(17, 163);
            this.ConfirmCode_label.Name = "ConfirmCode_label";
            this.ConfirmCode_label.Size = new System.Drawing.Size(105, 17);
            this.ConfirmCode_label.TabIndex = 0;
            this.ConfirmCode_label.Text = "Confirm Code";
            // 
            // ConfirmCode_textbox
            // 
            this.ConfirmCode_textbox.BorderRadius = 15;
            this.ConfirmCode_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmCode_textbox.DefaultText = "";
            this.ConfirmCode_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmCode_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmCode_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmCode_textbox.DisabledState.Parent = this.ConfirmCode_textbox;
            this.ConfirmCode_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmCode_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmCode_textbox.FocusedState.Parent = this.ConfirmCode_textbox;
            this.ConfirmCode_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmCode_textbox.HoverState.Parent = this.ConfirmCode_textbox;
            this.ConfirmCode_textbox.Location = new System.Drawing.Point(163, 154);
            this.ConfirmCode_textbox.Name = "ConfirmCode_textbox";
            this.ConfirmCode_textbox.PasswordChar = '\0';
            this.ConfirmCode_textbox.PlaceholderText = "";
            this.ConfirmCode_textbox.SelectedText = "";
            this.ConfirmCode_textbox.ShadowDecoration.Parent = this.ConfirmCode_textbox;
            this.ConfirmCode_textbox.Size = new System.Drawing.Size(200, 36);
            this.ConfirmCode_textbox.TabIndex = 3;
            // 
            // NewPass_label
            // 
            this.NewPass_label.AutoSize = true;
            this.NewPass_label.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewPass_label.Location = new System.Drawing.Point(17, 205);
            this.NewPass_label.Name = "NewPass_label";
            this.NewPass_label.Size = new System.Drawing.Size(115, 17);
            this.NewPass_label.TabIndex = 2;
            this.NewPass_label.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm Password";
            // 
            // NewPass_textbox
            // 
            this.NewPass_textbox.BorderRadius = 15;
            this.NewPass_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPass_textbox.DefaultText = "";
            this.NewPass_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPass_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPass_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPass_textbox.DisabledState.Parent = this.NewPass_textbox;
            this.NewPass_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPass_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPass_textbox.FocusedState.Parent = this.NewPass_textbox;
            this.NewPass_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPass_textbox.HoverState.Parent = this.NewPass_textbox;
            this.NewPass_textbox.Location = new System.Drawing.Point(163, 196);
            this.NewPass_textbox.Name = "NewPass_textbox";
            this.NewPass_textbox.PasswordChar = '\0';
            this.NewPass_textbox.PlaceholderText = "";
            this.NewPass_textbox.SelectedText = "";
            this.NewPass_textbox.ShadowDecoration.Parent = this.NewPass_textbox;
            this.NewPass_textbox.Size = new System.Drawing.Size(200, 36);
            this.NewPass_textbox.TabIndex = 4;
            this.NewPass_textbox.UseSystemPasswordChar = true;
            // 
            // ConfirmPass_textbox
            // 
            this.ConfirmPass_textbox.BorderRadius = 15;
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
            this.ConfirmPass_textbox.Location = new System.Drawing.Point(163, 259);
            this.ConfirmPass_textbox.Name = "ConfirmPass_textbox";
            this.ConfirmPass_textbox.PasswordChar = '\0';
            this.ConfirmPass_textbox.PlaceholderText = "";
            this.ConfirmPass_textbox.SelectedText = "";
            this.ConfirmPass_textbox.ShadowDecoration.Parent = this.ConfirmPass_textbox;
            this.ConfirmPass_textbox.Size = new System.Drawing.Size(200, 36);
            this.ConfirmPass_textbox.TabIndex = 5;
            this.ConfirmPass_textbox.UseSystemPasswordChar = true;
            // 
            // ResetPass_button
            // 
            this.ResetPass_button.BorderRadius = 15;
            this.ResetPass_button.CheckedState.Parent = this.ResetPass_button;
            this.ResetPass_button.CustomImages.Parent = this.ResetPass_button;
            this.ResetPass_button.Enabled = false;
            this.ResetPass_button.FillColor = System.Drawing.Color.Teal;
            this.ResetPass_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPass_button.ForeColor = System.Drawing.Color.White;
            this.ResetPass_button.HoverState.Parent = this.ResetPass_button;
            this.ResetPass_button.Location = new System.Drawing.Point(219, 333);
            this.ResetPass_button.Name = "ResetPass_button";
            this.ResetPass_button.ShadowDecoration.Parent = this.ResetPass_button;
            this.ResetPass_button.Size = new System.Drawing.Size(144, 39);
            this.ResetPass_button.TabIndex = 5;
            this.ResetPass_button.Text = "Reset Password";
            this.ResetPass_button.Click += new System.EventHandler(this.ResetPass_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BorderRadius = 15;
            this.Cancel_button.CheckedState.Parent = this.Cancel_button;
            this.Cancel_button.CustomImages.Parent = this.Cancel_button;
            this.Cancel_button.FillColor = System.Drawing.Color.Teal;
            this.Cancel_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.ForeColor = System.Drawing.Color.White;
            this.Cancel_button.HoverState.Parent = this.Cancel_button;
            this.Cancel_button.Location = new System.Drawing.Point(20, 333);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.ShadowDecoration.Parent = this.Cancel_button;
            this.Cancel_button.Size = new System.Drawing.Size(109, 39);
            this.Cancel_button.TabIndex = 6;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.Location = new System.Drawing.Point(21, 72);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 17);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // Email_textbox
            // 
            this.Email_textbox.BorderRadius = 15;
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
            this.Email_textbox.Location = new System.Drawing.Point(163, 59);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.PasswordChar = '\0';
            this.Email_textbox.PlaceholderText = "";
            this.Email_textbox.SelectedText = "";
            this.Email_textbox.ShadowDecoration.Parent = this.Email_textbox;
            this.Email_textbox.Size = new System.Drawing.Size(200, 36);
            this.Email_textbox.TabIndex = 0;
            // 
            // SendCode_button
            // 
            this.SendCode_button.BorderRadius = 15;
            this.SendCode_button.CheckedState.Parent = this.SendCode_button;
            this.SendCode_button.CustomImages.Parent = this.SendCode_button;
            this.SendCode_button.FillColor = System.Drawing.Color.Teal;
            this.SendCode_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendCode_button.ForeColor = System.Drawing.Color.White;
            this.SendCode_button.HoverState.Parent = this.SendCode_button;
            this.SendCode_button.Location = new System.Drawing.Point(237, 104);
            this.SendCode_button.Name = "SendCode_button";
            this.SendCode_button.ShadowDecoration.Parent = this.SendCode_button;
            this.SendCode_button.Size = new System.Drawing.Size(126, 44);
            this.SendCode_button.TabIndex = 1;
            this.SendCode_button.Text = "Give me a code";
            this.SendCode_button.Click += new System.EventHandler(this.SendCode_button_Click);
            // 
            // CountdownResend_label
            // 
            this.CountdownResend_label.AutoSize = true;
            this.CountdownResend_label.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownResend_label.Location = new System.Drawing.Point(201, 113);
            this.CountdownResend_label.Name = "CountdownResend_label";
            this.CountdownResend_label.Size = new System.Drawing.Size(35, 26);
            this.CountdownResend_label.TabIndex = 12;
            this.CountdownResend_label.Text = "60";
            this.CountdownResend_label.Visible = false;
            // 
            // ResendCountdown_timer
            // 
            this.ResendCountdown_timer.Interval = 1000;
            this.ResendCountdown_timer.Tick += new System.EventHandler(this.ResendCountdown_timer_Tick);
            // 
            // ViewPass_checkbox
            // 
            this.ViewPass_checkbox.AutoSize = true;
            this.ViewPass_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.CheckedState.BorderRadius = 2;
            this.ViewPass_checkbox.CheckedState.BorderThickness = 0;
            this.ViewPass_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewPass_checkbox.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPass_checkbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewPass_checkbox.Location = new System.Drawing.Point(237, 234);
            this.ViewPass_checkbox.Name = "ViewPass_checkbox";
            this.ViewPass_checkbox.Size = new System.Drawing.Size(128, 19);
            this.ViewPass_checkbox.TabIndex = 13;
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
            this.ViewPass2_checkbox.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPass2_checkbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewPass2_checkbox.Location = new System.Drawing.Point(237, 301);
            this.ViewPass2_checkbox.Name = "ViewPass2_checkbox";
            this.ViewPass2_checkbox.Size = new System.Drawing.Size(128, 19);
            this.ViewPass2_checkbox.TabIndex = 14;
            this.ViewPass2_checkbox.Text = "View Password";
            this.ViewPass2_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass2_checkbox.UncheckedState.BorderRadius = 2;
            this.ViewPass2_checkbox.UncheckedState.BorderThickness = 0;
            this.ViewPass2_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ViewPass2_checkbox.UseVisualStyleBackColor = true;
            this.ViewPass2_checkbox.CheckedChanged += new System.EventHandler(this.ViewPass2_checkbox_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Teal;
            this.guna2Button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(49, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(301, 46);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "RESET PASSWORD";
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(383, 387);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ViewPass2_checkbox);
            this.Controls.Add(this.ViewPass_checkbox);
            this.Controls.Add(this.CountdownResend_label);
            this.Controls.Add(this.SendCode_button);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.ResetPass_button);
            this.Controls.Add(this.ConfirmPass_textbox);
            this.Controls.Add(this.NewPass_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPass_label);
            this.Controls.Add(this.ConfirmCode_textbox);
            this.Controls.Add(this.ConfirmCode_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConfirmCode_label;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmCode_textbox;
        private System.Windows.Forms.Label NewPass_label;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox NewPass_textbox;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPass_textbox;
        private Guna.UI2.WinForms.Guna2Button ResetPass_button;
        private Guna.UI2.WinForms.Guna2Button Cancel_button;
        private System.Windows.Forms.Label Email;
        private Guna.UI2.WinForms.Guna2TextBox Email_textbox;
        private Guna.UI2.WinForms.Guna2Button SendCode_button;
        private System.Windows.Forms.Label CountdownResend_label;
        private System.Windows.Forms.Timer ResendCountdown_timer;
        private Guna.UI2.WinForms.Guna2CheckBox ViewPass_checkbox;
        private Guna.UI2.WinForms.Guna2CheckBox ViewPass2_checkbox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}