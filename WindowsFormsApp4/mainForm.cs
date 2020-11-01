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
using System.IO;
using System.Speech.Synthesis;

namespace WindowsFormsApp4
{
    public partial class mainForm : Form
    {
        public searchedWordList EV_SWlist = new searchedWordList();
        SqlConnection mycntVE = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
        SqlConnection mycntEV = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
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
        //thuc code
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-U08OQS9D\SQLEXPRESS;Initial Catalog=StudyE;Integrated Security=True");
        private void ketnoicsdl(string sql)
        {
            cnn.Open();
              // lay het du lieu trong bang DTBQT
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView5.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("  dfd ");
            string sql = "select * from DTBQT";
            ketnoicsdl(sql);

            // Đổ dữ liệu vào class SearchedWord 
            
            //searchedWordList VE_SWlist = new searchedWordList();
            DataManager.Instance.LoadSWToList(EV_SWlist);
            //DataManager.Instance.LoadSWToList(VE_SWlist);

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
                DataManager.Instance.InsertWordToSearchedTable(dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim(), 1);
                // Them tu vao class tu EV da tra
                EV_SWlist.list.Add(new Word(Convert.ToInt32(dt.Rows[0]["ID"].ToString().Trim()),dt.Rows[0]["Name"].ToString().Trim(), dt.Rows[0]["Meaning"].ToString().Trim()));
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
                DataManager.Instance.InsertWordToSearchedTable(dt2.Rows[0]["Name"].ToString().Trim(), dt2.Rows[0]["Meaning"].ToString().Trim(), 0);
            }
            else
            {
               resultBox2.Text = "Không có dữ liệu :>>";
            }
            textBox2.Clear(); // Xóa từ cũ tránh trường hợp bị đùn gây bug


            mycntVE.Close(); // đóng kết nối
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = !button5.Enabled;
            string sql = "select * from DTBQT where NGUYENMAU = '" + textBox5.Text.Trim() + "' or QUAKHUDON = '" + textBox5.Text.Trim() + "' or QUAKHUPHANTU = '" + textBox5.Text.Trim() + "'";
            ketnoicsdl(sql);
            textBox5.Text = "";
            button5.Enabled = !button5.Enabled;
        }


        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
        	if (e.KeyCode == Keys.Enter)
            {
                this.button5_Click(sender, e);
            }
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
                    comboBox6_2.SelectedItem = comboBox6_2.Items[0];
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

        private void button3_2_Click(object sender, EventArgs e)
        {
            if (label3_1.Text != "")
            {
                if (MessageBox.Show("Chương trình sẽ dịch tự động loại bỏ dấu bạn có đồng ý không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
             }
            string paragraph = richTextBox3.Text;
            paragraph = paragraph.ToLower();
            paragraph = DataManager.Instance.RemoveUnicode(paragraph);
            paragraph = DataManager.Instance.RemoveSpecialCharacters(ref paragraph);
            paragraph = paragraph.Replace("\n"," ");
            string[] processedParagraph = paragraph.Split(' ');
            DataManager.Instance.TranslateParagraph(processedParagraph, dataGridView3,ref EV_SWlist);

        }

        private void TraDoanTab_Leave(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            dataGridView3.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Plain text (*.txt)| *.txt";
            try
            {
                if (openFileDialog3.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = openFileDialog3.OpenFile();
                    StreamReader sr = new StreamReader(stream);
                    richTextBox3.Text = sr.ReadToEnd();
                    sr.Close();
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
            if (richTextBox3.Text == "") dataGridView3.Rows.Clear();
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
             "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ","0","1","2","3","4","5","6","7","8","9",};
            int n = richTextBox3.TextLength;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (richTextBox3.Text.IndexOf(arr1[i]) != -1)
                {
                    label3_1.Text = "Bạn vừa nhập chuỗi có dấu hoặc có số. Vui lòng kiểm tra hoặc chúng tôi sẽ thực hiện chuyển kiểu tự động khi bạn thực hiện dịch đoạn !";
                    label3_1.ForeColor = Color.Red;
                    return;
                }
            }

            label3_1.Text = "";
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
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
             "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ","0","1","2","3","4","5","6","7","8","9",};
            int n = textBox1.TextLength;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (textBox1.Text.IndexOf(arr1[i]) != -1)
                {
                    label1_1.Text = "Bạn vừa nhập chuỗi có dấu hoặc có số. Vui lòng kiểm tra hoặc chúng tôi sẽ thực hiện chuyển kiểu tự động khi bạn thực hiện dịch đoạn !";
                    label1_1.ForeColor = Color.Red;
                    return;
                }
            }

            label1_1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string[] arr1 = new string[] {"0","1","2","3","4","5","6","7","8","9",};
            int n = textBox2.TextLength;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (textBox2.Text.IndexOf(arr1[i]) != -1)
                {
                    label2_1.Text = "Bạn vừa nhập chuỗi có số. Vui lòng kiểm tra !";
                    label2_1.ForeColor = Color.Red;
                    if (button2.Enabled == true) button2.Enabled = !button2.Enabled;
                    return;
                }
            }
            if (button2.Enabled == false) button2.Enabled = !button2.Enabled;
            label2_1.Text = "";
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
            string text = richTextBox3.Text;
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

        /// <summary>
        /// // Thien code end
        /// </summary>
    }
}
