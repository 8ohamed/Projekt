using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;

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
                string userPassword = textBoxPassword.Text;

                // Check if both email and password are provided
                if (string.IsNullOrWhiteSpace(userEmail) || string.IsNullOrWhiteSpace(userPassword))
                {
                    MessageBox.Show("Please enter both email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method without attempting to authenticate
                }

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(userEmail, userPassword);

                    // Authentication successful
                    // Here is the code for switching forms when pressing a button 
                    Form2 inbox = new Form2();
                    this.Hide();
                    inbox.Show();
                }
            }
            catch (AuthenticationException)
            {
                // Authentication failed due to incorrect password
                MessageBox.Show("Authentication failed. The password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                // Handle an invalid operation, such as attempting to connect without network
                MessageBox.Show($"An error occurred: {ex.Message}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions here
                MessageBox.Show($"An error occurred while connecting to the server: {ex.Message}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
