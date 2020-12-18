using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang
{

    public partial class KhachHangChiTiet : UserControl
    {
        public KhachHangChiTiet()
        {
            InitializeComponent();
        }
        Bunifu.UI.WinForms.BunifuButton.BunifuButton onAcBtn=null;
        Panel pnlHover = null;
        public void ChangeOldStateBtn(Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
        {
            btn.OnIdleState.ForeColor = Color.FromArgb(78, 144, 233);
            btn.onHoverState.ForeColor = Color.FromArgb(49, 116, 192);
            btn.OnPressedState.ForeColor = Color.FromArgb(49, 116, 192);
        }
        public void ChangeNewStateBtn(Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
        {
            btn.OnIdleState.ForeColor = Color.FromArgb(51, 51, 51);
            btn.onHoverState.ForeColor = Color.FromArgb(51, 51, 51);
            btn.OnPressedState.ForeColor = Color.FromArgb(51, 51, 51);
        }
        public void addPnlHover(Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
        {
            if (btn!=onAcBtn)
            {
                pnlHover = new Panel();
                pnlHover.Width = btn.Width;
                pnlHover.Height =5;
                pnlHover.BackColor = Color.FromArgb(47, 163, 230);
                pnlHover.Location = btn.Location;
                

            }
        }
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            if (onAcBtn != null)
                ChangeOldStateBtn(onAcBtn);
           
            ChangeNewStateBtn(btnTongQuan);
            pnlHover = new Panel();
            pnlHover.Width = btnTongQuan.Width;

            onAcBtn = btnTongQuan;

        }

        private void btnGhiChu_Click(object sender, EventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachLienQuan_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }
    }


    
}
