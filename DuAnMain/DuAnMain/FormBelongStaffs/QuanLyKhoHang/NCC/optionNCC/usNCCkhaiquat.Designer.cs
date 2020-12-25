
namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang.NCC.optionNCC
{
    partial class usNCCkhaiquat
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
            this.lblTenNCC = new Guna.UI.WinForms.GunaLabel();
            this.cbkNCC = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(29, 33);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 19);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "VND 0.00";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.lblTenNCC.Location = new System.Drawing.Point(29, 9);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(34, 17);
            this.lblTenNCC.TabIndex = 4;
            this.lblTenNCC.Text = "NCC";
            // 
            // cbkNCC
            // 
            this.cbkNCC.BackColor = System.Drawing.SystemColors.Control;
            this.cbkNCC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkNCC.CheckedState.BorderRadius = 2;
            this.cbkNCC.CheckedState.BorderThickness = 0;
            this.cbkNCC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkNCC.Location = new System.Drawing.Point(8, 8);
            this.cbkNCC.Name = "cbkNCC";
            this.cbkNCC.Size = new System.Drawing.Size(21, 20);
            this.cbkNCC.TabIndex = 3;
            this.cbkNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbkNCC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.cbkNCC.UncheckedState.BorderRadius = 2;
            this.cbkNCC.UncheckedState.BorderThickness = 1;
            this.cbkNCC.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbkNCC.UseVisualStyleBackColor = false;
            this.cbkNCC.CheckedChanged += new System.EventHandler(this.cbkNCC_CheckedChanged);
            // 
            // usNCCkhaiquat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblTenNCC);
            this.Controls.Add(this.cbkNCC);
            this.Name = "usNCCkhaiquat";
            this.Size = new System.Drawing.Size(201, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblTenNCC;
        private Guna.UI2.WinForms.Guna2CheckBox cbkNCC;
    }
}
