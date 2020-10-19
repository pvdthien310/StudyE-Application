namespace WindowsFormsApp4
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.VietAnhTab = new System.Windows.Forms.TabControl();
            this.AnhVietTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TraDoanTab = new System.Windows.Forms.TabPage();
            this.TuDaTra = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.TuBatQuyTacTab = new System.Windows.Forms.TabPage();
            this.ThemTuMoiTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox6_1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6_3 = new System.Windows.Forms.TextBox();
            this.textBox6_2 = new System.Windows.Forms.TextBox();
            this.comboBox6_2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.VietAnhTab.SuspendLayout();
            this.AnhVietTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TuDaTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.TuBatQuyTacTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ThemTuMoiTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // VietAnhTab
            // 
            this.VietAnhTab.AllowDrop = true;
            this.VietAnhTab.Controls.Add(this.AnhVietTab);
            this.VietAnhTab.Controls.Add(this.tabPage2);
            this.VietAnhTab.Controls.Add(this.TraDoanTab);
            this.VietAnhTab.Controls.Add(this.TuDaTra);
            this.VietAnhTab.Controls.Add(this.TuBatQuyTacTab);
            this.VietAnhTab.Controls.Add(this.ThemTuMoiTab);
            this.VietAnhTab.ItemSize = new System.Drawing.Size(132, 18);
            this.VietAnhTab.Location = new System.Drawing.Point(1, 1);
            this.VietAnhTab.Name = "VietAnhTab";
            this.VietAnhTab.SelectedIndex = 0;
            this.VietAnhTab.Size = new System.Drawing.Size(796, 450);
            this.VietAnhTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.VietAnhTab.TabIndex = 0;
            // 
            // AnhVietTab
            // 
            this.AnhVietTab.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.hinh_nen_dep_cho_laptop_1366x768_1;
            this.AnhVietTab.Controls.Add(this.label1);
            this.AnhVietTab.Controls.Add(this.resultBox1);
            this.AnhVietTab.Controls.Add(this.textBox1);
            this.AnhVietTab.Controls.Add(this.button1);
            this.AnhVietTab.Location = new System.Drawing.Point(4, 22);
            this.AnhVietTab.Name = "AnhVietTab";
            this.AnhVietTab.Padding = new System.Windows.Forms.Padding(3);
            this.AnhVietTab.Size = new System.Drawing.Size(788, 424);
            this.AnhVietTab.TabIndex = 0;
            this.AnhVietTab.Text = "Anh -  Việt";
            this.AnhVietTab.ToolTipText = " ";
            this.AnhVietTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(101, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ cần tra ";
            // 
            // resultBox1
            // 
            this.resultBox1.BackColor = System.Drawing.Color.White;
            this.resultBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.resultBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.resultBox1.Location = new System.Drawing.Point(77, 129);
            this.resultBox1.Multiline = true;
            this.resultBox1.Name = "resultBox1";
            this.resultBox1.ReadOnly = true;
            this.resultBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox1.Size = new System.Drawing.Size(643, 292);
            this.resultBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(233, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Nhập Từ Cần Tra";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.hinh_nen_dep_cho_laptop_1366x768_1;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.resultBox2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Việt - Anh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(101, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ cần tra ";
            // 
            // resultBox2
            // 
            this.resultBox2.BackColor = System.Drawing.Color.White;
            this.resultBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.resultBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.resultBox2.Location = new System.Drawing.Point(77, 129);
            this.resultBox2.Multiline = true;
            this.resultBox2.Name = "resultBox2";
            this.resultBox2.ReadOnly = true;
            this.resultBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox2.Size = new System.Drawing.Size(643, 292);
            this.resultBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(233, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 28);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Nhập Từ Cần Tra";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TraDoanTab
            // 
            this.TraDoanTab.Location = new System.Drawing.Point(4, 22);
            this.TraDoanTab.Name = "TraDoanTab";
            this.TraDoanTab.Padding = new System.Windows.Forms.Padding(3);
            this.TraDoanTab.Size = new System.Drawing.Size(788, 424);
            this.TraDoanTab.TabIndex = 2;
            this.TraDoanTab.Text = "Tra đoạn";
            this.TraDoanTab.UseVisualStyleBackColor = true;
            // 
            // TuDaTra
            // 
            this.TuDaTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TuDaTra.Controls.Add(this.comboBox4);
            this.TuDaTra.Controls.Add(this.dataGridView4);
            this.TuDaTra.Location = new System.Drawing.Point(4, 22);
            this.TuDaTra.Name = "TuDaTra";
            this.TuDaTra.Padding = new System.Windows.Forms.Padding(3);
            this.TuDaTra.Size = new System.Drawing.Size(788, 424);
            this.TuDaTra.TabIndex = 3;
            this.TuDaTra.Text = "Từ đã tra";
            this.TuDaTra.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Việt - Anh",
            "Anh - Việt"});
            this.comboBox4.Location = new System.Drawing.Point(133, 45);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(163, 21);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.ColumnHeadersVisible = false;
            this.dataGridView4.Location = new System.Drawing.Point(133, 104);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(527, 296);
            this.dataGridView4.TabIndex = 0;
            // 
            // TuBatQuyTacTab
            // 
            this.TuBatQuyTacTab.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.hinh_nen_dep_cho_laptop_1366x768_1;
            this.TuBatQuyTacTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TuBatQuyTacTab.Location = new System.Drawing.Point(4, 22);
            this.TuBatQuyTacTab.Name = "TuBatQuyTacTab";
            this.TuBatQuyTacTab.Padding = new System.Windows.Forms.Padding(3);
            this.TuBatQuyTacTab.Size = new System.Drawing.Size(788, 424);
            this.TuBatQuyTacTab.TabIndex = 4;
            this.TuBatQuyTacTab.Text = "Từ bất quy tắc";
            this.TuBatQuyTacTab.UseVisualStyleBackColor = true;
            // 
            // ThemTuMoiTab
            // 
            this.ThemTuMoiTab.AllowDrop = true;
            this.ThemTuMoiTab.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.hinh_nen_dep_cho_laptop_1366x768_1;
            this.ThemTuMoiTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemTuMoiTab.Controls.Add(this.label6);
            this.ThemTuMoiTab.Controls.Add(this.label5);
            this.ThemTuMoiTab.Controls.Add(this.label4);
            this.ThemTuMoiTab.Controls.Add(this.label3);
            this.ThemTuMoiTab.Controls.Add(this.comboBox6_1);
            this.ThemTuMoiTab.Controls.Add(this.button6);
            this.ThemTuMoiTab.Controls.Add(this.textBox6_3);
            this.ThemTuMoiTab.Controls.Add(this.textBox6_2);
            this.ThemTuMoiTab.Controls.Add(this.comboBox6_2);
            this.ThemTuMoiTab.Controls.Add(this.textBox6);
            this.ThemTuMoiTab.Location = new System.Drawing.Point(4, 22);
            this.ThemTuMoiTab.Name = "ThemTuMoiTab";
            this.ThemTuMoiTab.Padding = new System.Windows.Forms.Padding(3);
            this.ThemTuMoiTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ThemTuMoiTab.Size = new System.Drawing.Size(788, 424);
            this.ThemTuMoiTab.TabIndex = 5;
            this.ThemTuMoiTab.Text = "Thêm từ mới";
            this.ThemTuMoiTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nghĩa Của Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phân Loại Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại Từ Điển";
            // 
            // comboBox6_1
            // 
            this.comboBox6_1.FormattingEnabled = true;
            this.comboBox6_1.Items.AddRange(new object[] {
            "Việt - Anh",
            "Anh - Việt"});
            this.comboBox6_1.Location = new System.Drawing.Point(206, 58);
            this.comboBox6_1.Name = "comboBox6_1";
            this.comboBox6_1.Size = new System.Drawing.Size(119, 21);
            this.comboBox6_1.TabIndex = 6;
            this.comboBox6_1.SelectedIndexChanged += new System.EventHandler(this.comboBox6_1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(575, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 41);
            this.button6.TabIndex = 5;
            this.button6.Tag = "";
            this.button6.Text = "Thêm Từ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox6_3
            // 
            this.textBox6_3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_3.ForeColor = System.Drawing.Color.Gray;
            this.textBox6_3.Location = new System.Drawing.Point(206, 211);
            this.textBox6_3.Multiline = true;
            this.textBox6_3.Name = "textBox6_3";
            this.textBox6_3.Size = new System.Drawing.Size(421, 177);
            this.textBox6_3.TabIndex = 4;
            this.textBox6_3.Text = "Nhập Nghĩa Của Từ";
            this.textBox6_3.Enter += new System.EventHandler(this.textBox6_3_Enter);
            this.textBox6_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_3_KeyDown);
            this.textBox6_3.Leave += new System.EventHandler(this.textBox6_3_Leave);
            // 
            // textBox6_2
            // 
            this.textBox6_2.Location = new System.Drawing.Point(374, 153);
            this.textBox6_2.Name = "textBox6_2";
            this.textBox6_2.Size = new System.Drawing.Size(124, 20);
            this.textBox6_2.TabIndex = 3;
            this.textBox6_2.Tag = "Nhập loại từ";
            this.textBox6_2.Visible = false;
            // 
            // comboBox6_2
            // 
            this.comboBox6_2.FormattingEnabled = true;
            this.comboBox6_2.Items.AddRange(new object[] {
            "Verb",
            "Noun",
            "Adj",
            "Adv",
            "Other"});
            this.comboBox6_2.Location = new System.Drawing.Point(206, 152);
            this.comboBox6_2.Name = "comboBox6_2";
            this.comboBox6_2.Size = new System.Drawing.Size(127, 21);
            this.comboBox6_2.TabIndex = 1;
            this.comboBox6_2.SelectedValueChanged += new System.EventHandler(this.comboBox6_2_SelectedValueChanged);
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.Gray;
            this.textBox6.Location = new System.Drawing.Point(206, 101);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(287, 20);
            this.textBox6.TabIndex = 0;
            this.textBox6.Tag = "";
            this.textBox6.Text = "Nhập Tên Từ";
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.VietAnhTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "StudyE";
            this.VietAnhTab.ResumeLayout(false);
            this.AnhVietTab.ResumeLayout(false);
            this.AnhVietTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TuDaTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.TuBatQuyTacTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ThemTuMoiTab.ResumeLayout(false);
            this.ThemTuMoiTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl VietAnhTab;
        private System.Windows.Forms.TabPage AnhVietTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TraDoanTab;
        private System.Windows.Forms.TabPage TuDaTra;
        private System.Windows.Forms.TabPage TuBatQuyTacTab;
        private System.Windows.Forms.TabPage ThemTuMoiTab;
        private System.Windows.Forms.Button button1;
//<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dataGridView1;
//=======
//>>>>>>> master
        private System.Windows.Forms.TextBox resultBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox resultBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox6_2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox6_2;
        private System.Windows.Forms.TextBox textBox6_3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox6_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}