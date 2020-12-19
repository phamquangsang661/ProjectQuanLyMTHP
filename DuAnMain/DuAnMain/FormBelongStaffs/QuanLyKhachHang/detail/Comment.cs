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
                pnlComment.Controls.Add(new detail.Comment_detail.usCommentWrite() { Dock = DockStyle.Top });
                foreach(DataRow r in dt.Rows)
                {
                    Comment_detail.usCommentDetail us = new Comment_detail.usCommentDetail();
                    us.virtualtxtComment.Text = r["GhiChuKhachHang"].ToString();
                    us.virtualLblTime.Text = r["ThoiGian"].ToString();
                    //us.virtualLblBy.Text=
                }
            }
        }
        public  void UpdateState()
        {
            DataTable dt = DataBase_Connect.getData.getGhiChuKhachHangTheoMa(this.MaKH);
        }
    }
}
