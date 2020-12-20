namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.detail
{
    partial class Orders
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSell = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFix = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pnlFix);
            this.guna2Panel1.Controls.Add(this.pnlSell);
            this.guna2Panel1.Controls.Add(this.pnlSetting);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(857, 398);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.ShadowDecoration.Parent = this.pnlSetting;
            this.pnlSetting.Size = new System.Drawing.Size(857, 42);
            this.pnlSetting.TabIndex = 0;
            // 
            // pnlSell
            // 
            this.pnlSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSell.Location = new System.Drawing.Point(0, 42);
            this.pnlSell.Name = "pnlSell";
            this.pnlSell.ShadowDecoration.Parent = this.pnlSell;
            this.pnlSell.Size = new System.Drawing.Size(857, 35);
            this.pnlSell.TabIndex = 1;
            // 
            // pnlFix
            // 
            this.pnlFix.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFix.Location = new System.Drawing.Point(0, 77);
            this.pnlFix.Name = "pnlFix";
            this.pnlFix.ShadowDecoration.Parent = this.pnlFix;
            this.pnlFix.Size = new System.Drawing.Size(857, 38);
            this.pnlFix.TabIndex = 2;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(857, 398);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlFix;
        private Guna.UI2.WinForms.Guna2Panel pnlSell;
        private Guna.UI2.WinForms.Guna2Panel pnlSetting;
    }
}
