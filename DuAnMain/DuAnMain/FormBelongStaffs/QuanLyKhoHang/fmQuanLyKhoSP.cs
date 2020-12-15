using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang
{
    public partial class fmQuanLyKhoSP : UserControl
    {
        public fmQuanLyKhoSP()
        {
            InitializeComponent();
        }

        private void cmbSP_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }

                if (senderComboBox.Width < newWidth)
                {
                    senderComboBox.Width = newWidth + SystemInformation.VerticalScrollBarWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

        private void fmQuanLyKhoSP_Load(object sender, EventArgs e)
        {
            List<string> ts = new List<string>()
            {
                { "Tất cả các mặt hàng"},
                { "Các mặt hàng có hiệu lực"},
                { "Các mặt hàng chưa nhóm"},
                { "Các mặt hàng cạn hàng"},
                { "Các mặt hàng tồn kho"},
                { "Các mặt hàng ngoài tồn kho"},
                { "Các mặt hàng đã bán"},
                { "Các mặt hàng có thể trả lại"},
                { "Các mặt hàng không thể trả lại"},
                { "Nhóm mặt hàng không có hiệu lực"}
            };
            cmbSP.DataSource = ts;
        }
    }
}
