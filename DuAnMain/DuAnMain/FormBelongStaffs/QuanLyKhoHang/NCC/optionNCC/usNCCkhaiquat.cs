using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang.NCC.optionNCC
{
    public partial class usNCCkhaiquat : UserControl
    {
        delegate void AnotherUS();
        public int MaNCC;
        public usNCCkhaiquat()
        {
            InitializeComponent();
            lblTenNCC.Text = r["TenNhaCungCap"].ToString();
            MaNCC = int.Parse(r["MaNhaCungCap"].ToString());
            virtualCbk = cbkNCC;
            //self = this;
        }

        public usNCCkhaiquat(DataRow r)
        {
            this.r = r;
        }

        public Guna.UI2.WinForms.Guna2CheckBox virtualCbk;
        private DataRow r;

        //public static uskhachhangkhaiquat self;

        private void cbkNCC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkNCC.Checked)
            {
                usDsconNCC.realSeclectLeft += 1;

            }
            else
            {
                usDsconNCC.realSeclectLeft -= 1;

            }
            AnotherUS t = new AnotherUS(usDsconNCC.changeStateLeft);

            t();
        }
    }
}
