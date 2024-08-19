using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oopprojectpart1
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT COUNT(*) FROM users WHERE username = @user AND password = @pass";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@user", textBox1.Text);
            Command.Parameters.AddWithValue("@pass", textBox2.Text);
            using (SqlDataReader reader = Command.ExecuteReader())
            {
                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful!");
                        passengerpanel F3 = new passengerpanel();
                        F3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password");
                    }

                }

            }
            Con.Close();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
