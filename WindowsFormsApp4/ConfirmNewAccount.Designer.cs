namespace WindowsFormsApp4
{
    partial class ConfirmNewAccount
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
            this.TypeCode_label = new System.Windows.Forms.Label();
            this.TypeCode_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cancel_button = new Guna.UI2.WinForms.Guna2Button();
            this.Confirm_button = new Guna.UI2.WinForms.Guna2Button();
            this.Resend_button = new Guna.UI2.WinForms.Guna2Button();
            this.Warning = new System.Windows.Forms.Label();
            this.Resend_timer = new System.Windows.Forms.Timer(this.components);
            this.CountDownResend_label = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // TypeCode_label
            // 
            this.TypeCode_label.AutoSize = true;
            this.TypeCode_label.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCode_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TypeCode_label.Location = new System.Drawing.Point(11, 67);
            this.TypeCode_label.Name = "TypeCode_label";
            this.TypeCode_label.Size = new System.Drawing.Size(96, 14);
            this.TypeCode_label.TabIndex = 0;
            this.TypeCode_label.Text = "Type your code";
            this.TypeCode_label.Click += new System.EventHandler(this.TypeCode_label_Click);
            // 
            // TypeCode_textbox
            // 
            this.TypeCode_textbox.BorderRadius = 15;
            this.TypeCode_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeCode_textbox.DefaultText = "";
            this.TypeCode_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TypeCode_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TypeCode_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeCode_textbox.DisabledState.Parent = this.TypeCode_textbox;
            this.TypeCode_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeCode_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeCode_textbox.FocusedState.Parent = this.TypeCode_textbox;
            this.TypeCode_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeCode_textbox.HoverState.Parent = this.TypeCode_textbox;
            this.TypeCode_textbox.Location = new System.Drawing.Point(116, 60);
            this.TypeCode_textbox.Name = "TypeCode_textbox";
            this.TypeCode_textbox.PasswordChar = '\0';
            this.TypeCode_textbox.PlaceholderText = "";
            this.TypeCode_textbox.SelectedText = "";
            this.TypeCode_textbox.ShadowDecoration.Parent = this.TypeCode_textbox;
            this.TypeCode_textbox.Size = new System.Drawing.Size(156, 29);
            this.TypeCode_textbox.TabIndex = 1;
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
            this.Cancel_button.Location = new System.Drawing.Point(10, 137);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.ShadowDecoration.Parent = this.Cancel_button;
            this.Cancel_button.Size = new System.Drawing.Size(66, 29);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.TabStop = false;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Confirm_button
            // 
            this.Confirm_button.BorderRadius = 15;
            this.Confirm_button.CheckedState.Parent = this.Confirm_button;
            this.Confirm_button.CustomImages.Parent = this.Confirm_button;
            this.Confirm_button.FillColor = System.Drawing.Color.Teal;
            this.Confirm_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_button.ForeColor = System.Drawing.Color.White;
            this.Confirm_button.HoverState.Parent = this.Confirm_button;
            this.Confirm_button.Location = new System.Drawing.Point(291, 60);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.ShadowDecoration.Parent = this.Confirm_button;
            this.Confirm_button.Size = new System.Drawing.Size(70, 29);
            this.Confirm_button.TabIndex = 3;
            this.Confirm_button.TabStop = false;
            this.Confirm_button.Text = "Confirm";
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Resend_button
            // 
            this.Resend_button.BorderRadius = 15;
            this.Resend_button.CheckedState.Parent = this.Resend_button;
            this.Resend_button.CustomImages.Parent = this.Resend_button;
            this.Resend_button.FillColor = System.Drawing.Color.Teal;
            this.Resend_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resend_button.ForeColor = System.Drawing.Color.White;
            this.Resend_button.HoverState.Parent = this.Resend_button;
            this.Resend_button.Location = new System.Drawing.Point(264, 137);
            this.Resend_button.Name = "Resend_button";
            this.Resend_button.ShadowDecoration.Parent = this.Resend_button;
            this.Resend_button.Size = new System.Drawing.Size(113, 31);
            this.Resend_button.TabIndex = 3;
            this.Resend_button.TabStop = false;
            this.Resend_button.Text = "Resend Code";
            this.Resend_button.Click += new System.EventHandler(this.Resend_button_Click);
            // 
            // Warning
            // 
            this.Warning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Warning.Location = new System.Drawing.Point(12, 98);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(339, 31);
            this.Warning.TabIndex = 4;
            this.Warning.Text = "We have sent a confirmation code to your email, if you haven\'t received it, pleas" +
    "e click \"Resend\"";
            // 
            // Resend_timer
            // 
            this.Resend_timer.Interval = 1000;
            this.Resend_timer.Tick += new System.EventHandler(this.Resend_timer_Tick);
            // 
            // CountDownResend_label
            // 
            this.CountDownResend_label.AutoSize = true;
            this.CountDownResend_label.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDownResend_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CountDownResend_label.Location = new System.Drawing.Point(231, 142);
            this.CountDownResend_label.Name = "CountDownResend_label";
            this.CountDownResend_label.Size = new System.Drawing.Size(27, 20);
            this.CountDownResend_label.TabIndex = 5;
            this.CountDownResend_label.Text = "60";
            this.CountDownResend_label.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Teal;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(64, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(256, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.TabStop = false;
            this.guna2Button1.Text = "CONFIRM NEW ACCOUNT";
            // 
            // ConfirmNewAccount
            // 
            this.AcceptButton = this.Confirm_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(383, 176);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.CountDownResend_label);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Resend_button);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.TypeCode_textbox);
            this.Controls.Add(this.TypeCode_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmNewAccount";
            this.Activated += new System.EventHandler(this.ConfirmNewAccount_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeCode_label;
        private Guna.UI2.WinForms.Guna2TextBox TypeCode_textbox;
        private Guna.UI2.WinForms.Guna2Button Cancel_button;
        private Guna.UI2.WinForms.Guna2Button Confirm_button;
        private Guna.UI2.WinForms.Guna2Button Resend_button;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Timer Resend_timer;
        private System.Windows.Forms.Label CountDownResend_label;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}