namespace oopprojectpart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login F = new login();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup F1 = new signup();
            //this.Hide();
            F1.Show();/*Dialog();*/
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login1 F2 = new login1();
            F2.Show();
        }
    }
}