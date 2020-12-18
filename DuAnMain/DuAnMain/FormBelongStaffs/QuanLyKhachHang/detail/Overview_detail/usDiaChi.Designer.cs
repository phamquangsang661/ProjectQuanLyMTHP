namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.detail.Overview_detail
{
    partial class usDiaChi
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDiaChiShip = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(93, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Địa chỉ shipping";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.gunaLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(376, 36);
            this.guna2Panel2.TabIndex = 2;
            // 
            // pnlDiaChiShip
            // 
            this.pnlDiaChiShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDiaChiShip.Location = new System.Drawing.Point(0, 36);
            this.pnlDiaChiShip.Name = "pnlDiaChiShip";
            this.pnlDiaChiShip.ShadowDecoration.Parent = this.pnlDiaChiShip;
            this.pnlDiaChiShip.Size = new System.Drawing.Size(376, 145);
            this.pnlDiaChiShip.TabIndex = 3;
            // 
            // usDiaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlDiaChiShip);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "usDiaChi";
            this.Size = new System.Drawing.Size(376, 181);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnlDiaChiShip;
    }
}
