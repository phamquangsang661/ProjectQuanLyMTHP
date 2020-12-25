
namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang.NCC
{
    partial class usDsconNCC
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
            this.pnlCenter = new Guna.UI2.WinForms.Guna2Panel();
            this.pnllstNCC = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlToolLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlKhachHang = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(215, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.ShadowDecoration.Parent = this.pnlCenter;
            this.pnlCenter.Size = new System.Drawing.Size(650, 470);
            this.pnlCenter.TabIndex = 3;
            // 
            // pnllstNCC
            // 
            this.pnllstNCC.AutoScroll = true;
            this.pnllstNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllstNCC.Location = new System.Drawing.Point(0, 66);
            this.pnllstNCC.Name = "pnllstNCC";
            this.pnllstNCC.ShadowDecoration.Parent = this.pnllstNCC;
            this.pnllstNCC.Size = new System.Drawing.Size(215, 404);
            this.pnllstNCC.TabIndex = 1;
            // 
            // pnlToolLeft
            // 
            this.pnlToolLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlToolLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlToolLeft.Name = "pnlToolLeft";
            this.pnlToolLeft.ShadowDecoration.Parent = this.pnlToolLeft;
            this.pnlToolLeft.Size = new System.Drawing.Size(215, 66);
            this.pnlToolLeft.TabIndex = 0;
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.Controls.Add(this.pnllstNCC);
            this.pnlKhachHang.Controls.Add(this.pnlToolLeft);
            this.pnlKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.ShadowDecoration.Parent = this.pnlKhachHang;
            this.pnlKhachHang.Size = new System.Drawing.Size(215, 470);
            this.pnlKhachHang.TabIndex = 2;
            // 
            // usDsconNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlKhachHang);
            this.Name = "usDsconNCC";
            this.Size = new System.Drawing.Size(865, 470);
            this.pnlKhachHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCenter;
        private Guna.UI2.WinForms.Guna2Panel pnllstNCC;
        private Guna.UI2.WinForms.Guna2Panel pnlToolLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlKhachHang;
    }
}
