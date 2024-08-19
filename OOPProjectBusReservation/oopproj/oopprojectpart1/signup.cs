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

namespace oopprojectpart1
{
    public partial class signup : Form
    {
        private readonly SqlConnection Con;

        public signup()
        {
            InitializeComponent();
            Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Insert into users values(@id,@user,@Password)";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@id", textBox3.Text);
            Command.Parameters.AddWithValue("@user", textBox1.Text);
            Command.Parameters.AddWithValue("@Password", textBox2.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Sucessfully signed up!");
            }
            else
            {
                MessageBox.Show("Can't sign up!");
            }
        }
    }
}
