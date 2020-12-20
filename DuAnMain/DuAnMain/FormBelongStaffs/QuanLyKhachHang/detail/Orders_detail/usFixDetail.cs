using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.detail.Orders_detail
{
    public partial class usFixDetail : UserControl
    {
        public usFixDetail()
        {
            InitializeComponent();
            virtualLblChiNhanh = lblTenChiNhanh;
            virtualLblNgaySua = lblNgaySua;
            virtualLblNgayTra = lblNgayTra;
            virtualLblTenNV = lblTenNhanVien;
            virtualQuyTrinh = lblQuyTrinh;
        }
        public Guna.UI.WinForms.GunaLabel virtualLblChiNhanh;
        public Guna.UI.WinForms.GunaLabel virtualLblNgaySua;
        public Guna.UI.WinForms.GunaLabel virtualLblNgayTra;
        public Guna.UI.WinForms.GunaLabel virtualLblTenNV;
        public Guna.UI.WinForms.GunaLabel virtualQuyTrinh;
        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
