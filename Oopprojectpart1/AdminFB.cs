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
    public partial class AdminFB : Form
    {
        public AdminFB()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");

        private void label3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from feedback", Con);
            DataTable dt = new DataTable();
            Con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update feedback set fb=@FB where fId=@userrrr";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@userrrr", textBox1.Text);
            Command.Parameters.AddWithValue("@FB", textBox2.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Feedback updated.");
            }
            else
            {
                MessageBox.Show("Can't update feedback!");
            }

            SqlCommand cmd = new SqlCommand("SELECT * from feedback", Con);
            DataTable dt = new DataTable();
            Con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from feedback where fId=@userrrr";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@userrrr", textBox1.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Feedback deleted.");
            }
            else
            {
                MessageBox.Show("Can't delete feedback!");
            }

            SqlCommand cmd = new SqlCommand("SELECT * from feedback", Con);
            DataTable dt = new DataTable();
            Con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            Con.Close();
        }
    }
}
