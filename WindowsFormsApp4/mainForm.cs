using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace WindowsFormsApp4
{
    public partial class mainForm : Form
    {
        Timer timer;
        int effect1 = 0;
        int effect2 = 0;
        //thêm từ master
        public searchedWordList EV_SWlist = new searchedWordList();
        SqlConnection mycnt = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=StudyE;Integrated Security=True");
        public startForm parent;
        static int EVSource_Length;
        static int VESource_Length;
        //
        public mainForm()
        {
            InitializeComponent();
            guna2Panel_home.BringToFront();
            timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_tick);

        }
        private void timer_tick(object sender, EventArgs e)
        {
            //if (this.guna2Button_test.Size.Width < 500)
            //    this.guna2Button_User.Size = new System.Drawing.Size(this.guna2Button_test.Width + 80, 74);
            if (effect1 == 0 && effect2 == 0)
            {
                this.guna2Button_Game.Size = new System.Drawing.Size(5, 74);
                this.guna2Button_FlashCard.Size = new System.Drawing.Size(5, 74);
                this.guna2Button_User.Size = new System.Drawing.Size(5, 74);
                this.guna2Button_Location.Size = new System.Drawing.Size(5, 74);
            }
            if (effect1 < 5)
            {
                this.guna2Button_Game.Size = new System.Drawing.Size(this.guna2Button_Game.Width + 29, 74);
                this.guna2Button_FlashCard.Size = new System.Drawing.Size(this.guna2Button_FlashCard.Width + 29, 74);
                this.guna2Button_User.Size = new System.Drawing.Size(this.guna2Button_User.Width + 29, 74);
                effect1++;
            }
            if (effect2 < 5)
            {
                this.guna2Button_Location.Size = new System.Drawing.Size(this.guna2Button_Location.Width + 34, 74);
                effect2++;
            }
                if (effect1 >= 5 && effect2 >= 5 )
            {
                effect1 = effect2 = 0;
                timer.Enabled = false;
            }
        }
       
        private void Reset_Status_Button(object sender, EventArgs e)
        {
            if (sender == panel5 || sender == pictureBox_logo)
            {
                // TextBox s = sender as TextBox;
                guna2Button_Location.Text = "Home";
                this.guna2Button_Location.FillColor = System.Drawing.SystemColors.ActiveCaption;
                timer.Enabled = true;
            }
            else
            {
                this.guna2Button_Location.FillColor = System.Drawing.Color.MediumAquamarine;
            }
            if (sender != guna2Button_E_V)
            {
                guna2Button_E_V.ImageAlign = HorizontalAlignment.Left;
                this.guna2Button_E_V.ForeColor = System.Drawing.Color.White;
                this.guna2Button_E_V.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.guna2Button_E_V.FillColor = System.Drawing.Color.Transparent;

            }
            else guna2Button_Location.Text = guna2Button_E_V.Text;
                
            if (sender != guna2Button_V_E)
            {
                guna2Button_V_E.ImageAlign = HorizontalAlignment.Left;
                this.guna2Button_V_E.ForeColor = System.Drawing.Color.White;
                this.guna2Button_V_E.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.guna2Button_V_E.FillColor = System.Drawing.Color.Transparent;
            }
            else
            {
                guna2Button_Location.Text = guna2Button_V_E.Text;
            }
            if (sender != guna2Button_TraDoan)
            {
                guna2Button_TraDoan.ImageAlign = HorizontalAlignment.Left;
                this.guna2Button_TraDoan.ForeColor = System.Drawing.Color.White;
                this.guna2Button_TraDoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.guna2Button_TraDoan.FillColor = System.Drawing.Color.Transparent;

            }
            else guna2Button_Location.Text = guna2Button_TraDoan.Text;
            if (sender != guna2Button_TuKho)
            {
                guna2Button_TuKho.ImageAlign = HorizontalAlignment.Left;
                this.guna2Button_TuKho.ForeColor = System.Drawing.Color.White;
                this.guna2Button_TuKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.guna2Button_TuKho.FillColor = System.Drawing.Color.Transparent;             
            }
            else guna2Button_Location.Text = guna2Button_TuKho.Text;
            if (sender != guna2Button_DTBQT)
            {
                guna2Button_DTBQT.ImageAlign = HorizontalAlignment.Left;
                this.guna2Button_DTBQT.ForeColor = System.Drawing.Color.White;
                this.guna2Button_DTBQT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.guna2Button_DTBQT.FillColor = System.Drawing.Color.Transparent;
            }
            else guna2Button_Location.Text = guna2Button_DTBQT.Text; 
            
             
            if (sender != guna2Button_SearchedWord)
            {
                guna2Button_SearchedWord.ImageAlign = HorizontalAlignment.Left;
                this.guna2Button_SearchedWord.ForeColor = System.Drawing.Color.White;
                this.guna2Button_SearchedWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.guna2Button_SearchedWord.FillColor = System.Drawing.Color.Transparent;              
            }
            else guna2Button_Location.Text = guna2Button_SearchedWord.Text;

            if (sender != guna2Button_Add)
            {
                guna2Button_Add.ImageAlign = HorizontalAlignment.Left;
                this.guna2Button_Add.ForeColor = System.Drawing.Color.White;
                this.guna2Button_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.guna2Button_Add.FillColor = System.Drawing.Color.Transparent;
            }
            else guna2Button_Location.Text = guna2Button_Add.Text;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel_E_V.BringToFront();
            guna2Button_E_V.ImageAlign = HorizontalAlignment.Right;
            this.guna2Button_E_V.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_E_V.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_E_V.FillColor = System.Drawing.Color.White;
            Reset_Status_Button(sender, e);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel_V_E.BringToFront();
            guna2Button_V_E.ImageAlign = HorizontalAlignment.Right;
            this.guna2Button_V_E.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_V_E.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_V_E.FillColor = System.Drawing.Color.White;
            Reset_Status_Button(sender, e);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel_TraDoan.BringToFront();
            guna2Button_TraDoan.ImageAlign = HorizontalAlignment.Right;
            this.guna2Button_TraDoan.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_TraDoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_TraDoan.FillColor = System.Drawing.Color.White;
            Reset_Status_Button(sender, e);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel_TuKho.BringToFront();
            guna2Button_TuKho.ImageAlign = HorizontalAlignment.Right;
            this.guna2Button_TuKho.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_TuKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_TuKho.FillColor = System.Drawing.Color.White;
            Reset_Status_Button(sender, e);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel_DTBQT.BringToFront();
            guna2Button_DTBQT.ImageAlign = HorizontalAlignment.Right;
            this.guna2Button_DTBQT.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_DTBQT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_DTBQT.FillColor = System.Drawing.Color.White;
            Reset_Status_Button(sender, e);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Panel_SearchedWord.BringToFront();
            guna2Button_SearchedWord.ImageAlign = HorizontalAlignment.Right;
            this.guna2Button_SearchedWord.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_SearchedWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_SearchedWord.FillColor = System.Drawing.Color.White;
            Reset_Status_Button(sender, e);
        }

       

        private void panel5_Click(object sender, EventArgs e)
        {
            Reset_Status_Button(sender, e);
            guna2Panel_home.BringToFront();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset_Status_Button(sender, e);
            guna2Panel_home.BringToFront();
            



        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button_Add_Click(object sender, EventArgs e)
        {
            //guna2Button_test.Visible = true;
            //guna2Button_User.Visible = false;
            //guna2Button_FlashCard.Visible = false;
            //guna2Button_Game.Visible = false;
            //timer.Enabled = true;
            guna2Panel_Add.BringToFront();
            guna2Button_Add.ImageAlign = HorizontalAlignment.Right;
            this.guna2Button_Add.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_Add.FillColor = System.Drawing.Color.White;
            Reset_Status_Button(sender, e);
        }





        public mainForm(startForm parent)
        {
            this.parent = parent;
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_tick);
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            //Load dữ liệu
            string sql = "select * from DTBQT";
            ketnoicsdl(sql);
            DataManager.Instance.LoadSWToList(EV_SWlist);
            //
            isDichDoanRadio.Checked = true;
        }
        private void ketnoicsdl(string sql)
        {
            mycnt.Open();
            // lay het du lieu trong bang DTBQT
            SqlCommand com = new SqlCommand(sql, mycnt); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            mycnt.Close();  // đóng kết nối
            dataGridView5.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void ConnectDatabseEV()
        {
            mycnt.Open(); // mo ket noi 
            if (textBox1.Text == "")
            {
                // kiểm tra exception
                resultBox1.Text = "Vui lòng nhập từ cần tra !!";
                mycnt.Close();
                return;
            }
            string search = "select * from EV_SOURCE where Name = '" + textBox1.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(search, mycnt); // truy van cau lenh vao sql
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            if (dt.Rows.Count > 0)
            {
                Design_UI_Word_EV(dt.Rows[0]["Meaning"].ToString().Trim());
                DataManager.Instance.InsertWordToSearchedTable(dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim(), 1);
                // Them tu vao class tu EV da tra
                EV_SWlist.list.Add(new Word(Convert.ToInt32(dt.Rows[0]["ID"].ToString().Trim()), dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim()));
            }
            else
            {
                resultBox1.Text = "Không có dữ liệu hjhj :>>";
            }

            //textBox1.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug
            
            mycnt.Close(); // đóng kết nối
        }
        private void ConnectDatabseVE()
        {
            mycnt.Open(); // mo ket noi 

            if (textBox2.Text == "")
            {
                resultBox2.Text = "Vui lòng nhập từ cần tra !!";
                mycnt.Close();
                return;
            }

            string search2 = "select * from VE_SOURCE where Name = N'@" + textBox2.Text.Trim() + "'";
            SqlCommand com2 = new SqlCommand(search2, mycnt); // truy van cau lenh vao sql
            //com.CommandType = CommandType.Text;
            SqlDataAdapter ada2 = new SqlDataAdapter(com2); // chuyen data tu sql ve trong ada2
            DataTable dt2 = new DataTable();
            ada2.Fill(dt2); // do data tu ada2 va0 dt2

            if (dt2.Rows.Count > 0)
            {
                // Thuc hien chuyen string tu database sang dang form tieu chuan (Viet - Anh)
                Design_UI_Word_VE(dt2.Rows[0]["Meaning"].ToString().Trim());
                DataManager.Instance.InsertWordToSearchedTable(dt2.Rows[0]["Name"].ToString().Trim(), dt2.Rows[0]["Meaning"].ToString().Trim(), 0);
            }
            else
            {
                resultBox2.Text = "Không có dữ liệu :>>";
            }
            //textBox2.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug
            mycnt.Close(); // đóng kết nối
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = !button5.Enabled;
            string sql;
            if (textBox5.Text == "") sql = "select * from DTBQT";
            else
                sql = "select * from DTBQT where NGUYENMAU = '" + textBox5.Text.Trim() + "' or QUAKHUDON = '" + textBox5.Text.Trim() + "' or QUAKHUPHANTU = '" + textBox5.Text.Trim() + "'";
            ketnoicsdl(sql);
            //textBox5.Text = "";
            button5.Enabled = !button5.Enabled;
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button5_Click(sender, e);
            }
        }
        public void Design_UI_Word_VE(string temp)
        {

            string[] lines = temp.Split('|');
            // show_lines là chuỗi result 
            string show_line = "";
            // lưu chuỗi để thực hiện các tao thác tách và xét 
            string fix_lines;
            for (int i = 1; i < lines.Length; i++)
            {
                fix_lines = lines[i];
                // Tác chuỗi lấy từ vị trí thứ 1 trong chuỗi ( ý nghĩa là tách các kí tự phân định design @ * - = ra khỏi chuỗi )
                fix_lines = fix_lines.Substring(1);
                if (lines[i][0] == '*')
                {
                    show_line += fix_lines.Trim();
                }
                else if (lines[i][0] == '-')
                {
                    show_line += "\r\n" + "\t" + "*" + fix_lines.Trim();
                }
                else if (lines[i][0] == '=')
                {

                    show_line += "\r\n" + "\t\t" + "-" + fix_lines.Trim();
                }
                else if (lines[i][0] == '+')
                {
                    show_line += ":" + fix_lines.Trim();
                }

            }
            // xuất ra ngoài 
            resultBox2.Text = show_line.Trim();
        }
        public void Design_UI_Word_EV(string temp)
        {

            string[] lines = temp.Split('|');
            string show_line = "";
            string fix_lines;
            for (int i = 1; i < lines.Length; i++)
            {
                fix_lines = lines[i];
                fix_lines = fix_lines.Substring(1);
                if (lines[i][0] == '@')
                {
                    show_line += fix_lines.Trim();
                }
                else if (lines[i][0] == '*')
                {

                    show_line += "\r\n" + "\t" + fix_lines.Trim();
                }
                else if (lines[i][0] == '-')
                {

                    show_line += "\r\n" + "\t\t" + "*" + fix_lines.Trim();
                }
                else if (lines[i][0] == '=')
                {

                    show_line += "\r\n" + "\t\t\t" + "-" + fix_lines.Trim();
                }
                else if (lines[i][0] == '+')
                {
                    show_line += ":" + fix_lines.Trim();
                }
            }
            resultBox1.Text = show_line.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = !button1.Enabled;
            ConnectDatabseEV();
            button1.Enabled = !button1.Enabled;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = !button2.Enabled;
            ConnectDatabseVE();
            button2.Enabled = !button2.Enabled;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2_Click(sender, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox6_1.SelectedItem == null || comboBox6_2.SelectedItem == null || textBox6.Text == "" || textBox6_3.Text == "" || textBox6_3.Text == "Nhập Nghĩa Của Từ" || textBox6.Text == "Nhập Tên Từ")
            {
                MessageBox.Show("Bạn đã chưa điền hoặc chọn thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox6_2.SelectedItem.ToString() == "Other" && textBox6_2.Text == "")
            {
                MessageBox.Show("Bạn đã chưa điền hoặc chọn thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (textBox6_2.Visible == true)
                {
                    textBox6_2.Visible = !textBox6_2.Visible;
                }
            }
            else
            {
                /// Updata Id cho từ mới
                DataManager.Instance.UpdateIDForData(out EVSource_Length, out VESource_Length);
                int rowCount;

                /// thêm từ Việt - Anh
                if (comboBox6_1.SelectedItem.ToString() == "Việt - Anh")
                {
                    mycnt.Open();
                    string search2 = "select * from VE_SOURCE where Name = '@" + textBox6.Text.Trim() + "'";
                    SqlCommand com2 = new SqlCommand(search2, mycnt);
                    SqlDataAdapter ada = new SqlDataAdapter(com2); // chuyen data tu sql ve trong ada
                    DataTable dt3 = new DataTable();
                    ada.Fill(dt3);
                    if (dt3.Rows.Count > 0)
                    {
                        MessageBox.Show("Từ bạn thêm đã có trong dữ liệu!");
                        if (textBox6_2.Visible == true)
                        {
                            textBox6_2.Visible = !textBox6_2.Visible;
                        }
                    }
                    else
                    {

                        VESource_Length++;
                        if (comboBox6_2.SelectedItem.ToString() == "Khác")
                        {
                            search2 = "INSERT INTO VE_SOURCE (ID,Name,Meaning) VALUES (" + VESource_Length.ToString().Trim() + ",N'@" + textBox6.Text + "',N'|*" + textBox6_2.Text + "|-" + textBox6_3.Text + "')";
                            SqlCommand com4 = new SqlCommand(search2, mycnt);
                            rowCount = com4.ExecuteNonQuery();
                            textBox6_2.Visible = !textBox6_2.Visible;
                        }
                        else
                        {
                            search2 = "INSERT INTO VE_SOURCE (ID,Name,Meaning) VALUES (" + VESource_Length.ToString().Trim() + ",N'@" + textBox6.Text + "',N'|*" + comboBox6_2.SelectedItem.ToString().Trim() + "|-" + textBox6_3.Text + "')";
                            SqlCommand com4 = new SqlCommand(search2, mycnt);
                            rowCount = com4.ExecuteNonQuery();
                        }
                        MessageBox.Show("Từ bạn vừa nhập đã được thêm");
                    }
                    textBox6.Text = textBox6_2.Text = textBox6_3.Text = "";
                    comboBox6_2.SelectedItem = comboBox6_2.Items[0];
                    mycnt.Close();


                }
                ////  Thêm từ Anh - việt
                else if (comboBox6_1.SelectedItem.ToString() == "Anh - Việt")
                {
                    mycnt.Open();
                    string search = "select * from EV_SOURCE where Name = '" + textBox6.Text.Trim() + "'";
                    SqlCommand com = new SqlCommand(search, mycnt);
                    SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
                    DataTable dt4 = new DataTable();
                    ada.Fill(dt4);
                    if (dt4.Rows.Count > 0)
                    {
                        MessageBox.Show("Từ bạn thêm đã có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (textBox6_2.Visible == true)
                        {
                            textBox6_2.Visible = !textBox6_2.Visible;
                        }
                    }
                    else
                    {
                        EVSource_Length++;
                        if (comboBox6_2.SelectedItem.ToString() == "Other")
                        {
                            search = "INSERT INTO EV_SOURCE (ID,Name,Meaning) VALUES (" + EVSource_Length.ToString().Trim() + ",'" + textBox6.Text + "',N'|*" + textBox6_2.Text + "|-" + textBox6_3.Text + "')";
                            SqlCommand com3 = new SqlCommand(search, mycnt);
                            rowCount = com3.ExecuteNonQuery();
                            textBox6_2.Visible = !textBox6_2.Visible;
                        }
                        else
                        {
                            search = "INSERT INTO EV_SOURCE (ID,Name,Meaning) VALUES (" + EVSource_Length.ToString().Trim() + ",'" + textBox6.Text + "',N'|*" + comboBox6_2.SelectedItem.ToString().Trim() + "|-" + textBox6_3.Text + "')";
                            SqlCommand com3 = new SqlCommand(search, mycnt);
                            rowCount = com3.ExecuteNonQuery();
                        }
                        MessageBox.Show("Từ bạn vừa nhập đã được thêm", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBox6.Text = textBox6_2.Text = textBox6_3.Text = "";
                    comboBox6_2.SelectedItem = comboBox6_2.Items[0];
                    mycnt.Close();
                }
            }

        }

        private void comboBox6_2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox6_2.SelectedItem.ToString() == "Other" || comboBox6_2.SelectedItem.ToString() == "Khác")
            {
                string message = "Bạn vừa chọn phân loại từ Other ! Vui lòng nhập vào ô bên cạnh";
                string title = "Thông báo";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox6_2.Visible = !textBox6_2.Visible;
            }
            else
            {
                return;
            }
        }

        private void comboBox6_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6_1.SelectedItem.ToString() == "Anh - Việt")
            {
                comboBox6_2.Items.Clear();
                string[] EV_WordType = new string[] { "Verb", "Noun", "Adj", "Adv", "Other" };
                comboBox6_2.Items.AddRange(EV_WordType);
                comboBox6_2.SelectedItem = comboBox6_2.Items[0];
                if (textBox6_2.Visible == true)
                {
                    textBox6_2.Visible = !textBox6_2.Visible;
                }
            }
            else if (comboBox6_1.SelectedItem.ToString() == "Việt - Anh")
            {
                comboBox6_2.Items.Clear();
                string[] VE_WordType = new string[] { "Động Từ", "Danh Từ", "Tính Từ", "Trạng Từ", "Khác" };
                comboBox6_2.Items.AddRange(VE_WordType);
                comboBox6_2.SelectedItem = comboBox6_2.Items[0];
                if (textBox6_2.Visible == true)
                {
                    textBox6_2.Visible = !textBox6_2.Visible;
                }
            }
        }

        private void textBox6_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button6_Click(sender, e);
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Nhập Tên Từ")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
            else
            {
                textBox6.ForeColor = Color.Black;
            }

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Nhập Tên Từ";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox6_3_Leave(object sender, EventArgs e)
        {
            if (textBox6_3.Text == "")
            {
                textBox6_3.Text = "Nhập Nghĩa Của Từ";
                textBox6_3.ForeColor = Color.Gray;
            }
        }

        private void textBox6_3_Enter(object sender, EventArgs e)
        {
            if (textBox6_3.Text == "Nhập Nghĩa Của Từ")
            {
                textBox6_3.Text = "";
                textBox6_3.ForeColor = Color.Black;
            }
            else
            {
                textBox6_3.ForeColor = Color.Black;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập Từ Cần Tra")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nhập Từ Cần Tra";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nhập Từ Cần Tra")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
            else
            {
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nhập Từ Cần Tra";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.Instance.Upload_Searched_Word(comboBox4.SelectedItem.ToString(), dataGridView4);
        }

        private void button3_2_Click(object sender, EventArgs e)
        {
            //if (label3_1.Text != "")
            //{
            //    if (MessageBox.Show("Chương trình sẽ dịch tự động loại bỏ dấu bạn có đồng ý không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            //    {
            //        return;
            //    }
            //}
            string paragraph = richTextBox3.Text;
            paragraph = paragraph.ToLower();
            paragraph = DataManager.Instance.RemoveUnicode(paragraph);
            paragraph = DataManager.Instance.RemoveSpecialCharacters(ref paragraph);
            paragraph = paragraph.Replace("\n", " ");
            string[] processedParagraph = paragraph.Split(' ');
            DataManager.Instance.TranslateParagraph(processedParagraph, dataGridView3, ref EV_SWlist);


            string strTranslatedText = null;
            try
            {
                Translator.LanguageServiceClient client = new Translator.LanguageServiceClient();
                client = new Translator.LanguageServiceClient();
                strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", richTextBox3.Text, "", "vi");
                resultForTranslator.Text = strTranslatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Plain text (*.txt)| *.txt";
            try
            {
                if (openFileDialog3.ShowDialog() == DialogResult.OK)
                {
                    //Stream stream = openFileDialog3.OpenFile();
                    //StreamReader sr = new StreamReader(stream);
                    //richTextBox3.Text = sr.ReadToEnd();
                    //sr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                string message = "Không thể đọc File !";
                string title = "Thông báo";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                supportForm support = new supportForm(this, this.dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
                support.Show();
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            //if (richTextBox3.Text == "") dataGridView3.Rows.Clear();
            //string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            // "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ","0","1","2","3","4","5","6","7","8","9",};
            //int n = richTextBox3.TextLength;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (richTextBox3.Text.IndexOf(arr1[i]) != -1)
            //    {
            //        label3_1.Text = "Bạn vừa nhập chuỗi có dấu hoặc có số. Vui lòng kiểm tra hoặc chúng tôi sẽ thực hiện chuyển kiểu tự động khi bạn thực hiện dịch đoạn !";
            //        label3_1.ForeColor = Color.Red;
            //        return;
            //    }
            //}

            //label3_1.Text = "";
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            // "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ","0","1","2","3","4","5","6","7","8","9",};
            //int n = textBox1.TextLength;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (textBox1.Text.IndexOf(arr1[i]) != -1)
            //    {
            //        label1_1.Text = "Bạn vừa nhập chuỗi có dấu hoặc có số. Vui lòng kiểm tra hoặc chúng tôi sẽ thực hiện chuyển kiểu tự động khi bạn thực hiện dịch đoạn !";
            //        label1_1.ForeColor = Color.Red;
            //        return;
            //    }
            //}

            //label1_1.Text = "";

            mycnt.Open(); // mo ket noi 
            if (textBox1.Text == "")
            {
                mycnt.Close();
                return;
            }
            else
            {
                string search = "select top(10) * from EV_SOURCE where Name like '" + textBox1.Text.Trim() + "%'";
                SqlCommand com = new SqlCommand(search, mycnt); // truy van cau lenh vao sql
                SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
                DataTable dt = new DataTable();
                ada.Fill(dt); // do data tu ada va dt
                mycnt.Close(); // đóng kết nối
                textBox1.AutoCompleteCustomSource.Clear();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        textBox1.AutoCompleteCustomSource.Add(dt.Rows[i]["Name"].ToString());
                    textBox1.TextChanged -= textBox1_TextChanged;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //string[] arr1 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", };
            //int n = textBox2.TextLength;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (textBox2.Text.IndexOf(arr1[i]) != -1)
            //    {
            //        label2_1.Text = "Bạn vừa nhập chuỗi có số. Vui lòng kiểm tra !";
            //        label2_1.ForeColor = Color.Red;
            //        if (button2.Enabled == true) button2.Enabled = !button2.Enabled;
            //        return;
            //    }
            //}
            //if (button2.Enabled == false) button2.Enabled = !button2.Enabled;
            //label2_1.Text = "";

            mycnt.Open(); // mo ket noi 
            if (textBox2.Text == "")
            {
                mycnt.Close();
                return;
            }
            else
            {
                string search = "select top(10) * from VE_SOURCE where Name like N'@" + textBox2.Text.Trim() + "%'";
                SqlCommand com = new SqlCommand(search, mycnt); // truy van cau lenh vao sql
                SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
                DataTable dt = new DataTable();
                ada.Fill(dt); // do data tu ada va dt
                mycnt.Close(); // đóng kết nối
                textBox2.AutoCompleteCustomSource.Clear();
                string s;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        s = dt.Rows[i]["Name"].ToString();
                        s = s.Remove(0, 1);
                        textBox2.AutoCompleteCustomSource.Add(s);
                    }
                    textBox2.TextChanged -= textBox2_TextChanged;
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar == (char)Keys.Back)
                textBox1.TextChanged += textBox1_TextChanged;
        }
        private void speak_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = richTextBox3_1.Text;
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(text);
        }

        private void speak5_Click(object sender, EventArgs e)
        {
            string text = dataGridView5.CurrentCell.Value.ToString();
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar == (char)Keys.Back)
                textBox2.TextChanged += textBox2_TextChanged;
        }

        private void guna2Button_Game_Click(object sender, EventArgs e)
        {
            startGameForm a = new startGameForm();
            this.Close();
            a.Show();
        }

        private void Translator_Mode(object sender, EventArgs e)
        {
            if(isDichDoanRadio.Checked)
            {
                isTraDoanRadio.Checked = false;
                resultForTranslator.BringToFront();
            }
            else
            {
                isDichDoanRadio.Checked = false;
                dataGridView3.BringToFront();
            }
        }    
    }
}
