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
    public partial class ConfirmNewAccount : Form
    {
        //parent
        SignUpForm signUpForm;
        //child room
        RoomChose roomChose;

        //property
        Random rdCode = new Random();
        public ConfirmNewAccount()
        {
            InitializeComponent();
        }
        public ConfirmNewAccount(SignUpForm signUpForm)
        {
            InitializeComponent();
            this.signUpForm = signUpForm;
        }
        public ConfirmNewAccount(RoomChose roomChose)
        {
            InitializeComponent();
            this.roomChose = roomChose;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            signUpForm.Show();
            this.Dispose();
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            if (TypeCode_textbox.Text == signUpForm.verifyCode)
            {
                SupportUtility.CreateAccount(signUpForm.Email_textbox.Text, signUpForm.Name_textbox.Text, signUpForm.Pass_textbox.Text);
                roomChose = new RoomChose(signUpForm.Name_textbox.Text);
                roomChose.Show();
                signUpForm.Dispose();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Mã xác nhận sai!");
            }    
        }

        private void ConfirmNewAccount_Activated(object sender, EventArgs e)
        {
            TypeCode_textbox.Focus();
        }

        private void Resend_button_Click(object sender, EventArgs e)
        {
            signUpForm.verifyCode = rdCode.Next(100000, 999999).ToString();
            Thread newThread = new Thread
                (
                    delegate()
                    {
                        SupportUtility.SendConfirmEmailToCreateAccount(signUpForm.Email_textbox.Text, signUpForm.verifyCode);
                    }
                );
            newThread.Start();
            Resend_button.Enabled = false;
            CountDownResend_label.Visible = true;
            Resend_timer.Enabled = true;         
        }

        private void Resend_timer_Tick(object sender, EventArgs e)
        {
            if(CountDownResend_label.Text == "0")
            {
                Resend_timer.Enabled = false;
                Resend_button.Enabled = true;
                CountDownResend_label.Text = "60";
                CountDownResend_label.Visible = false;
            }    
            else
            {
                int remain = Convert.ToInt32(CountDownResend_label.Text);
                remain--;
                CountDownResend_label.Text = remain.ToString();
            }    
        }
    }
}
