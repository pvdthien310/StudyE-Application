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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TraDoanTab = new System.Windows.Forms.TabPage();
            this.TuDaTra = new System.Windows.Forms.TabPage();
            this.TuBatQuyTacTab = new System.Windows.Forms.TabPage();
            this.ThemTuMoiTab = new System.Windows.Forms.TabPage();
<<<<<<< HEAD
            this.button2 = new System.Windows.Forms.Button();
=======
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
>>>>>>> master
            this.VietAnhTab.SuspendLayout();
            this.AnhVietTab.SuspendLayout();
            this.TuBatQuyTacTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
<<<<<<< HEAD
            this.AnhVietTab.Controls.Add(this.button2);
=======
>>>>>>> master
            this.AnhVietTab.Controls.Add(this.button1);
            this.AnhVietTab.Controls.Add(this.comboBox1);
            this.AnhVietTab.Location = new System.Drawing.Point(4, 22);
            this.AnhVietTab.Name = "AnhVietTab";
            this.AnhVietTab.Padding = new System.Windows.Forms.Padding(3);
            this.AnhVietTab.Size = new System.Drawing.Size(788, 424);
            this.AnhVietTab.TabIndex = 0;
            this.AnhVietTab.Text = "Anh -  Việt";
            this.AnhVietTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(517, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
=======
            this.button1.Location = new System.Drawing.Point(776, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 35);
>>>>>>> master
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
<<<<<<< HEAD
            this.comboBox1.Location = new System.Drawing.Point(216, 55);
=======
            this.comboBox1.Location = new System.Drawing.Point(324, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> master
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Việt - Anh";
            this.tabPage2.UseVisualStyleBackColor = true;
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
<<<<<<< HEAD
            this.TuBatQuyTacTab.Location = new System.Drawing.Point(4, 22);
            this.TuBatQuyTacTab.Name = "TuBatQuyTacTab";
            this.TuBatQuyTacTab.Padding = new System.Windows.Forms.Padding(3);
            this.TuBatQuyTacTab.Size = new System.Drawing.Size(788, 424);
=======
            this.TuBatQuyTacTab.Controls.Add(this.dataGridView1);
            this.TuBatQuyTacTab.Location = new System.Drawing.Point(4, 22);
            this.TuBatQuyTacTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TuBatQuyTacTab.Name = "TuBatQuyTacTab";
            this.TuBatQuyTacTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TuBatQuyTacTab.Size = new System.Drawing.Size(1186, 666);
>>>>>>> master
            this.TuBatQuyTacTab.TabIndex = 4;
            this.TuBatQuyTacTab.Text = "Từ bất quy tắc";
            this.TuBatQuyTacTab.UseVisualStyleBackColor = true;
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
<<<<<<< HEAD
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
=======
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
>>>>>>> master
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.VietAnhTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "StudyE";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.VietAnhTab.ResumeLayout(false);
            this.AnhVietTab.ResumeLayout(false);
            this.TuBatQuyTacTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl VietAnhTab;
        private System.Windows.Forms.TabPage AnhVietTab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TraDoanTab;
        private System.Windows.Forms.TabPage TuDaTra;
        private System.Windows.Forms.TabPage TuBatQuyTacTab;
        private System.Windows.Forms.TabPage ThemTuMoiTab;
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.Button button2;
=======
        private System.Windows.Forms.DataGridView dataGridView1;
>>>>>>> master
    }
}