﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhoHang.NCC
{
    public partial class usDsconNCC : UserControl
    {
            public static int realSeclectLeft = 0;
            public usDsconNCC()
            {
                InitializeComponent();
                updatePanelLeft();
            }
            public void updateDataPanelLeft()
            {
                DataTable dt = DataBase_Connect.getData.getDsKhachHang();
                foreach (DataRow r in dt.Rows)
                {

                    optionNCC.Ds us = new optionNCC.Ds(r);
                /*
                    us.MouseHover += Us_MouseHover;
                    us.MouseLeave += Us_MouseLeave;
                    us.MouseClick += Us_MouseClick;
                    us.Dock = DockStyle.Top;
                    pnllstKhachHang.Controls.Add(us);
                */
                }

            }
        
            private void Us_MouseClick(object sender, MouseEventArgs e)
            {
            /*
                optional.uskhachhangkhaiquat us = sender as optional.uskhachhangkhaiquat;
                if (pnlCenter.Controls.Count == 0)
                    pnlCenter.Controls.Add(new KhachHangChiTiet(us.MaKH) { Dock = DockStyle.Fill });
                else
                {
                    if ((pnlCenter.Controls[0] as KhachHangChiTiet).MaKH == us.MaKH)
                        return;
                    else
                    {
                        pnlCenter.Controls.Clear();
                        pnlCenter.Controls.Add(new KhachHangChiTiet(us.MaKH) { Dock = DockStyle.Fill });

                    }
                }
            */
            }

            public static Guna.UI2.WinForms.Guna2Panel VirtualpnllstNCC;
            public static void chooseAllLeft()
            {

                foreach (object obj in VirtualpnllstNCC.Controls)
                {
                /*
                    optional.uskhachhangkhaiquat r = obj as optional.uskhachhangkhaiquat;

                    r.virtualCbk.Checked = true;
                */
                }

            }
            public static void unchooseAllLeft()
            {
                foreach (object obj in VirtualpnllstNCC.Controls)
                {
                /*
                    optional.uskhachhangkhaiquat r = obj as optional.uskhachhangkhaiquat;
                    r.virtualCbk.Checked = false;
                */
                }
            }
            public static Guna.UI2.WinForms.Guna2Panel VirtualpnlToolLeft;
            public static void changeStateLeft()
            {
                if (realSeclectLeft == 0)
                {
                    VirtualpnlToolLeft.Controls.Clear();
                    VirtualpnlToolLeft.Controls.Add(new optionNCC.topleft() { Dock = DockStyle.Fill });
                    return;
                }
                if (realSeclectLeft == 1)
                {
                    VirtualpnlToolLeft.Controls.Clear();
                    VirtualpnlToolLeft.Controls.Add(new optionNCC.topleft() { Dock = DockStyle.Fill });

                }
                optionNCC.ustoplefttool temp = VirtualpnlToolLeft.Controls[0] as optionNCC.ustoplefttool;
                temp.updateState();

            }
            public void updatePanelLeft()
            {
                VirtualpnllstNCC = pnllstKhachHang;
                VirtualpnlToolLeft = pnlToolLeft;
                pnlToolLeft.Controls.Add(new optionNCC.topleft() { Dock = DockStyle.Fill });
                updateDataPanelLeft();
            }

            private void Us_MouseLeave(object sender, EventArgs e)
            {
            /*
                optional.uskhachhangkhaiquat us = sender as optional.uskhachhangkhaiquat;
                us.BackColor = Color.FromArgb(248, 247, 247);
            */
            }

            private void Us_MouseHover(object sender, EventArgs e)
            {
            /*
                optional.uskhachhangkhaiquat us = sender as optional.uskhachhangkhaiquat;
                us.BackColor = Color.FromArgb(232, 232, 232);
            */
            }
        }
    }

