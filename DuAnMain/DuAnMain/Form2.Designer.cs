namespace DuAnMain
{
    partial class Form2
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
            this.licensing1 = new Guna.UI.Licensing.Licensing();
            this.licensing2 = new Guna.UI2.Licensing.Licensing();
            this.SuspendLayout();
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.White;
            this.licensing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.licensing1.Location = new System.Drawing.Point(32, -24);
            this.licensing1.MaximumSize = new System.Drawing.Size(348, 485);
            this.licensing1.MinimumSize = new System.Drawing.Size(348, 485);
            this.licensing1.Name = "licensing1";
            this.licensing1.Size = new System.Drawing.Size(348, 485);
            this.licensing1.TabIndex = 0;
            // 
            // licensing2
            // 
            this.licensing2.BackColor = System.Drawing.Color.White;
            this.licensing2.Location = new System.Drawing.Point(219, -24);
            this.licensing2.MaximumSize = new System.Drawing.Size(348, 485);
            this.licensing2.MinimumSize = new System.Drawing.Size(348, 485);
            this.licensing2.Name = "licensing2";
            this.licensing2.Size = new System.Drawing.Size(348, 485);
            this.licensing2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.licensing2);
            this.Controls.Add(this.licensing1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.Licensing.Licensing licensing1;
        private Guna.UI2.Licensing.Licensing licensing2;
    }
}