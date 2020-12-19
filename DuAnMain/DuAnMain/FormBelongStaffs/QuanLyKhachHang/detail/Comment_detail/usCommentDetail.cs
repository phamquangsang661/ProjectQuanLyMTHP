using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.detail.Comment_detail
{
    public partial class usCommentDetail : UserControl
    {
        public usCommentDetail()
        {
            InitializeComponent();
            virtualBtnDelete = btnDelete;
            virtualLblTime = lblTime;
            virtualLblBy = lblByName;
            virtualtxtComment = txtComment;
        }
        public  Guna.UI.WinForms.GunaLabel virtualLblTime;
        public Guna.UI.WinForms.GunaLabel virtualLblBy;
        public Guna.UI2.WinForms.Guna2PictureBox virtualBtnDelete;
        public Guna.UI2.WinForms.Guna2TextBox virtualtxtComment;
       
    }
}
