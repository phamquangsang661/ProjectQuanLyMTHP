using DuAnMain.DataBase_Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animateLogin.HideSync(p2);
       

            animateLogin.ShowSync(p3);
         

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            animateLogin.HideSync(p3);
            animateLogin.ShowSync(p2);
        }
    }
}
