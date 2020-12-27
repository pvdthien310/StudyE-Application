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
    public partial class SignUpForm : Form
    {
        bool isSuccess = true;
        //parent form
        public LogInForm logInForm;
        //child form
        ConfirmNewAccount confirmNewAccount;
        //property
        public static Random rdCode = new Random();
        public string verifyCode;
        public SignUpForm()
        {
            InitializeComponent();
        }
        public SignUpForm(LogInForm logInForm)
        {
            InitializeComponent();
            this.logInForm = logInForm;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public SignUpForm(ConfirmNewAccount confirmNewAccount)
        {
            InitializeComponent();
            this.confirmNewAccount = confirmNewAccount;
        }
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            logInForm.Show();
            this.Dispose();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            
            if (Email_textbox.Text != "" && Name_textbox.Text != "" && Pass_textbox.Text != "" && ConfirmPass_textbox.Text != "")
            {
                if (!SupportUtility.IsExistEmail(Email_textbox.Text) )
                {
                    if (!SupportUtility.IsExistAccount(Name_textbox.Text))
                    {
                        if (ConfirmPass_textbox.Text == Pass_textbox.Text)
                        {
                            verifyCode = rdCode.Next(100000, 999999).ToString();
                            try
                            {
                                SupportUtility.SendConfirmEmailToCreateAccount(Email_textbox.Text, verifyCode);
                                confirmNewAccount = new ConfirmNewAccount(this);
                                confirmNewAccount.Show();
                                this.Hide();
                            }  
                            catch(Exception)
                            {
                                MessageBox.Show("Không thể gửi mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Email đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void Email_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(Email_textbox.Text != "")
                {
                    Name_textbox.Focus();
                }    
            }    
        }

        private void Name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Email_textbox.Text != "" && Name_textbox.Text != "")
                {
                    Pass_textbox.Focus();
                }
            }
        }

        private void Pass_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Email_textbox.Text != "" && Name_textbox.Text != "" && Pass_textbox.Text != "")
                {
                    ConfirmPass_textbox.Focus();
                }
            }
        }

        private void ConfirmPass_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Email_textbox.Text != "" && Name_textbox.Text != "" && Pass_textbox.Text != "" && ConfirmPass_textbox.Text != "")
                {
                    SignUp_button.Focus();
                    EventArgs newE = new EventArgs();
                    SignUp_button_Click(sender, newE);
                }
            }
        }

        private void SignUpForm_Activated(object sender, EventArgs e)
        {
            Email_textbox.Focus();
        }

        private void ViewPass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(ViewPass_checkbox.Checked)
            {
                Pass_textbox.UseSystemPasswordChar = false;
            }    
            else
            {
                Pass_textbox.UseSystemPasswordChar = true;
            }    
        }

        private void ViewPass2_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(ViewPass2_checkbox.Checked)
            {
                ConfirmPass_textbox.UseSystemPasswordChar = false;
            }    
            else
            {
                ConfirmPass_textbox.UseSystemPasswordChar = true;
            }    
        }
    }
}
