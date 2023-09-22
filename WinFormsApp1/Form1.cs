namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            // Retrieve user input from the textboxes
            string userEmail = textBoxEmail.Text;
            string userPassword = textBoxPassword.Text;
            Form3 form3 = new Form3();
            form3.userEmail = textBoxEmail.Text;
            form3.userPassword = textBoxPassword.Text;
            form3.Show();


            // Here is the code for switching forms when pressing a button 
            Form2 Home = new Form2();


            this.Hide();
            Home.Show();



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}