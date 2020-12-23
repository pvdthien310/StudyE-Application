namespace WindowsFormsApp4
{
    partial class RoomForm
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Label_RoomID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView_test = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button_Ready = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Start = new Guna.UI2.WinForms.Guna2Button();
            this.label_readycheck = new System.Windows.Forms.Label();
            this.checklabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(505, 116);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Trở Lại";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Label_RoomID
            // 
            this.Label_RoomID.BackColor = System.Drawing.Color.Transparent;
            this.Label_RoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomID.Location = new System.Drawing.Point(131, 83);
            this.Label_RoomID.Name = "Label_RoomID";
            this.Label_RoomID.Size = new System.Drawing.Size(186, 27);
            this.Label_RoomID.TabIndex = 1;
            this.Label_RoomID.Text = "guna2HtmlLabel1";
            // 
            // dataGridView_test
            // 
            this.dataGridView_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_test.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_test.Location = new System.Drawing.Point(87, 217);
            this.dataGridView_test.Name = "dataGridView_test";
            this.dataGridView_test.Size = new System.Drawing.Size(743, 216);
            this.dataGridView_test.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // guna2Button_Ready
            // 
            this.guna2Button_Ready.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Ready.BorderRadius = 15;
            this.guna2Button_Ready.CheckedState.Parent = this.guna2Button_Ready;
            this.guna2Button_Ready.CustomImages.Parent = this.guna2Button_Ready;
            this.guna2Button_Ready.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_Ready.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_Ready.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Ready.HoverState.Parent = this.guna2Button_Ready;
            this.guna2Button_Ready.Location = new System.Drawing.Point(508, 54);
            this.guna2Button_Ready.Name = "guna2Button_Ready";
            this.guna2Button_Ready.ShadowDecoration.Parent = this.guna2Button_Ready;
            this.guna2Button_Ready.Size = new System.Drawing.Size(167, 55);
            this.guna2Button_Ready.TabIndex = 3;
            this.guna2Button_Ready.Text = "Sẵn Sàng";
            this.guna2Button_Ready.Click += new System.EventHandler(this.guna2Button_Ready_Click);
            // 
            // guna2Button_Start
            // 
            this.guna2Button_Start.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Start.BorderRadius = 15;
            this.guna2Button_Start.CheckedState.Parent = this.guna2Button_Start;
            this.guna2Button_Start.CustomImages.Parent = this.guna2Button_Start;
            this.guna2Button_Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_Start.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Start.HoverState.Parent = this.guna2Button_Start;
            this.guna2Button_Start.Location = new System.Drawing.Point(744, 55);
            this.guna2Button_Start.Name = "guna2Button_Start";
            this.guna2Button_Start.ShadowDecoration.Parent = this.guna2Button_Start;
            this.guna2Button_Start.Size = new System.Drawing.Size(167, 55);
            this.guna2Button_Start.TabIndex = 4;
            this.guna2Button_Start.Text = "Bắt Đầu";
            this.guna2Button_Start.Click += new System.EventHandler(this.guna2Button_Start_Click);
            // 
            // label_readycheck
            // 
            this.label_readycheck.AutoSize = true;
            this.label_readycheck.Location = new System.Drawing.Point(742, 155);
            this.label_readycheck.Name = "label_readycheck";
            this.label_readycheck.Size = new System.Drawing.Size(35, 13);
            this.label_readycheck.TabIndex = 5;
            this.label_readycheck.Text = "label1";
            // 
            // checklabel
            // 
            this.checklabel.BackColor = System.Drawing.Color.Transparent;
            this.checklabel.Location = new System.Drawing.Point(176, 167);
            this.checklabel.Name = "checklabel";
            this.checklabel.Size = new System.Drawing.Size(86, 15);
            this.checklabel.TabIndex = 6;
            this.checklabel.Text = "guna2HtmlLabel1";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.checklabel);
            this.Controls.Add(this.label_readycheck);
            this.Controls.Add(this.guna2Button_Start);
            this.Controls.Add(this.guna2Button_Ready);
            this.Controls.Add(this.dataGridView_test);
            this.Controls.Add(this.Label_RoomID);
            this.Controls.Add(this.guna2Button1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_RoomID;
        private System.Windows.Forms.DataGridView dataGridView_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Ready;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Start;
        private System.Windows.Forms.Label label_readycheck;
        private Guna.UI2.WinForms.Guna2HtmlLabel checklabel;
    }
}