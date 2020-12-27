
namespace WindowsFormsApp4
{
    partial class ResultForm2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.guna2Button_Back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 171);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 172);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // guna2Button_Back
            // 
            this.guna2Button_Back.CheckedState.Parent = this.guna2Button_Back;
            this.guna2Button_Back.CustomImages.Parent = this.guna2Button_Back;
            this.guna2Button_Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_Back.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Back.HoverState.Parent = this.guna2Button_Back;
            this.guna2Button_Back.Location = new System.Drawing.Point(514, 31);
            this.guna2Button_Back.Name = "guna2Button_Back";
            this.guna2Button_Back.ShadowDecoration.Parent = this.guna2Button_Back;
            this.guna2Button_Back.Size = new System.Drawing.Size(64, 50);
            this.guna2Button_Back.TabIndex = 1;
            this.guna2Button_Back.Text = "Trở Về";
            this.guna2Button_Back.Click += new System.EventHandler(this.guna2Button_Back_Click);
            // 
            // ResultForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.guna2Button_Back);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResultForm2";
            this.Text = "ResultForm2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Back;
    }
}