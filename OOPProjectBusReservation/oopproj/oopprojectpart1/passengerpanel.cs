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
    public partial class passengerpanel : Form
    {
        public passengerpanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            booking bb = new booking();
            bb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fbviewpassenger fbv = new fbviewpassenger();
            fbv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fbpassenger fb1 = new fbpassenger();
            fb1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            routespassenger rp = new routespassenger();
            rp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passengeraccount pa = new passengeraccount();
            pa.Show();
        }
    }
}
