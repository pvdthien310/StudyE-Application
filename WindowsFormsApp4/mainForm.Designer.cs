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
            this.TuBatQuyTacTab = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.NGUYENMAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUAKHUDON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUAKHUPHANTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGHIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemTuMoiTab = new System.Windows.Forms.TabPage();
            this.VietAnhTab.SuspendLayout();
            this.AnhVietTab.SuspendLayout();
            this.TuBatQuyTacTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
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
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(233, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "Nhập từ bạn muốn tra";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
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
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(233, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 28);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
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
            this.TuDaTra.Location = new System.Drawing.Point(4, 22);
            this.TuDaTra.Name = "TuDaTra";
            this.TuDaTra.Padding = new System.Windows.Forms.Padding(3);
            this.TuDaTra.Size = new System.Drawing.Size(788, 424);
            this.TuDaTra.TabIndex = 3;
            this.TuDaTra.Text = "Từ đã tra";
            this.TuDaTra.UseVisualStyleBackColor = true;
            // 
            // TuBatQuyTacTab
            // 
            this.TuBatQuyTacTab.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.hinh_nen_dep_cho_laptop_1366x768_1;
            this.TuBatQuyTacTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TuBatQuyTacTab.Controls.Add(this.button5);
            this.TuBatQuyTacTab.Controls.Add(this.textBox5);
            this.TuBatQuyTacTab.Controls.Add(this.dataGridView5);
            this.TuBatQuyTacTab.Location = new System.Drawing.Point(4, 22);
            this.TuBatQuyTacTab.Name = "TuBatQuyTacTab";
            this.TuBatQuyTacTab.Padding = new System.Windows.Forms.Padding(3);
            this.TuBatQuyTacTab.Size = new System.Drawing.Size(788, 424);
            this.TuBatQuyTacTab.TabIndex = 4;
            this.TuBatQuyTacTab.Text = "Từ bất quy tắc";
            this.TuBatQuyTacTab.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(594, 112);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 25);
            this.button5.TabIndex = 2;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(149, 112);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(399, 27);
            this.textBox5.TabIndex = 1;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NGUYENMAU,
            this.QUAKHUDON,
            this.QUAKHUPHANTU,
            this.NGHIA});
            this.dataGridView5.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView5.Location = new System.Drawing.Point(70, 188);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(627, 244);
            this.dataGridView5.TabIndex = 0;
            // 
            // NGUYENMAU
            // 
            this.NGUYENMAU.DataPropertyName = "NGUYENMAU";
            this.NGUYENMAU.HeaderText = "Nguyên mẫu";
            this.NGUYENMAU.MinimumWidth = 8;
            this.NGUYENMAU.Name = "NGUYENMAU";
            this.NGUYENMAU.ReadOnly = true;
            // 
            // QUAKHUDON
            // 
            this.QUAKHUDON.DataPropertyName = "QUAKHUDON";
            this.QUAKHUDON.HeaderText = "Quá khứ đơn";
            this.QUAKHUDON.MinimumWidth = 8;
            this.QUAKHUDON.Name = "QUAKHUDON";
            this.QUAKHUDON.ReadOnly = true;
            // 
            // QUAKHUPHANTU
            // 
            this.QUAKHUPHANTU.DataPropertyName = "QUAKHUPHANTU";
            this.QUAKHUPHANTU.HeaderText = "Quá khứ phân từ";
            this.QUAKHUPHANTU.MinimumWidth = 8;
            this.QUAKHUPHANTU.Name = "QUAKHUPHANTU";
            this.QUAKHUPHANTU.ReadOnly = true;
            // 
            // NGHIA
            // 
            this.NGHIA.DataPropertyName = "NGHIA";
            this.NGHIA.HeaderText = "Nghĩa";
            this.NGHIA.MinimumWidth = 8;
            this.NGHIA.Name = "NGHIA";
            this.NGHIA.ReadOnly = true;
            // 
            // ThemTuMoiTab
            // 
            this.ThemTuMoiTab.AllowDrop = true;
            this.ThemTuMoiTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemTuMoiTab.Location = new System.Drawing.Point(4, 22);
            this.ThemTuMoiTab.Name = "ThemTuMoiTab";
            this.ThemTuMoiTab.Padding = new System.Windows.Forms.Padding(3);
            this.ThemTuMoiTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ThemTuMoiTab.Size = new System.Drawing.Size(788, 424);
            this.ThemTuMoiTab.TabIndex = 5;
            this.ThemTuMoiTab.Text = "Thêm từ mới";
            this.ThemTuMoiTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Location = new System.Drawing.Point(272, 58);
            //this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.RowHeadersWidth = 62;
            //this.dataGridView1.Size = new System.Drawing.Size(160, 97);
            //this.dataGridView1.TabIndex = 0;
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
            this.TuBatQuyTacTab.ResumeLayout(false);
            this.TuBatQuyTacTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUYENMAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUAKHUDON;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUAKHUPHANTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGHIA;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
//<<<<<<< HEAD
//=======
//>>>>>>> master
        private System.Windows.Forms.TextBox resultBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox resultBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}