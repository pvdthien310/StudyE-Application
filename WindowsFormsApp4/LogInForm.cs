using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class LogInForm : Form
    {
        public mainForm parent;
        //child form
        public RoomChose inRoom = null;
        public SignUpForm signUpForm;
        public ResetPass resetPass;
        //property
        public LogInForm()
        {
            InitializeComponent();
        }

        //public LogInForm(mainForm parent, SignUpForm signUpForm, ResetPass resetPass )
        public LogInForm(mainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
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
                        if (!SupportUtility.IsSignIn(Name_textbox.Text))
                        {
                            //inRoom = new RoomChose(this.Name_textbox.Text);
                            inRoom = new RoomChose(this.Name_textbox.Text, this);
                            this.Hide();
                            inRoom.Show();
                            SupportUtility.SetSignIn(Name_textbox.Text);
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đang được sử dụng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (e.KeyChar == (char)Keys.Enter)
                if (Name_textbox.Text != "")
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
            ForgerYourPass_label.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Underline | FontStyle.Bold);
        }

        private void ForgerYourPass_label_MouseLeave(object sender, EventArgs e)
        {
            ForgerYourPass_label.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
        }

        private void LogInForm_Activated(object sender, EventArgs e)
        {
            //bat timer check internet
            CheckInternet_timer.Interval = 50;
            CheckInternet_timer.Enabled = true;

            this.Name_textbox.Focus();
            //DataTable SavedAccount = new DataTable();
            //SavedAccount = SupportUtility.FindSavedAccount();
            //if(SavedAccount.Rows.Count>0)
            //{
            //    Name_textbox.Text = SavedAccount.Rows[0]["UserName"].ToString();
            //    Pass_textbox.Text = SavedAccount.Rows[0]["PassWord"].ToString();
            //    Save_checkbox.Checked = true;
            //}    
            //else
            //{
            //    Save_checkbox.Checked = false;
            //}    
            string UserNameSaved = "";
            string PassSave = "";
            SupportUtility.FindSavedAccount(ref UserNameSaved, ref PassSave);
            if(UserNameSaved != null)
            {
                Name_textbox.Text = UserNameSaved;
                Pass_textbox.Text = PassSave;
                Save_checkbox.Checked = true;
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
                    MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu sai","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Save_checkbox.Checked = false;
                }
            }
            else
            {
                //string dataSava = "";
                //DataTable savedAccount = SupportUtility.FindSavedAccount();
                //if(savedAccount.Rows.Count>0)
                //{
                //    SupportUtility.UnSaveAccount(savedAccount.Rows[0]["UserName"].ToString());
                //}                 
                SupportUtility.UnSaveAccount();
            }
            
        }

        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {
            Save_checkbox.Checked = false;
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();       
        }

        private void CheckInternet_timer_Tick(object sender, EventArgs e)
        {
            if (SupportUtility.IsConnectedToInternet())
            {
                parent.canRunTimer = true;
            }
            else
            {
                parent.canRunTimer = false;
                CheckInternet_timer.Enabled = false;
                DialogResult result = MessageBox.Show("Mất kết nói, nhấn \"OK \" để quay lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    if(inRoom != null)
                    {
                        parent.IsSignIn = inRoom.PlayerName;
                        using (StreamWriter sw = File.CreateText("SignInName.txt"))
                        {
                            sw.WriteLine(parent.IsSignIn);
                        }    
                        if(inRoom.room != null)
                        {

                            if(inRoom.room.check_timer != null)
                                inRoom.room.check_timer.Enabled = false;
                            if(inRoom.room.game != null)
                            {
                                if(inRoom.room.game.timer != null)
                                    inRoom.room.game.timer.Enabled = false;
                                if (inRoom.room.game.timer3 != null)
                                    inRoom.room.game.timer3.Enabled = false;
                                if (inRoom.room.game.timer2 != null)
                                    inRoom.room.game.timer2.Enabled = false;
                                inRoom.room.game.Dispose();
                            }
                            inRoom.room.Dispose();
                        }
                        inRoom.Dispose();
                    } 
                    else if(resetPass != null)
                    {
                        resetPass.Dispose();
                    }   
                    else if (signUpForm != null)
                    {
                        if(signUpForm.confirmNewAccount != null)
                        {
                            signUpForm.confirmNewAccount.Dispose();
                        }    
                        signUpForm.Dispose();
                    }    
                    parent.Show();
                    this.Dispose();
                }
            }
        }
    }
}
