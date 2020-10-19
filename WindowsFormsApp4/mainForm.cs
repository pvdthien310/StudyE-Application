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

namespace WindowsFormsApp4
{
    public partial class mainForm : Form
    {
        SqlConnection mycntVE = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=VESource;Integrated Security=True");
        SqlConnection mycntEV = new SqlConnection(@"Data Source=DESKTOP-DEE9DN8;Initial Catalog=EVSource;Integrated Security=True");
        public startForm parent;
        static int EVSource_Length;
        static int VESource_Length;
        public mainForm()
        {
            InitializeComponent();
        }
        public mainForm(startForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
       
        /// <summary>
        /// // Thien code 
        /// </summary>
        /// 
        private void ConnectDatabseEV()
        {
            mycntEV.Open(); // mo ket noi 
            if (textBox1.Text == "")
            {
                // kiểm tra exception
                resultBox1.Text = "Vui lòng nhập từ cần tra !!";
                mycntEV.Close();
                return;
            }
            string search = "select * from TableSource1 where Name = '" + textBox1.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(search, mycntEV); // truy van cau lenh vao sql
            //com.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
            DataTable dt = new DataTable();
            ada.Fill(dt); // do data tu ada va dt
            if (dt.Rows.Count > 0)
            {
                Design_UI_Word_EV(dt.Rows[0]["Meaning"].ToString().Trim());


                // Thuc hien chuyen string tu database sang dang form tieu chuan (Viet - Anh)
                //Design_UI_Word_VE(dt.Rows[0]["Meaning"].ToString().Trim());

               // DataManager.Instance.InsertWordToSearchedTable(dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim(), 1);

                //word = dt.Rows[0]["Meaning"].ToString().Trim();
                //textBox1.Text = dt.Rows[1]["Meaning"].ToString().Trim();
            }
            else
            {
                resultBox1.Text = "Không có dữ liệu hjhj :>>";
            }
            textBox1.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug


            mycntEV.Close(); // đóng kết nối

        }
        private void ConnectDatabseVE()
        {
            mycntVE.Open(); // mo ket noi 

            if (textBox2.Text == "")
            {
                resultBox2.Text = "Vui lòng nhập từ cần tra !!";
                mycntVE.Close();
                return;
            }

            string search2 = "select * from TableData where Name = N'@" + textBox2.Text.Trim() + "'";
            SqlCommand com2 = new SqlCommand(search2, mycntVE); // truy van cau lenh vao sql
            //com.CommandType = CommandType.Text;
            SqlDataAdapter ada2 = new SqlDataAdapter(com2); // chuyen data tu sql ve trong ada2
            DataTable dt2 = new DataTable();
            ada2.Fill(dt2); // do data tu ada2 va0 dt2
            
            if (dt2.Rows.Count > 0)
            {
                // Thuc hien chuyen string tu database sang dang form tieu chuan (Viet - Anh)
                Design_UI_Word_VE(dt2.Rows[0]["Meaning"].ToString().Trim());
               // DataManager.Instance.InsertWordToSearchedTable(dt2.Rows[0]["Name"].ToString().Trim(), dt2.Rows[0]["Meaning"].ToString().Trim(), 0);
                //word = dt.Rows[0]["Meaning"].ToString().Trim();
                //textBox1.Text = dt.Rows[1]["Meaning"].ToString().Trim();
            }
            else
            {
               resultBox2.Text = "Không có dữ liệu :>>";
            }
            textBox2.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug


            mycntVE.Close(); // đóng kết nối

        }

        private void Design_UI_Word_VE(string temp)
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
        private void Design_UI_Word_EV(string temp)
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
//<<<<<<< HEAD
            button1.Enabled = !button1.Enabled;
            ConnectDatabseEV();
            button1.Enabled = !button1.Enabled;
        }
        private void button2_Click(object sender, EventArgs e)
        {
//<<<<<<< HEAD
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
                    mycntVE.Open();
                    string search2 = "select * from TableData where Name = '@" + textBox6.Text.Trim() + "'";
                    SqlCommand com2 = new SqlCommand(search2, mycntVE);
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
                            search2 = "INSERT INTO TableData (ID,Name,Meaning) VALUES (" + VESource_Length.ToString().Trim() + ",N'@" + textBox6.Text + "',N'|*" + textBox6_2.Text + "|-" + textBox6_3.Text + "')";
                            SqlCommand com4 = new SqlCommand(search2, mycntVE);
                            rowCount = com4.ExecuteNonQuery();
                            textBox6_2.Visible = !textBox6_2.Visible;
                        }
                        else
                        {
                            search2 = "INSERT INTO TableData (ID,Name,Meaning) VALUES (" + VESource_Length.ToString().Trim() + ",N'@" + textBox6.Text + "',N'|*" + comboBox6_2.SelectedItem.ToString().Trim() + "|-" + textBox6_3.Text + "')";
                            SqlCommand com4 = new SqlCommand(search2, mycntVE);
                            rowCount = com4.ExecuteNonQuery();
                        }
                        MessageBox.Show("Từ bạn vừa nhập đã được thêm");
                    }
                    textBox6.Text = textBox6_2.Text = textBox6_3.Text = "";
                    comboBox6_2.SelectedItem = comboBox6_2.Items[0];
                    mycntVE.Close();


                }
                ////  Thêm từ Anh - việt
                else if (comboBox6_1.SelectedItem.ToString() == "Anh - Việt")
                {
                    mycntEV.Open();
                    string search = "select * from TableSource1 where Name = '" + textBox6.Text.Trim() + "'";
                    SqlCommand com = new SqlCommand(search, mycntEV);
                    SqlDataAdapter ada = new SqlDataAdapter(com); // chuyen data tu sql ve trong ada
                    DataTable dt4 = new DataTable();
                    ada.Fill(dt4);
                    if (dt4.Rows.Count > 0)
                    {
                        MessageBox.Show("Từ bạn thêm đã có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        EVSource_Length++;
                        if (comboBox6_2.SelectedItem.ToString() == "Other")
                        {
                            search = "INSERT INTO TableSource1 (ID,Name,Meaning) VALUES (" + EVSource_Length.ToString().Trim() + ",'" + textBox6.Text + "',N'|*" + textBox6_2.Text + "|-" + textBox6_3.Text + "')";
                            SqlCommand com3 = new SqlCommand(search, mycntEV);
                            rowCount = com3.ExecuteNonQuery();
                            textBox6_2.Visible = !textBox6_2.Visible;
                        }
                        else
                        {
                            search = "INSERT INTO TableSource1 (ID,Name,Meaning) VALUES (" + EVSource_Length.ToString().Trim() + ",'" + textBox6.Text + "',N'|*" + comboBox6_2.SelectedItem.ToString().Trim() + "|-" + textBox6_3.Text + "')";
                            SqlCommand com3 = new SqlCommand(search, mycntEV);
                            rowCount = com3.ExecuteNonQuery();
                            //com.CommandType = CommandType.Text;
                        }
                        MessageBox.Show("Từ bạn vừa nhập đã được thêm","Thông báo !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    textBox6.Text = textBox6_2.Text = textBox6_3.Text = "";
                    mycntEV.Close();
                    /* mycntEV.Dispose();*/ // Giai phong tai nguyen
                }
            }

        }

        private void comboBox6_2_SelectedValueChanged(object sender, EventArgs e)
        { 
            if (comboBox6_2.SelectedItem.ToString() == "Other" || comboBox6_2.SelectedItem.ToString() == "Khác")
            {
                string message = "Bạn vừa chọn phân loại từ Other ! Vui lòng nhập vào ô bên cạnh";
                string title = "Thông báo";
                MessageBox.Show(message, title,MessageBoxButtons.OK,MessageBoxIcon.Information);

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
                string[] EV_WordType = new string[] { "Verb", "Noun", "Adj","Adv","Other" };
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
                string[] VE_WordType = new string[] { "Động Từ", "Danh Từ", "Tính Từ","Trạng Từ","Khác" };
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

        /// <summary>
        /// // Thien code end
        /// </summary>
    }
}
