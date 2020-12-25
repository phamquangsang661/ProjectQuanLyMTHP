using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang.NCC
{
    public partial class uschitiet : UserControl
    {
        private int maNCC;

        public uschitiet()
        {
            InitializeComponent();
        }

        public uschitiet(int maNCC)
        {
            this.maNCC = maNCC;
        }

        public int MaNCC { get; internal set; }
    }
}
