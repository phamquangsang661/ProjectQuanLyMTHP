namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.detail.Orders_detail
{
    partial class usFix
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usFix));
            this.pnlDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowDon = new Guna.UI2.WinForms.Guna2Button();
            this.imgl = new System.Windows.Forms.ImageList(this.components);
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.AutoSize = true;
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 40);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.ShadowDecoration.Parent = this.pnlDetail;
            this.pnlDetail.Size = new System.Drawing.Size(785, 218);
            this.pnlDetail.TabIndex = 3;
            this.pnlDetail.VisibleChanged += new System.EventHandler(this.pnlDetail_VisibleChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.btnShowDon);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(785, 40);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnShowDon
            // 
            this.btnShowDon.CheckedState.Parent = this.btnShowDon;
            this.btnShowDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDon.CustomImages.Parent = this.btnShowDon;
            this.btnShowDon.FillColor = System.Drawing.Color.White;
            this.btnShowDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShowDon.ForeColor = System.Drawing.Color.Black;
            this.btnShowDon.HoverState.Parent = this.btnShowDon;
            this.btnShowDon.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDon.Image")));
            this.btnShowDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowDon.ImageSize = new System.Drawing.Size(16, 16);
            this.btnShowDon.Location = new System.Drawing.Point(5, 6);
            this.btnShowDon.Name = "btnShowDon";
            this.btnShowDon.PressedColor = System.Drawing.Color.White;
            this.btnShowDon.ShadowDecoration.BorderRadius = 0;
            this.btnShowDon.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnShowDon.ShadowDecoration.Depth = 0;
            this.btnShowDon.ShadowDecoration.Parent = this.btnShowDon;
            this.btnShowDon.Size = new System.Drawing.Size(123, 31);
            this.btnShowDon.TabIndex = 1;
            this.btnShowDon.Text = "Đơn sửa";
            this.btnShowDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowDon.Click += new System.EventHandler(this.btnShowDon_Click);
            // 
            // imgl
            // 
            this.imgl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl.ImageStream")));
            this.imgl.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl.Images.SetKeyName(0, "collapse_arrow_104px.png");
            this.imgl.Images.SetKeyName(1, "expand_arrow_104px.png");
            // 
            // usFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "usFix";
            this.Size = new System.Drawing.Size(785, 258);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDetail;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnShowDon;
        private System.Windows.Forms.ImageList imgl;
    }
}
