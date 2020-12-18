using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.detail.Overview_detail
{
    public partial class usDiaChi : UserControl
    {
        public int MaKH;
        public usDiaChi(int MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            pnlDiaChiShip.Height = 0;
        }
    }
}
