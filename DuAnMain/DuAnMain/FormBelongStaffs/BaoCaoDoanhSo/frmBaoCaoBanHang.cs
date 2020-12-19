using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.BaoCaoDoanhSo
{
    public partial class frmBaoCaoBanHang : UserControl
    {
        public frmBaoCaoBanHang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoBanHang_Load(object sender, EventArgs e)
        {
            List<string> ts = new List<string>()
            {
                { "Doanh thu theo khách hàng" },
                { "Doanh thu theo mặt hàng" },
                { "Doanh thu theo nhân viên bán hàng" },
                { "Lịch sử đóng gói" },
            };
            cmbBaoCaoBanHang.DataSource = ts;
        }
    }
}
