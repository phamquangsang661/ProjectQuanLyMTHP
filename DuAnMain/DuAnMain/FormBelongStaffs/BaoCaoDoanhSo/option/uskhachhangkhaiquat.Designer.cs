
namespace DuAnMain.FormBelongStaffs.BaoCaoDoanhSo.option
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblTenKH = new Guna.UI.WinForms.GunaLabel();
            this.cbkKH = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(42, 35);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 23);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "VND 0.00";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.lblTenKH.Location = new System.Drawing.Point(42, 5);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(76, 19);
            this.lblTenKH.TabIndex = 4;
            this.lblTenKH.Text = "khachhang";
            // 
            // cbkKH
            // 
            this.cbkKH.BackColor = System.Drawing.SystemColors.Control;
            this.cbkKH.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkKH.CheckedState.BorderRadius = 2;
            this.cbkKH.CheckedState.BorderThickness = 0;
            this.cbkKH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkKH.Location = new System.Drawing.Point(14, 4);
            this.cbkKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbkKH.Name = "cbkKH";
            this.cbkKH.Size = new System.Drawing.Size(28, 25);
            this.cbkKH.TabIndex = 3;
            this.cbkKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbkKH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.cbkKH.UncheckedState.BorderRadius = 2;
            this.cbkKH.UncheckedState.BorderThickness = 1;
            this.cbkKH.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbkKH.UseVisualStyleBackColor = false;
            // 
            // uskhachhangkhaiquat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.cbkKH);
            this.Name = "uskhachhangkhaiquat";
            this.Size = new System.Drawing.Size(268, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblTenKH;
        private Guna.UI2.WinForms.Guna2CheckBox cbkKH;
    }
}
