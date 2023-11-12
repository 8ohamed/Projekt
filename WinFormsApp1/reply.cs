using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MailKit;
using System.Net.Mail;
using System.Text.RegularExpressions;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

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
                var replyMessage = new MimeMessage();

                // Add "Re: " to the subject
                if (!originalMessage.Subject.StartsWith("Re:", StringComparison.OrdinalIgnoreCase))
                    replyMessage.Subject = "Re:" + originalMessage.Subject;
                else
                    replyMessage.Subject = originalMessage.Subject;


                replyMessage.Body = new TextPart("plain")
                {
                    Text = replyBox.Text // Set the message body from your replyBox
                };


                //1


                var fromAddress = originalMessage.From;
                string ADD = fromAddress.ToString();


                string pattern = @"<([^>]*)>";
                // Use Regex.Match to find the first match of the pattern in the input string.
                Match match = Regex.Match(ADD, pattern);
                var to = match.Groups[1].Value;


                var ma = new MailboxAddress(to, to);

                replyMessage.To.Add(ma);




                //2

                // Use SMTP to send the reply
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("smtp.gmail.com",587, SecureSocketOptions.StartTls);
                    smtpClient.Authenticate(useremail, userpassword);
                    using (MailMessage mailMessage = new MailMessage(useremail, to))
                    {
                        smtpClient.Send(replyMessage);
                    }
                    smtpClient.Disconnect(true);
                }


                // Connect to the IMAP server (e.g., Gmail)
                //using (var client = new ImapClient())
                //{

                // client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                // Authenticate with your email and password
                // client.Authenticate(useremail, userpassword);

                // Open the sent folder
                //var sentFolder = client.GetFolder(SpecialFolder.Sent);
                //sentFolder.Open(FolderAccess.ReadWrite);

                // Append the reply message to the sent folder
                //sentFolder.Append(replyMessage);

                // Disconnect from the server
                //client.Disconnect(true);
                //}


                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
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


