namespace DuAnMain
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.p2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.lblCreateAcc = new Guna.UI.WinForms.GunaLinkLabel();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.p3 = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuMaterialTextbox6 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.animateLogin = new Guna.UI.WinForms.GunaTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.p3.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(28)))));
            this.p1.Controls.Add(this.gunaLabel2);
            this.p1.Controls.Add(this.gunaLabel1);
            this.animateLogin.SetDecoration(this.p1, Guna.UI.Animation.DecorationType.None);
            this.p1.Dock = System.Windows.Forms.DockStyle.Left;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(361, 576);
            this.p1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.animateLogin.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel2.Location = new System.Drawing.Point(65, 217);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(208, 32);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "We Are Conecting";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.animateLogin.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel1.Location = new System.Drawing.Point(83, 140);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(167, 78);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "WAC";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.p2.Controls.Add(this.gunaCheckBox1);
            this.p2.Controls.Add(this.lblCreateAcc);
            this.p2.Controls.Add(this.btnLogin);
            this.p2.Controls.Add(this.bunifuMaterialTextbox2);
            this.p2.Controls.Add(this.bunifuMaterialTextbox1);
            this.animateLogin.SetDecoration(this.p2, Guna.UI.Animation.DecorationType.None);
            this.p2.Dock = System.Windows.Forms.DockStyle.Right;
            this.p2.Location = new System.Drawing.Point(356, 0);
            this.p2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(437, 576);
            this.p2.TabIndex = 0;
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.gunaCheckBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.animateLogin.SetDecoration(this.gunaCheckBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.ForeColor = System.Drawing.Color.Silver;
            this.gunaCheckBox1.Location = new System.Drawing.Point(37, 257);
            this.gunaCheckBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(119, 20);
            this.gunaCheckBox1.TabIndex = 4;
            this.gunaCheckBox1.Text = "Remember me";
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.lblCreateAcc.AutoSize = true;
            this.animateLogin.SetDecoration(this.lblCreateAcc, Guna.UI.Animation.DecorationType.None);
            this.lblCreateAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCreateAcc.LinkColor = System.Drawing.Color.Silver;
            this.lblCreateAcc.Location = new System.Drawing.Point(156, 481);
            this.lblCreateAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(110, 20);
            this.lblCreateAcc.TabIndex = 3;
            this.lblCreateAcc.TabStop = true;
            this.lblCreateAcc.Text = "Create Account";
            this.lblCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreateAcc_LinkClicked);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animateLogin.SetDecoration(this.bunifuMaterialTextbox2, Guna.UI.Animation.DecorationType.None);
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.HintText = "Password";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(37, 175);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(349, 54);
            this.bunifuMaterialTextbox2.TabIndex = 1;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animateLogin.SetDecoration(this.bunifuMaterialTextbox1, Guna.UI.Animation.DecorationType.None);
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.HintText = "Username";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(37, 103);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(349, 54);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.p3.Controls.Add(this.btnExit);
            this.p3.Controls.Add(this.gunaLabel3);
            this.p3.Controls.Add(this.gunaButton2);
            this.p3.Controls.Add(this.bunifuMaterialTextbox6);
            this.p3.Controls.Add(this.bunifuMaterialTextbox5);
            this.p3.Controls.Add(this.bunifuMaterialTextbox3);
            this.p3.Controls.Add(this.bunifuMaterialTextbox4);
            this.animateLogin.SetDecoration(this.p3, Guna.UI.Animation.DecorationType.None);
            this.p3.Location = new System.Drawing.Point(356, 0);
            this.p3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(437, 576);
            this.p3.TabIndex = 5;
            this.p3.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.animateLogin.SetDecoration(this.btnExit, Guna.UI.Animation.DecorationType.None);
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(409, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.animateLogin.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel3.Location = new System.Drawing.Point(11, 11);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(128, 20);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "We Are Conecting";
            // 
            // bunifuMaterialTextbox6
            // 
            this.bunifuMaterialTextbox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox6.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animateLogin.SetDecoration(this.bunifuMaterialTextbox6, Guna.UI.Animation.DecorationType.None);
            this.bunifuMaterialTextbox6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox6.HintText = "Authentication Code";
            this.bunifuMaterialTextbox6.isPassword = false;
            this.bunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.bunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox6.LineThickness = 3;
            this.bunifuMaterialTextbox6.Location = new System.Drawing.Point(37, 289);
            this.bunifuMaterialTextbox6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox6.MaxLength = 32767;
            this.bunifuMaterialTextbox6.Name = "bunifuMaterialTextbox6";
            this.bunifuMaterialTextbox6.Size = new System.Drawing.Size(349, 54);
            this.bunifuMaterialTextbox6.TabIndex = 1;
            this.bunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animateLogin.SetDecoration(this.bunifuMaterialTextbox5, Guna.UI.Animation.DecorationType.None);
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox5.HintText = "Re-Enter Password";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(37, 213);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox5.MaxLength = 32767;
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(349, 54);
            this.bunifuMaterialTextbox5.TabIndex = 1;
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animateLogin.SetDecoration(this.bunifuMaterialTextbox3, Guna.UI.Animation.DecorationType.None);
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.HintText = "Password";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(37, 140);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox3.MaxLength = 32767;
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(349, 54);
            this.bunifuMaterialTextbox3.TabIndex = 1;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animateLogin.SetDecoration(this.bunifuMaterialTextbox4, Guna.UI.Animation.DecorationType.None);
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.HintText = "Username";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(37, 70);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox4.MaxLength = 32767;
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(349, 54);
            this.bunifuMaterialTextbox4.TabIndex = 0;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // animateLogin
            // 
            this.animateLogin.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.animateLogin.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animateLogin.DefaultAnimation = animation1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.p1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.animateLogin.SetDecoration(this.gunaButton2, Guna.UI.Animation.DecorationType.None);
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::DuAnMain.Properties.Resources.registry_editor_100px;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(37, 399);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(349, 52);
            this.gunaButton2.TabIndex = 2;
            this.gunaButton2.Text = "Sign up";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.animateLogin.SetDecoration(this.btnLogin, Guna.UI.Animation.DecorationType.None);
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::DuAnMain.Properties.Resources.registry_editor_100px;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(36, 346);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(349, 52);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.animateLogin.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel p1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel p2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private Guna.UI.WinForms.GunaLinkLabel lblCreateAcc;
        private Guna.UI.WinForms.GunaPanel p3;
        private Guna.UI.WinForms.GunaLabel btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Guna.UI.WinForms.GunaTransition animateLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

