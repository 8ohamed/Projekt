
using System.Net.Mail;
using System.Net;
using MailKit.Security;
//using MailKit.Net.Smtp;
//using MailKit.Security;
namespace WinFormsApp1
{



    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            sign_out.Click += sign_out_Click;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).

        }

        private void HomeFcompose_Click(object sender, EventArgs e)
        {
            Form2 Home = new Form2();
            this.Hide();
            Home.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void SendBT_Click(object sender, EventArgs e)
        {

            string recipientEmail = receiverAdress.Text;


            string subject = Subjectbox.Text;
            string message = Messagebox.Text;
            string useremail = Properties.Settings.Default.current_username;
            string userpassword = Properties.Settings.Default.current_password;


            try
            {
                if (string.IsNullOrWhiteSpace(useremail) || !IsValidEmail(useremail))
                {
                    MessageBox.Show("Please enter a valid sender email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Input validation
                if (string.IsNullOrWhiteSpace(recipientEmail) || !IsValidEmail(recipientEmail))
                {
                    MessageBox.Show("Please enter a valid recipient email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show("Please enter a subject and message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587; // Port for Gmail SMTP
                    smtpClient.Credentials = new NetworkCredential(useremail, userpassword);
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage(useremail, recipientEmail))
                    {
                        mailMessage.Subject = subject;
                        mailMessage.Body = message;
                        // Clear the input fields after sending the email
                        receiverAdress.Text = ""; // Clear the recipient email TextBox
                        Subjectbox.Text = "";    // Clear the subject TextBox
                        Messagebox.Text = "";    // Clear the message TextBox
                        // Send the email
                        smtpClient.Send(mailMessage);

                        MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


            catch (SmtpException smtpEx)
            {
                MessageBox.Show("SMTP Error: " + smtpEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AuthenticationException authEx)
            {
                MessageBox.Show("Authentication Error: " + authEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void receiverAdress_TextChanged(object sender, EventArgs e)
        {

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

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void Messagebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



