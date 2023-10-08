using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;

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
  

        private void reply_Load(object sender, EventArgs e)
        {
            replyBox.Text = "\n"+ "\n" + "\n" + emailContent;

        }
        string useremail = Properties.Settings.Default.current_username;
        string userpassword = Properties.Settings.Default.current_password;

        private MimeMessage GetOriginalMessage()
        {
            return originalMessage;
        }

        private void sendreplyBT_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new MimeMessage for the reply
                var replyMessage = new MimeMessage();

                replyMessage.From.Add(new MailboxAddress("Your Name", useremail)); // Replace "Your Name" with your name or organization


               // replyMessage.To.Add(new MailboxAddress("reciever", originalMessage.Sender));
                // Create a MailboxAddress for the "To" address
               

                // Add "Re: " to the subject
                if (!originalMessage.Subject.StartsWith("Re:", StringComparison.OrdinalIgnoreCase))
                    replyMessage.Subject = "Re:" + originalMessage.Subject;
                else
                    replyMessage.Subject = originalMessage.Subject;
                    


                replyMessage.Body = new TextPart("plain")
                {
                    Text = replyBox.Text // Set the message body from your replyBox
                };

                // Connect to the IMAP server (e.g., Gmail)
                using (var client = new ImapClient())
                {

                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                    // Authenticate with your email and password
                    client.Authenticate(useremail, userpassword);

                    // Open the inbox folder
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadWrite);

                    // Append the reply message to the inbox
                    inbox.Append(replyMessage);

                    // Disconnect from the server
                    client.Disconnect(true);
                }


                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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


