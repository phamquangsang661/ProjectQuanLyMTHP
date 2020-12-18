using DuAnMain.FormBelongStaffs;
using DuAnMain.FormBelongStaffs.QuanLyBanTraHang;
using DuAnMain.FormBelongStaffs.QuanLyKhoHang;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain
{
    public partial class FormStaffs : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Panel currentSubPanel=null;
        private Form currentChildForm=null;
        public FormStaffs()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelMenuControl.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Text = String.Empty;
           
            realclock.Start();
            DisableAllSubMenu();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(245, 180, 91);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            
            if(senderBtn !=null)
            {
                DisableAllSubMenu();
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(99, 101, 181);

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(122, 121, 218);
            }
        }
        /// <summary>
        /// Hàm để tạo form và cho vào panel, chỉ cần gọi và truyền form
        /// </summary>
        /// <param name="childForm">Tham số là 1 form </param>
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm!=null)
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pbLogo_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            if (currentChildForm != null)
                currentChildForm.Close();
            currentSubPanel.Visible = false;
        }
        private void DisableAllSubMenu()
        {
            
            panelsubQuanLyBanTraHang.Visible = false;
            panelSubMenuQuanLySuaChua.Visible = false;
            panelSubMenuQuanLyKhoHang.Visible = false;
            panelSubMenuCongTy.Visible = false;
            panelSubMenuQuanLyCongNo.Visible = false;
            panelSubMenuQuanLyKhachHang.Visible = false;
            panelSubMenuThongKe.Visible = false;
            panelSubMenuQuanLyTaiSan.Visible = false;
            panelSubMenuQuanLyThuChi.Visible = false;
            panelSubMenuBaoCaoDoanhSo.Visible = false;
        }
        private void ActivitySubMenu(Panel pl)
        {

            if (pl == currentSubPanel)
            {
                if (pl.Visible == false)
                    pl.Visible = true;
                return;
            }
            if (currentSubPanel != null)
                currentSubPanel.Visible =false;
            currentSubPanel = pl;
            currentSubPanel.Visible = true;
        }
        private void subQuanLyBanTraHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new FormBelongStaffs.testForm());
            ActivitySubMenu(panelsubQuanLyBanTraHang);
        
        }

        private void subQuanLySuaChua_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuQuanLySuaChua);
        }

        private void subQuanLyKhoHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuQuanLyKhoHang);
        }

        private void subQuanLyNhanSu_Click(object sender, EventArgs e)
        {
        }

        private void subQuanLyThuChi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuQuanLyThuChi);
        }

        private void subQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuQuanLyKhachHang);
        }

        private void subQuanLyTaiSan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuQuanLyTaiSan);
        }

        private void subQuanLyCongNo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuQuanLyCongNo);
        }

        private void subBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuBaoCaoDoanhSo);
        }

        private void subCongTy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuCongTy);
        }

        private void subHeThong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void subTroGiup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }
     

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void realclock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmKienHang f = new frmKienHang();
            f.Show();
        }

        private void subQuanLyCongViec_Click(object sender, EventArgs e)
        {

            

        }

        private void subThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ActivitySubMenu(panelSubMenuThongKe);
        }

        private void btnDanhSachSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKienHang());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(new fmNCC() { Dock=DockStyle.Fill });

        }

        private void btnDanhSachKhoSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyKhoSP());
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(new FormBelongStaffs.QuanLyKhachHang.usDanhSachKhachHang() { Dock=DockStyle.Fill });
            
            
        }

        private void btnDoanhSoBanHang_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeThuChi_Click(object sender, EventArgs e)
        {

        }

      
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                lblSearch.Text = "";
                pbSearch.Visible = false;
            }
            else
            {
                lblSearch.Text = "Search";
                pbSearch.Visible = true;
            }
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
  
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(new fmQuanLyKhoSP());
        }

        private void btnnhomSP_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(new fmNhomSP());
        }

     //// ////////////////////////////////////////////////////////
    
        
       

        private void btnDanhSachSanPham_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            frmKienHang f = new frmKienHang();
            f.Show();
        }
    }
}
