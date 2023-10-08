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
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

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


                if (string.IsNullOrWhiteSpace(userEmail) || !IsValidEmail(userEmail))
                {
                    MessageBox.Show("Please enter a valid recipient email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

            catch (AuthenticationException authEx)
            {
                // Authentication failed due to incorrect password
                MessageBox.Show($"Authentication failed. The password is incorrect. Error: {authEx.Message}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); // To shut the environment when clicking on the X
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
