
namespace WindowsFormsApp4
{
    partial class Menustrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.CheckedState.Parent = this.Delete;
            this.Delete.CustomImages.Parent = this.Delete;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.HoverState.Parent = this.Delete;
            this.Delete.Location = new System.Drawing.Point(3, 3);
            this.Delete.Name = "Delete";
            this.Delete.ShadowDecoration.Parent = this.Delete;
            this.Delete.Size = new System.Drawing.Size(144, 52);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Xóa";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.CheckedState.Parent = this.Add;
            this.Add.CustomImages.Parent = this.Add;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.HoverState.Parent = this.Add;
            this.Add.Location = new System.Drawing.Point(3, 61);
            this.Add.Name = "Add";
            this.Add.ShadowDecoration.Parent = this.Add;
            this.Add.Size = new System.Drawing.Size(144, 52);
            this.Add.TabIndex = 1;
            this.Add.Text = "Thêm hình";
            // 
            // Menustrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Name = "Menustrip";
            this.Size = new System.Drawing.Size(150, 122);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Add;
    }
}
