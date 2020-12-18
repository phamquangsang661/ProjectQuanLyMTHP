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
            pnlHover = new Panel();
            pnlMid.Controls.Add(pnlHover);
            gtran.Hide(pnlHover);
        }
        Bunifu.UI.WinForms.BunifuButton.BunifuButton onAcBtn=null;
        Panel pnlHover = null;
        public void ChangeOldStateBtn(Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
        {
            btn.OnIdleState.ForeColor = Color.FromArgb(78, 144, 233);
            btn.onHoverState.ForeColor = Color.FromArgb(49, 116, 192);
            btn.OnPressedState.ForeColor = Color.FromArgb(49, 116, 192);
            btn.ForeColor = Color.FromArgb(78, 144, 233);
        }
        public void ChangeNewStateBtn(Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
        {
            btn.OnIdleState.ForeColor = Color.FromArgb(51, 51, 51);
            btn.onHoverState.ForeColor = Color.FromArgb(51, 51, 51);
            btn.ForeColor = Color.FromArgb(51, 51, 51);
            
            btn.OnPressedState.ForeColor = Color.FromArgb(51, 51, 51);
        }
        public void addPnlHover(Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
        {
            
            
             gtran.HideSync(pnlHover);
                
             pnlHover.Width = btn.Width;
             pnlHover.Height =5;
             pnlHover.BackColor = Color.FromArgb(47, 163, 230);
     
             pnlHover.Location = new Point(btn.Location.X, btn.Location.Y + btn.Height - 5);
             pnlHover.BringToFront();
             gtran.ShowSync(pnlHover);
            
        }
        private void btnTongQuan_Click(object sender, EventArgs e)
        {

            if (onAcBtn != null)
            {
                if (onAcBtn==btnTongQuan)
                {
                    return;
                }    

                ChangeOldStateBtn(onAcBtn);
            }
            ChangeNewStateBtn(btnTongQuan);
            addPnlHover(btnTongQuan);

            onAcBtn = btnTongQuan;

        }

        private void btnGhiChu_Click(object sender, EventArgs e)
        {
            if (onAcBtn != null)
            {
                if (onAcBtn ==btnGhiChu)
                {
                    return;
                }

                ChangeOldStateBtn(onAcBtn);
            }

            ChangeNewStateBtn(btnGhiChu);
            addPnlHover(btnGhiChu);

            onAcBtn = btnGhiChu;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if (onAcBtn != null)
            {
                if (onAcBtn == btnBanHang)
                {
                    return;
                }

                ChangeOldStateBtn(onAcBtn);
            }

            ChangeNewStateBtn(btnBanHang);
            addPnlHover(btnBanHang);

            onAcBtn = btnBanHang;
        }

        private void btnDanhSachLienQuan_Click(object sender, EventArgs e)
        {
            if (onAcBtn != null)
            {
                if (onAcBtn == btnDanhSachLienQuan)
                {
                    return;
                }

                ChangeOldStateBtn(onAcBtn);
            }

            ChangeNewStateBtn(btnDanhSachLienQuan);
            addPnlHover(btnDanhSachLienQuan);

            onAcBtn = btnDanhSachLienQuan;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (onAcBtn != null)
            {
                if (onAcBtn == btnBaoCao)
                {
                    return;
                }

                ChangeOldStateBtn(onAcBtn);
            }

            ChangeNewStateBtn(btnBaoCao);
            addPnlHover(btnBaoCao);

            onAcBtn = btnBaoCao;
        }
    }


    
}
