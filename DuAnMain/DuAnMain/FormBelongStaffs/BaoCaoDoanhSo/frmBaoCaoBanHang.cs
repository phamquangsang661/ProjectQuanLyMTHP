using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.BaoCaoDoanhSo
{
    public partial class frmBaoCaoBanHang : UserControl
    {
        public frmBaoCaoBanHang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoBanHang_Load(object sender, EventArgs e)            // Đây là hàm hiện các mục trong combobox
        {
            List<string> ts = new List<string>()
            {
                { "Doanh thu theo khách hàng" },
                { "Doanh thu theo mặt hàng" },
                { "Doanh thu theo nhân viên bán hàng" },
                { "Lịch sử đóng gói" },
            };
            cmbBaoCaoBanHang.DataSource = ts;
        }

        private void cmbBaoCaoBanHang_DropDown(object sender, EventArgs e)          // Đây là hàm dãn combobox của Đức (nhưng nó vẫn ko co vì lí do nào đó :)))
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

        public void updateDataPanelLeft()          // Đây là hàm update panel bên trái của Sáng
        {
            DataTable dt = DataBase_Connect.getData.getDsKhachHang();
            foreach (DataRow r in dt.Rows)
            {
                
            }
        }

    }
}
