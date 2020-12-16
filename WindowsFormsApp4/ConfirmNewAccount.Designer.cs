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
            this.SuspendLayout();
            // 
            // TypeCode_label
            // 
            this.TypeCode_label.AutoSize = true;
            this.TypeCode_label.Location = new System.Drawing.Point(12, 40);
            this.TypeCode_label.Name = "TypeCode_label";
            this.TypeCode_label.Size = new System.Drawing.Size(81, 13);
            this.TypeCode_label.TabIndex = 0;
            this.TypeCode_label.Text = "Type your code";
            // 
            // TypeCode_textbox
            // 
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
            this.TypeCode_textbox.Location = new System.Drawing.Point(169, 28);
            this.TypeCode_textbox.Name = "TypeCode_textbox";
            this.TypeCode_textbox.PasswordChar = '\0';
            this.TypeCode_textbox.PlaceholderText = "";
            this.TypeCode_textbox.SelectedText = "";
            this.TypeCode_textbox.ShadowDecoration.Parent = this.TypeCode_textbox;
            this.TypeCode_textbox.Size = new System.Drawing.Size(200, 36);
            this.TypeCode_textbox.TabIndex = 1;
            // 
            // Cancel_button
            // 
            this.Cancel_button.CheckedState.Parent = this.Cancel_button;
            this.Cancel_button.CustomImages.Parent = this.Cancel_button;
            this.Cancel_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancel_button.ForeColor = System.Drawing.Color.White;
            this.Cancel_button.HoverState.Parent = this.Cancel_button;
            this.Cancel_button.Location = new System.Drawing.Point(15, 107);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.ShadowDecoration.Parent = this.Cancel_button;
            this.Cancel_button.Size = new System.Drawing.Size(57, 29);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Confirm_button
            // 
            this.Confirm_button.CheckedState.Parent = this.Confirm_button;
            this.Confirm_button.CustomImages.Parent = this.Confirm_button;
            this.Confirm_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Confirm_button.ForeColor = System.Drawing.Color.White;
            this.Confirm_button.HoverState.Parent = this.Confirm_button;
            this.Confirm_button.Location = new System.Drawing.Point(308, 107);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.ShadowDecoration.Parent = this.Confirm_button;
            this.Confirm_button.Size = new System.Drawing.Size(61, 29);
            this.Confirm_button.TabIndex = 3;
            this.Confirm_button.Text = "Confirm";
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Resend_button
            // 
            this.Resend_button.CheckedState.Parent = this.Resend_button;
            this.Resend_button.CustomImages.Parent = this.Resend_button;
            this.Resend_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Resend_button.ForeColor = System.Drawing.Color.White;
            this.Resend_button.HoverState.Parent = this.Resend_button;
            this.Resend_button.Location = new System.Drawing.Point(153, 105);
            this.Resend_button.Name = "Resend_button";
            this.Resend_button.ShadowDecoration.Parent = this.Resend_button;
            this.Resend_button.Size = new System.Drawing.Size(53, 31);
            this.Resend_button.TabIndex = 3;
            this.Resend_button.Text = "Resend Code";
            this.Resend_button.Click += new System.EventHandler(this.Resend_button_Click);
            // 
            // Warning
            // 
            this.Warning.Location = new System.Drawing.Point(12, 71);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(339, 29);
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
            this.CountDownResend_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDownResend_label.Location = new System.Drawing.Point(214, 108);
            this.CountDownResend_label.Name = "CountDownResend_label";
            this.CountDownResend_label.Size = new System.Drawing.Size(34, 25);
            this.CountDownResend_label.TabIndex = 5;
            this.CountDownResend_label.Text = "60";
            this.CountDownResend_label.Visible = false;
            // 
            // ConfirmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 153);
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
    }
}