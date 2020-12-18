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
    public partial class Overview : UserControl
    {
        public int MaKH;
        public Overview(int MaKH)
        {
            InitializeComponent();


            //set variable
            this.MaKH = MaKH;
            btnDiaChi.Tag = 0;
            btnChiTietKhac.Tag = 0;
            createEvent();
            createControl();
        }
        public void createEvent()
        {
            DataRow r = DataBase_Connect.getData.getKhachHangTheoMa(MaKH);
            lblTen.Text = r["TenKhachHang"].ToString();
            lblEmail.Text = r["Email"].ToString();
            lblphone.Text = r["SoDienThoai"].ToString();
            lblNameMain.Text= r["TenKhachHang"].ToString();
        }
        public void createControl()
        {
            pnlDiaChi.Controls.Add(new Overview_detail.usDiaChi(MaKH));
            gtranpnl.Hide(pnlDiaChi);
            
        }

       
        private void btnFun_MouseLeave(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuLabel lbl = sender as Bunifu.UI.WinForms.BunifuLabel;
            lbl.ForeColor = Color.FromArgb(84, 153, 235);
        }

        private void btnHover_MouseHover(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuLabel lbl = sender as Bunifu.UI.WinForms.BunifuLabel;
            lbl.ForeColor = Color.FromArgb(55, 127, 194);
            
        }

        private void btnDiaChi_Click(object sender, EventArgs e)
        {
            if(int.Parse(btnDiaChi.Tag.ToString())==0)
            {
                btnDiaChi.Image = imgl.Images[1];
                gtranpnl.ShowSync(pnlDiaChi);
                btnDiaChi.Tag = 1;
               
            }    
            else
            {
                btnDiaChi.Image = imgl.Images[0];
                gtranpnl.HideSync(pnlDiaChi);
               
                btnDiaChi.Tag = 0;
               
            }    
        }

        private void btnChiTietKhac_Click(object sender, EventArgs e)
        {

        }
    }
}
