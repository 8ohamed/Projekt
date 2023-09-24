using MailKit.Net.Smtp;
using MailKit.Security;

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
            try
            {

                // Retrieve user input from the textboxes
                string userEmail = textBoxEmail.Text;
                Properties.Settings.Default.current_username = userEmail;
                string userPassword = textBoxPassword.Text;
                Properties.Settings.Default.current_password = userPassword;

                SmtpClient client = new SmtpClient();

                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);

                client.Authenticate(userEmail, userPassword);


 

            }
            catch { 
            
            
            }
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