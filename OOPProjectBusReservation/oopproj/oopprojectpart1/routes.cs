using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectpart1
{
    public partial class routes : Form
    {
        public routes()
        {
            InitializeComponent();
        }

        

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Insert into routes values(@id,@bname,@bcapacity)";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@id", textBox1.Text);
            Command.Parameters.AddWithValue("@bname", textBox2.Text);
            Command.Parameters.AddWithValue("@bcapacity", textBox3.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Route added sucessfully!");
            }
            else
            {
                MessageBox.Show("Please fill the values!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //polymorphism
            Method(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text));
        }

        private void Method(int f, string b, int c)
        {
            Con.Open();
            string query = "update routes set rName = @bname, rDistance = @bcapacity where rId=@Id";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@Id", f);
            Command.Parameters.AddWithValue("@bname", b);
            Command.Parameters.AddWithValue("@bcapacity", c);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Route Updated!");
            }
            else
            {
                MessageBox.Show("Can't update route!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Method(int.Parse(textBox1.Text));
 
        }

        private void Method(int g)
        {
            Con.Open();
            string query = "delete routes where rId=@Id";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@Id", g);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Route Deleted!");
            }
            else
            {
                MessageBox.Show("Can't delete route!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
