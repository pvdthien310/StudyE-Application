using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class LogInForm : Form
    {
        //child form
        RoomChose inRoom;
        SignUpForm signUpForm;
        ResetPass resetPass;
        //property
        public LogInForm()
        {
            InitializeComponent();
        }

        public LogInForm(RoomChose inRoom, SignUpForm signUpForm, ResetPass resetPass )
        {
            InitializeComponent();
            this.inRoom = inRoom;
            this.signUpForm = signUpForm;
            this.resetPass = resetPass;
        }

        //--------------------------
        // Handle Event
        private void SignIn_button_Click(object sender, EventArgs e)
        {
            if (this.Name_textbox.Text != "" && this.Pass_textbox.Text != "")
            {
                if (SupportUtility.IsExistAccount(this.Name_textbox.Text))
                {
                    if (SupportUtility.IsCorrectAccount(this.Name_textbox.Text, this.Pass_textbox.Text))
                    {
                        inRoom = new RoomChose(this.Name_textbox.Text);
                        this.Hide();
                        inRoom.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }    
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            signUpForm = new SignUpForm(this);
            this.Hide();
            signUpForm.Show();
        }

        private void ForgerYourPass_label_Click(object sender, EventArgs e)
        {
            resetPass = new ResetPass(this);
            this.Hide();
            resetPass.Show();
        }

        private void Name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                if(Name_textbox.Text != "")
                {
                    Pass_textbox.Focus();
                }    
        }

        private void Pass_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (Name_textbox.Text != "" && Name_textbox.Text != "")
                {
                    this.SignIn_button.Focus();
                    EventArgs newE = new EventArgs();
                    this.SignIn_button_Click(SignIn_button, newE);
                }
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

        private void ForgerYourPass_label_MouseEnter(object sender, EventArgs e)
        {
            ForgerYourPass_label.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Underline);
        }

        private void ForgerYourPass_label_MouseLeave(object sender, EventArgs e)
        {
            ForgerYourPass_label.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular);
        }

        private void LogInForm_Activated(object sender, EventArgs e)
        {
            this.Name_textbox.Focus();
            DataTable SavedAccount = new DataTable();
            SavedAccount = SupportUtility.FindSavedAccount();
            if(SavedAccount.Rows.Count>0)
            {
                Name_textbox.Text = SavedAccount.Rows[0]["UserName"].ToString();
                Pass_textbox.Text = SavedAccount.Rows[0]["PassWord"].ToString();
                Save_checkbox.Checked = true;
            }    
            else
            {
                Save_checkbox.Checked = false;
            }    

        }

        private void Save_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Save_checkbox.Checked)
            {
                if (SupportUtility.IsCorrectAccount(Name_textbox.Text, Pass_textbox.Text))
                {
                    SupportUtility.SaveAccount(Name_textbox.Text, Pass_textbox.Text);
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu sai");
                }
            }
            else
            {
                DataTable savedAccount = SupportUtility.FindSavedAccount();
                if(savedAccount.Rows.Count>0)
                {
                    SupportUtility.UnSaveAccount(savedAccount.Rows[0]["UserName"].ToString());
                }                 
            }
            
        }

        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {
            Save_checkbox.Checked = false;
        }
    }
}
