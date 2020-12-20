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
        public float width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public float height
        {
            get
            {
                return this.width;
            }
            set
            {
                this.height = value;
                this.div = height / interval;
            }
        }
        private float div;
        public Timer tm;
        private int statePnl;
        public int interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                this.interval = value;
                this.div = height / interval;
            }
        }
        public PanelSlicer(Guna.UI2.WinForms.Guna2Panel pnl,int interval=20)
        {
            virtualPnl = pnl;
            this.width = virtualPnl.Width;
            this.height = virtualPnl.Height;
            this.interval = interval;
            tm.Tick += Tm_Tick;
            statePnl = 0;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            if (statePnl==0)
            {
                if(virtualPnl.Height<this.height)
                {
                    virtualPnl.Height += (int)(this.div);
                }    
                else
                {
                    statePnl = 1;
                    tm.Stop();
                }    
            }    
            else
            {
                if (virtualPnl.Height >0)
                {

                    int temp = virtualPnl.Height-(int)(this.div);
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
                    statePnl = 1;
                    tm.Stop();
                }
            }    
        }

        public void Show()
        {
       
            virtualPnl.Height = 0;
            virtualPnl.Visible = true;
            tm.Start();
        }
        public void Hide()
        {
        }

    }
}
