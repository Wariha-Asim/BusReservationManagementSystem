using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectpart1
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busmanagement b1 = new busmanagement();
            b1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            routes R = new routes();
            R.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminFB ab = new AdminFB();
            ab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustoInfo ci = new CustoInfo();
            ci.Show();
        }
    }
}
