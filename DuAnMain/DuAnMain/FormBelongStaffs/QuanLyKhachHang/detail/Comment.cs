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
    public partial class Comment : UserControl
    {
        public int MaKH;
        public Comment(int MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            DataTable dt = DataBase_Connect.getData.getGhiChuKhachHangTheoMa(MaKH);
            if (dt.Rows.Count==0)
            {
                pnlComment.Controls.Add(new detail.Comment_detail.usCommentWrite() { Dock=DockStyle.Fill});
            }
            else
            {
                
                foreach(DataRow r in dt.Rows)
                {
                    Comment_detail.usCommentDetail us = new Comment_detail.usCommentDetail();
                    us.virtualtxtComment.Text = r["GhiChu"].ToString();
                    us.virtualLblTime.Text = r["ThoiGian"].ToString();
                    string TenND = DataBase_Connect.getData.getNhanVienTheoMaTaiKhoan(int.Parse(r["MaTaiKhoan"].ToString()))["TenNV"].ToString();
                    us.virtualLblBy.Text = TenND;
                    us.Dock = DockStyle.Top;
                    
                    pnlComment.Controls.Add(us);

                    //us.virtualLblBy.Text=
                }
                pnlComment.Controls.Add(new detail.Comment_detail.usCommentWrite() { Dock = DockStyle.Top });
            }
        }
        public  void UpdateState()
        {
            DataTable dt = DataBase_Connect.getData.getGhiChuKhachHangTheoMa(this.MaKH);
        }
    }
}
