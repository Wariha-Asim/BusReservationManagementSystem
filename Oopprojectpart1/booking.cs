using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace oopprojectpart1
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=BRMSFinal1;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Polymorphism - method overloading 
                methodoverloading(int.Parse(textBox1.Text), int.Parse(textBox3.Text), textBox2.Text, int.Parse(textBox5.Text));

                // Display updated booking information in the DataGridView
                DisplayBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void methodoverloading(int f, int b, string c, int e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                SqlCommand cmd2 = new SqlCommand("EXEC CreateBooking1 @id, @bname, @bcapacity, @userid;", Con);
                cmd2.Parameters.AddWithValue("@id", f);
                cmd2.Parameters.AddWithValue("@bname", c);
                cmd2.Parameters.AddWithValue("@bcapacity", b);
                cmd2.Parameters.AddWithValue("@userid", e);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while booking: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private void DisplayBookings()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                SqlCommand cmd = new SqlCommand("SELECT bk.rrId, bk.bookid, bk.pName, bs.bName, bk.seats FROM booking bk JOIN bus bs ON bk.rrId = bs.routeId;", Con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying bookings: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                // Capture the values from the textboxes
                int bookingId = int.Parse(textBox4.Text); // Assuming this is the booking ID
                int routeId = int.Parse(textBox1.Text); // Assuming this is the route ID

                // Execute the stored procedure to cancel the booking
                SqlCommand cmd1 = new SqlCommand("EXEC CancelBooking1 @booking_id, @route_id;", Con);
                cmd1.Parameters.AddWithValue("@booking_id", bookingId);
                cmd1.Parameters.AddWithValue("@route_id", routeId);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Booking canceled successfully!");

                // Display updated booking information in the DataGridView
                DisplayBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while canceling booking: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                SqlCommand cmd = new SqlCommand("SELECT r.rId, r.rName, b.bName, b.bCapacity, b.perSeatcost, r.rDistance FROM bus b JOIN routes r ON b.routeId = r.rId;", Con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading routes: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DisplayBookings();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic if needed when textBox1 changes
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic if needed when textBox2 changes
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic if needed when textBox3 changes
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic if needed when textBox4 changes
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic if needed when textBox5 changes
        }

        private void booking_Load(object sender, EventArgs e)
        {
            // Optional: Add logic for form load event if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Add logic if needed when label2 is clicked
        }
    }
}
