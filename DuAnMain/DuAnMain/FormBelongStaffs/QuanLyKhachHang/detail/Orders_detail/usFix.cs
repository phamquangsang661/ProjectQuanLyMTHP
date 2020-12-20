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
    public partial class usFix : UserControl
    {
        public int MaKH;
        public usFix(int MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
        }

        private void btnShowDon_Click(object sender, EventArgs e)
        {
            if (pnlDetail.Visible)
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

        private void pnlDetail_VisibleChanged(object sender, EventArgs e)
        {
            if(pnlDetail.Visible)
            {
                DataTable dt = DataBase_Connect.getData.getDonSuaKhaiQuatTheoMaKhachHang(MaKH);
                pnlDetail.Controls.Clear();
                foreach(DataRow r in dt.Rows)
                {
                    Orders_detail.usFixDetail us = new Orders_detail.usFixDetail() { Dock = DockStyle.Top };
                    us.virtualLblChiNhanh.Text = r["TenChiNhanh"].ToString();
                    us.virtualLblNgaySua.Text = "NS: "+r["NgaySua"].ToString().Split()[0];
                    us.virtualLblNgayTra.Text = "NT: "+r["NgayTra"].ToString().Split()[0];
                    us.virtualLblTenNV.Text = "NV: "+r["TenNV"].ToString();
                    us.virtualQuyTrinh.Text = r["MaQuyTrinh"].ToString();
                    pnlDetail.Controls.Add(us);

                }    
            }    
        }
    }
}
