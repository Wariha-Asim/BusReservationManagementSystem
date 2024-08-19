using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oopprojectpart1
{
    public partial class passengeraccount : Form
    {
        private readonly SqlConnection Con;
        public passengeraccount()
        {
            InitializeComponent();
            Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");
        }



        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addbalance();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from accounts", Con);
            DataTable dt = new DataTable();
            Con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            Con.Close();
        }


        private void addbalance()
        {
            Con.Open();
            string query = "insert into accounts values(@bbid,@abal)";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@bbid", textBox1.Text);
            Command.Parameters.AddWithValue("@abal", textBox3.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Balance Added");
            }
            else
            {
                MessageBox.Show("Can't add balance!");
            }
        }
    }
}
