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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
           
           
        }
        void test()
        {
            MessageBox.Show("test 1 test 2 test3");
        }
        void test2()
        {
            MessageBox.Show("test 1 test 2 test3");
        }
        void test3()
        {
            MessageBox.Show("test 1 test 2 test3");
            DataTable dt = dbc.Instance.get("exec GetDsSV");
        }
        void botest()
        {
            MessageBox.Show("ok ban ie");
        }
        void botest1()
        {
            MessageBox.Show("ok ban ie213");
        }
        void botest2()
        {
            MessageBox.Show("ok ban i123e");

        }
    }
}
