using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.optional
{
    public partial class usTopLeftTool : UserControl
    {
       // public static Guna.UI.WinForms.GunaLabel Virutallbl;
        
        public usTopLeftTool()
        {
            InitializeComponent();
            //Virutallbl = lblSec;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
        public  void updateState()
        {
           lblSec.Text = usDanhSachKhachHang.realSeclectLeft + " Selected";
        }
        delegate void CuALL();
        private void cbkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkAll.Checked)
            {
                CuALL a = new CuALL(usDanhSachKhachHang.chooseAllLeft);
                a();
            }
            else
            {
                CuALL a = new CuALL(usDanhSachKhachHang.unchooseAllLeft);
                a();
            }    
        }
    }
}
