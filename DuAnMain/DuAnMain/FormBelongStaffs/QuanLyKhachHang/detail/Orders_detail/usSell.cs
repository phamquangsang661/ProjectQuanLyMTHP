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
    public partial class usSell : UserControl
    {
        MyControl.PanelSlicer virtualPnlVirtual;
        public usSell()
        {
            InitializeComponent();
            virtualPnlVirtual = new MyControl.PanelSlicer(pnlDetail);

        }

        private void btnShowDon_Click(object sender, EventArgs e)
        {
            if(virtualPnlVirtual.statePnl==0)
            {
                virtualPnlVirtual.Show();
                btnShowDon.Image = imgl.Images[0];
            }    
            else
            {
                virtualPnlVirtual.Hide();
                btnShowDon.Image = imgl.Images[1];
            }    
        }
    }
}
