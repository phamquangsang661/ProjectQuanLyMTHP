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
      
        public usSell(int MaKH)
        {
            InitializeComponent();
           

        }

        private void btnShowDon_Click(object sender, EventArgs e)
        {
            if(pnlDetail.Visible)
            {
                pnlDetail.Visible = false;
                btnShowDon.Image = imgl.Images[0];
            }
            else
            {
                pnlDetail.Visible = true;
                btnShowDon.Image = imgl.Images[1];
            }
        }
    }
}
