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
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunalbNCC_Click(object sender, EventArgs e)
        {
        }
        private void frmNCC_Load(object sender, EventArgs e)
        {
            
            List<string> ts = new List<string>()
            {
                { "Tất cả nhà cung cấp"},
                { "Các nhà cung cấp máy tính"},
                { "Các nhà cung cấp phụ kiện"},
            };
            cmbNCC.DataSource = ts;
        }

        private void cmbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbNCC_DropDown(object sender, EventArgs e)
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

        private void gunabtnthemNCC_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 1;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 0;
        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
