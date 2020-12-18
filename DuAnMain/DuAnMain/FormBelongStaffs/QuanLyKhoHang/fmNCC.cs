using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang
{
    public partial class fmNCC : UserControl
    {
        public fmNCC()
        {
            InitializeComponent();
            updatedata();
        }
        private void updatedata()
        {
            DataTable dt = DataBase_Connect.dbc.Instance.get("select * from nhacungcap");
            grncc.DataSource = dt;

        }

        private void Us_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Us_MouseHover(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void fmNCC_Load(object sender, EventArgs e)
        {
            List<string> ts = new List<string>()
            {
                { "Tất cả nhà cung cấp"},
                { "Các nhà cung cấp máy tính"},
                { "Các nhà cung cấp phụ kiện"},
            };
            cmbNCC.DataSource = ts;
        }

        private void gunabtnthemNCC_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 1;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 0;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 0;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            pageNCC.PageIndex = 2;
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunabtnmenu_Click(object sender, EventArgs e)
        {
            Panel pn = new Panel();
            pn.Size = new Size(200, 255);
            pn.Location = new Point(793, 6);
            pn.Controls.Add(new Button());
        }

        private void pagethem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
