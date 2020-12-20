using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.FormBelongStaffs.QuanLyKhachHang.MyControl
{
    class PanelSlicer
    {
        public Guna.UI2.WinForms.Guna2Panel virtualPnl;
        public int width;

        public int height;
     
        private float div;
        public Timer tm=new Timer();
        public int statePnl;
        public int interval;
       
        public PanelSlicer(Guna.UI2.WinForms.Guna2Panel pnl,int interval=20)
        {
            virtualPnl = pnl;
            
            this.width = pnl.Width;
            this.height = pnl.Height;
            tm.Interval = 200;
            this.div = height / interval;
            virtualPnl.Height = 0;
            virtualPnl.Visible = false;
            this.interval = interval;
            tm.Tick += Tm_Tick;
            statePnl = 0;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            if (statePnl==0)
            {
                MessageBox.Show(virtualPnl.Height+"");
                if(virtualPnl.Height<this.height)
                {
                    virtualPnl.Height += 1;
                }    
                else
                {
                    statePnl = 1;
                    tm.Stop();
                }    
            }    
            else
            {
                if (virtualPnl.Height > 0)
                {

                    int temp = virtualPnl.Height-1;
                    if (temp<0)
                    {
                        virtualPnl.Height = 0;
                    }
                    else
                    {
                        virtualPnl.Height -= (int)(this.div);
                    }    
                }
                else
                {
                    statePnl = 0;
                    virtualPnl.Visible = false;
                    tm.Stop();
                    
                }
            }    
        }

        public void Show()
        {
            if (statePnl == 0)
            {
           
                virtualPnl.Visible = true;
                MessageBox.Show("Bắt đầu");
                tm.Start();
            }
        }
        public void Hide()
        {
            if (statePnl == 1)
            {
                tm.Start();
            }
        }

    }
}
