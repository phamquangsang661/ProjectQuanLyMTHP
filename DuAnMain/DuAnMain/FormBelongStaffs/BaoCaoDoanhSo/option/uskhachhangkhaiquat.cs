using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.BaoCaoDoanhSo.option
{
    public partial class uskhachhangkhaiquat : UserControl
    {
        delegate void AnotherUS();
        public int MaKH;
        public uskhachhangkhaiquat(DataRow r)
        {
            InitializeComponent();
            lblTenKH.Text = r["TenKhachhang"].ToString();
            MaKH = int.Parse(r["MaKhachHang"].ToString());
            virtualCbk = cbkKH;
            //self = this;
        }

        public Guna.UI2.WinForms.Guna2CheckBox virtualCbk;
        //public static uskhachhangkhaiquat self;
        private void cbkKH_CheckedChanged(object sender, EventArgs e)
        {

            

        }
    }
}
