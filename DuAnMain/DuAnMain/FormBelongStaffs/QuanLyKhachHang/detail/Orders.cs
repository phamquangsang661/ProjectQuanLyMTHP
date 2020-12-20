using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.detail
{
    public partial class Orders : UserControl
    {
        public int MaKH;
        public Orders(int MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            pnlSell.Controls.Add(new Orders_detail.usSell() { Dock=DockStyle.Fill});

        }
    }
}
