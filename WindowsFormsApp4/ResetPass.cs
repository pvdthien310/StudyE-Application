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
                ResetPass_button.Enabled = true;
                ResendCountdown_timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
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
            SupportUtility.ResetPassword(Email_textbox.Text,NewName_textbox.Text, NewPass_textbox.Text);
            logInForm.Show();
            logInForm.Name_textbox.Text = Email_textbox.Text;
            logInForm.Pass_textbox.Text = NewPass_textbox.Text;
            this.Dispose();
        }
    }
}
