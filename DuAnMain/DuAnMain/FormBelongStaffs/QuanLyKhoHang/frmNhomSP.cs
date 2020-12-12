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
    public partial class frmNhomSP : Form
    {
        public frmNhomSP()
        {
            InitializeComponent();
        }

        private void frmQuanLyKhoSP_Load(object sender, EventArgs e)
        {
            List<string> ts = new List<string>()
            {
                { "Tất cả các nhóm mặt hàng"},
                { "Nhóm mặt hàng có hiệu lực"},
                { "Nhóm mặt hàng không có hiệu lực"}
            };
            cmbnhommathang.DataSource = ts;
        }

        private void cmbnhommathang_DropDown(object sender, EventArgs e)
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
    }
}
