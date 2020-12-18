using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang
{
    public partial class usDanhSachKhachHang : UserControl
    {
        public static int realSeclectLeft = 0;
        public usDanhSachKhachHang()
        {
            InitializeComponent();
            updatePanelLeft();
        }
        public void updateDataPanelLeft()
        {
            DataTable dt = DataBase_Connect.dbc.Instance.get("select * from khachhang");
            foreach (DataRow r in dt.Rows)
            {

                optional.uskhachhangkhaiquat us = new optional.uskhachhangkhaiquat(r);
                us.MouseHover += Us_MouseHover;
                us.MouseLeave += Us_MouseLeave;
                us.Dock = DockStyle.Top;
                pnllstKhachHang.Controls.Add(us);
            }

        }
        public static Guna.UI2.WinForms.Guna2Panel VirtualpnlToolLeft;
        public static void changeStateLeft()
        {
            if (realSeclectLeft==0)
            {
                VirtualpnlToolLeft.Controls.Clear();
                VirtualpnlToolLeft.Controls.Add(new optional.usTopLeft() { Dock = DockStyle.Fill });
                return;
            }    
            if (realSeclectLeft==1)
            {
                VirtualpnlToolLeft.Controls.Clear();
                VirtualpnlToolLeft.Controls.Add(new optional.usTopLeftTool() { Dock=DockStyle.Fill});

            }    
       
        }
        public void updatePanelLeft()
        {
            VirtualpnlToolLeft = pnlToolLeft;
            pnlToolLeft.Controls.Add(new optional.usTopLeft() { Dock=DockStyle.Fill});
            updateDataPanelLeft();
        }

        private void Us_MouseLeave(object sender, EventArgs e)
        {
            optional.uskhachhangkhaiquat us = sender as optional.uskhachhangkhaiquat;
            us.BackColor = Color.FromArgb(248, 247, 247);
        }

        private void Us_MouseHover(object sender, EventArgs e)
        {
            optional.uskhachhangkhaiquat us = sender as optional.uskhachhangkhaiquat;
            us.BackColor = Color.FromArgb(232, 232, 232);
        }
    }
}
