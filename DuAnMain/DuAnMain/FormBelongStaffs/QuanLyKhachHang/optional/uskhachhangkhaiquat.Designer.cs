namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.optional
{
    partial class uskhachhangkhaiquat
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
            this.cbkKH = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblTenKH = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // cbkKH
            // 
            this.cbkKH.BackColor = System.Drawing.SystemColors.Control;
            this.cbkKH.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkKH.CheckedState.BorderRadius = 2;
            this.cbkKH.CheckedState.BorderThickness = 0;
            this.cbkKH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkKH.Location = new System.Drawing.Point(6, 5);
            this.cbkKH.Name = "cbkKH";
            this.cbkKH.Size = new System.Drawing.Size(21, 20);
            this.cbkKH.TabIndex = 0;
            this.cbkKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbkKH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.cbkKH.UncheckedState.BorderRadius = 2;
            this.cbkKH.UncheckedState.BorderThickness = 1;
            this.cbkKH.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbkKH.UseVisualStyleBackColor = false;
            this.cbkKH.CheckedChanged += new System.EventHandler(this.cbkKH_CheckedChanged);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.lblTenKH.Location = new System.Drawing.Point(27, 6);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(70, 17);
            this.lblTenKH.TabIndex = 1;
            this.lblTenKH.Text = "khachhang";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(27, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 19);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "VND 0.00";
            // 
            // uskhachhangkhaiquat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.cbkKH);
            this.Name = "uskhachhangkhaiquat";
            this.Size = new System.Drawing.Size(201, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox cbkKH;
        private Guna.UI.WinForms.GunaLabel lblTenKH;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
