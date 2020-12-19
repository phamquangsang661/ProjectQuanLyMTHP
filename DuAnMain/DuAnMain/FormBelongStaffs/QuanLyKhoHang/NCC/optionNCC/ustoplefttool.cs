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
   
    public partial class ustoplefttool : UserControl
    {
        public ustoplefttool()
        {
            InitializeComponent();
        }
        public void updateState()
        {
            lblSec.Text = usDsconNCC.realSeclectLeft + " Selected";
        }
        delegate void CuALL();
        private void cbkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkAll.Checked)
            {
                CuALL a = new CuALL(usDsconNCC.chooseAllLeft);
                a();
            }
            else
            {
                CuALL a = new CuALL(usDsconNCC.unchooseAllLeft);
                a();
            }
        }
    }
    
}
