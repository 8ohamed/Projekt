using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;
using System;
using System.Reflection.Metadata;
using System.Windows.Forms;
using MimeKit;

namespace WinFormsApp1
{
    public partial class MessageViewerForm : Form
    {
        protected string emailContent; // Private field to store email content
        private MimeMessage originalMessage; // Private field to store the original message
        public MessageViewerForm(string content, MimeMessage message)
        {
            InitializeComponent();

            originalMessage = message; // Store the original message
            emailContent = content;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageViewerForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MessageViewerForm_Load called");
            // Set the RichTextBox text to display the email content when the form loads
            ReadMessage.Text = emailContent;

        }



        private void ReadMessage_TextChanged(object sender, EventArgs e)
        {

        }


        private void replyBT_Click(object sender, EventArgs e)
        {

            // Create a new instance of ReplyForm and pass the original message
            reply replyForm = new reply(originalMessage, emailContent);
            // Set the emailContent property

    

            // Show the ReplyForm to allow the user to compose a reply
            replyForm.ShowDialog();
        }
    }
}
