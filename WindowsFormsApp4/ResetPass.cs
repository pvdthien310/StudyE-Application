using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp4
{
    public partial class ResetPass : Form
    {
        //parent
        LogInForm logInForm;
        //property
        static Random rdcode = new Random();
        string verifyCode;

        public ResetPass()
        {
            InitializeComponent();
        }

        public ResetPass(LogInForm logInForm)
        {
            this.logInForm = logInForm;
            InitializeComponent();
        }
        private void SendCode_button_Click(object sender, EventArgs e)
        {
            if (SupportUtility.IsExistEmail(Email_textbox.Text))
            {
                verifyCode = rdcode.Next(100000, 999999).ToString();

                Thread newThread = new Thread(
                    delegate ()
                    {
                        SupportUtility.SendConfirmEmailToResetPassword(Email_textbox.Text, verifyCode);
                    });
                newThread.Start();
                //SupportUtility.SendConfirmEmailToResetPassword(Email_textbox.Text, verifyCode);
                SendCode_button.Enabled = false;
                Email_textbox.Enabled = false;
                ResetPass_button.Enabled = true;
                ResendCountdown_timer.Enabled = true;
                CountdownResend_label.Visible = true;
                AcceptButton = ResetPass_button;
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thộng báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResendCountdown_timer_Tick(object sender, EventArgs e)
        {
            if (CountdownResend_label.Text == "0")
            {
                ResendCountdown_timer.Enabled = false;
                SendCode_button.Enabled = true;
                CountdownResend_label.Text = "60";
                CountdownResend_label.Visible = false;
                Email_textbox.Enabled = true;
            }
            else
            {
                int remain = Convert.ToInt32(CountdownResend_label.Text);
                remain--;
                CountdownResend_label.Text = remain.ToString();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            logInForm.Show();
            this.Dispose();
        }

        private void ViewPass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(ViewPass_checkbox.Checked)
            {
                NewPass_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                NewPass_textbox.UseSystemPasswordChar = true;
            }
        }

        private void ViewPass2_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewPass2_checkbox.Checked)
            {
                ConfirmPass_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                ConfirmPass_textbox.UseSystemPasswordChar = true;
            }
        }

        private void ResetPass_button_Click(object sender, EventArgs e)
        {
            if (NewPass_textbox.Text == ConfirmPass_textbox.Text)
            {
                if (NewPass_textbox.Text != "" && ConfirmCode_textbox.Text != "" && ConfirmPass_textbox.Text != "")
                {
                    if (verifyCode == ConfirmCode_textbox.Text)
                    {
                        SupportUtility.ResetPassword(Email_textbox.Text, NewPass_textbox.Text);
                        logInForm.Show();
                        logInForm.Name_textbox.Text = SupportUtility.FindNameFromEmail(Email_textbox.Text);
                        logInForm.Pass_textbox.Text = NewPass_textbox.Text;
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mã xác nhận không hợp lệ", "Thộng báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thộng báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp","Thộng báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetPass_Activated(object sender, EventArgs e)
        {
            Email_textbox.Focus();
        }
    }
}
