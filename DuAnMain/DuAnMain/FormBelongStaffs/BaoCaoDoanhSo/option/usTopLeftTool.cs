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
    public partial class usTopLeftTool : UserControl
    {
        public usTopLeftTool()
        {
            InitializeComponent();
            //Virutallbl = lblSec;
        }
        public void updateState()
        {
            lblSec.Text = usDanhSachKhachHang.realSeclectLeft + " Selected";
        }
        delegate void CuALL();
        private void cbkAll_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
