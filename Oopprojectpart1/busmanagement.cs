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
    public partial class busmanagement : Form
    {
        public busmanagement()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Insert into bus values(@id,@bname,@bcapacity, @psc, @rrid)";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@id", textBox1.Text);
            Command.Parameters.AddWithValue("@bname", textBox2.Text);
            Command.Parameters.AddWithValue("@bcapacity", textBox3.Text);
            Command.Parameters.AddWithValue("@rrid", textBox4.Text);
            Command.Parameters.AddWithValue("@psc", textBox5.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Bus added sucessfully!");
            }
            else
            {
                MessageBox.Show("Please fill the values!");
            }

            SqlCommand cmd = new SqlCommand("Select * from bus", Con);
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
            string query = "update bus set bName = @bname, bCapacity = @bcapacity, perSeatcost=@psc where bId=@Id";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@Id", textBox1.Text);
            Command.Parameters.AddWithValue("@bname", textBox2.Text);
            Command.Parameters.AddWithValue("@bcapacity", textBox3.Text);
            Command.Parameters.AddWithValue("@psc", textBox5.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Bus Updated!");
            }
            else
            {
                MessageBox.Show("Can't update bus!");
            }

            SqlCommand cmd = new SqlCommand("Select * from bus", Con);
            DataTable dt = new DataTable();
            Con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete bus where bId=@Id";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Bus Deleted!");
            }
            else
            {
                MessageBox.Show("Can't delete bus!");
            }

            SqlCommand cmd = new SqlCommand("Select * from bus", Con);
            DataTable dt = new DataTable();
            Con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from bus", Con);
            DataTable dt = new DataTable();
            Con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
