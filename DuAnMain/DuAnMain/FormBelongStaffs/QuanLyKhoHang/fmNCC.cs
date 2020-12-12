using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang
{
    public partial class fmNCC : UserControl
    {
        public fmNCC()
        {
            InitializeComponent();
        }

        private void fmNCC_Load(object sender, EventArgs e)
        {
            List<string> ts = new List<string>()
            {
                { "Tất cả nhà cung cấp"},
                { "Các nhà cung cấp máy tính"},
                { "Các nhà cung cấp phụ kiện"},
            };
            cmbNCC.DataSource = ts;
        }

        private void gunabtnthemNCC_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 1;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 0;
        }
    }
}
