using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;
namespace WinFormsApp1
{
    public partial class forward : Form
    {
        private MimeMessage originalMessage;
        private string emailContent; // Add a field to store email content
        public forward(MimeMessage originalMessage, string emailContent)
        {
            InitializeComponent();
            this.originalMessage = originalMessage;
            this.emailContent = emailContent; // Assign the email content
        }

        private void forward_Load(object sender, EventArgs e)
        {
            forwardbox.Text = emailContent;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forwardbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reciever_TextChanged(object sender, EventArgs e)
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
        private void SendBT_Click(object sender, EventArgs e)
        {
            string recipientEmail = reciever.Text;

            // Email subject and message

            string subject = "Forwarded:" + originalMessage.Subject;
            string message = ("Original sender is") + "\n" + forwardbox.Text;
            string useremail = Properties.Settings.Default.current_username;
            string userpassword = Properties.Settings.Default.current_password;


            try
            {
              
                // Input validation
                if (string.IsNullOrWhiteSpace(recipientEmail) || !IsValidEmail(recipientEmail))
                {
                    MessageBox.Show("Please enter a valid recipient email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                       
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
    }
}
