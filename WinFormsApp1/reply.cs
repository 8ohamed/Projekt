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
using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;
using System.Net.Mail;

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



        private void sendreplyBT_Click(object sender, EventArgs e)
        {
            try
            {
                var replyMessage = new MimeMessage(originalMessage.To[0],originalMessage.From[0]);

                // Add "Re: " to the subject
                if (!originalMessage.Subject.StartsWith("Re:", StringComparison.OrdinalIgnoreCase))
                    replyMessage.Subject = "Re:" + originalMessage.Subject;
                else
                    replyMessage.Subject = originalMessage.Subject;


                replyMessage.Body = new TextPart("plain")
                {
                    Text = replyBox.Text // Set the message body from your replyBox
                };



                // Create a new MimeMessage for the reply

                replyMessage.From.Add(new MailboxAddress("Your Name", useremail)); // Replace "Your Name" with your name or organization




               
            //        var replyTo = new MailboxAddress(Osender.Name, Osender.Address);
              //      replyMessage.To.Add(replyTo);
                


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


