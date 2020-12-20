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
      
        public Guna.UI2.WinForms.Guna2Panel virtualPnlMask
        {
            get
            {
                return virtualPnl;
            }
            set
            {
                virtualPnl = value;
                this.width = value.Width;
                this.height = value.Height;
               
                this.div = height / interval;
                virtualPnl.Bounds = new System.Drawing.Rectangle(virtualPnl.Location.X, virtualPnl.Location.Y, 0, 0);
            }
        }


        public Guna.UI2.WinForms.Guna2Panel virtualPnl;
        public int width;

        public int height;
     
        private float div;
        public Timer tm=new Timer();
        public int statePnl;
        public int interval;
       
        public PanelSlicer(int interval=20)
        {

            tm.Interval = 1;            
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

                    virtualPnl.Bounds = new System.Drawing.Rectangle(virtualPnl.Location.X, virtualPnl.Location.Y, virtualPnl.Width, virtualPnl.Height + 1);


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
                        virtualPnl.Bounds = new System.Drawing.Rectangle(virtualPnl.Location.X, virtualPnl.Location.Y, virtualPnl.Width, 0);
                      
                    }
                    else
                    {
                        virtualPnl.Bounds = new System.Drawing.Rectangle(virtualPnl.Location.X, virtualPnl.Location.Y, virtualPnl.Width, virtualPnl.Height-1);
                    }
                   
                }
                else
                {
                    statePnl = 0;
                    
                    tm.Stop();
                    
                }
            }    
        }

        public void Show()
        {
            if (statePnl == 0)
            {

                
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
