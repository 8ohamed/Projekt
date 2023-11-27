using MimeKit;
using System.Net;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MailKit;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class reply : Form
    {
        private MimeMessage originalMessage;
        private string emailContent; // Add a field to store email content
        public reply(MimeMessage originalMessage,string emailContent)
        {
            InitializeComponent();
            this.originalMessage = originalMessage;
            this.emailContent = emailContent; // Assign the email content

        }


        private void reply_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void reply_Load(object sender, EventArgs e)
        {
            replyBox.Text = "\n"+ "\n" + "\n" + emailContent;

        }
        string useremail = Properties.Settings.Default.current_username;
        string userpassword = Properties.Settings.Default.current_password;



        private void sendreplyBT_Click(object sender, EventArgs e)
        {

            try
            {
                var fromAddress = originalMessage.From;
                string ADD = fromAddress.ToString();
                string pattern = @"<([^>]*)>";
                Match match = Regex.Match(ADD, pattern);
                var to = match.Groups[1].Value;


                // Email subject and message
                string recipientEmail = to;
                string subject = "Re:" + originalMessage.Subject;
                string message = replyBox.Text;
                string useremail = Properties.Settings.Default.current_username;
                string userpassword = Properties.Settings.Default.current_password;

                using (System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com"))
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
                        this.Hide();
                    }
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error \n please try agian later", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void replyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


