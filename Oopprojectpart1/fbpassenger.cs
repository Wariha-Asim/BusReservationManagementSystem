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
    public partial class fbpassenger : Form
    {
        public fbpassenger()
        {
            InitializeComponent();
        }

        private void fbpassenger_Load(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into feedback values(@uid, @fb)";

            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@uid", textBox1.Text);
            Command.Parameters.AddWithValue("@fb", textBox2.Text);


            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Feedback added sucessfully!");
            }
            else
            {
                MessageBox.Show("Please fill the values!");
            }
        }
    }
}
