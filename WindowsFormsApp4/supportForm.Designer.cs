namespace WindowsFormsApp4
{
    partial class supportForm
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
            this.textBox_support = new System.Windows.Forms.TextBox();
            this.textBox_support1 = new System.Windows.Forms.TextBox();
            this.label_support = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_support
            // 
            this.textBox_support.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_support.Location = new System.Drawing.Point(73, 127);
            this.textBox_support.Multiline = true;
            this.textBox_support.Name = "textBox_support";
            this.textBox_support.ReadOnly = true;
            this.textBox_support.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_support.Size = new System.Drawing.Size(648, 311);
            this.textBox_support.TabIndex = 0;
            // 
            // textBox_support1
            // 
            this.textBox_support1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_support1.ForeColor = System.Drawing.Color.Purple;
            this.textBox_support1.Location = new System.Drawing.Point(73, 78);
            this.textBox_support1.Multiline = true;
            this.textBox_support1.Name = "textBox_support1";
            this.textBox_support1.ReadOnly = true;
            this.textBox_support1.Size = new System.Drawing.Size(142, 43);
            this.textBox_support1.TabIndex = 1;
            // 
            // label_support
            // 
            this.label_support.AutoSize = true;
            this.label_support.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_support.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_support.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_support.Location = new System.Drawing.Point(306, 37);
            this.label_support.Name = "label_support";
            this.label_support.Size = new System.Drawing.Size(157, 26);
            this.label_support.TabIndex = 2;
            this.label_support.Text = "Tra Từ Nhanh";
            // 
            // supportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.hinh_nen_dep_cho_laptop_1366x768_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_support);
            this.Controls.Add(this.textBox_support1);
            this.Controls.Add(this.textBox_support);
            this.Name = "supportForm";
            this.Text = "Tra Từ Nhanh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_support;
        private System.Windows.Forms.TextBox textBox_support1;
        private System.Windows.Forms.Label label_support;
    }
}