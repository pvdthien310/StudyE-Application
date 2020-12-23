namespace WindowsFormsApp4
{
    partial class GameForm2
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
            this.time_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // time_label
            // 
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Location = new System.Drawing.Point(38, 19);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(86, 15);
            this.time_label.TabIndex = 0;
            this.time_label.Text = "guna2HtmlLabel1";
            // 
            // GameForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.time_label);
            this.DoubleBuffered = true;
            this.Name = "GameForm2";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2HtmlLabel time_label;
    }
}