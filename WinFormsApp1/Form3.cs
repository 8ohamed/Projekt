using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WinFormsApp1
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

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

            // Email subject and message

            string subject = Subjectbox.Text;
            string message = Messagebox.Text;
            string useremail = Properties.Settings.Default.current_username;

            string userpassword = Properties.Settings.Default.current_password;

            // Create a new SmtpClient instance
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, // Port for Gmail SMTP
                Credentials = new NetworkCredential(useremail, userpassword),
                EnableSsl = true,
            };

            // Create a new MailMessage
            MailMessage mailMessage = new MailMessage(useremail, recipientEmail)
            {
                Subject = subject,
                Body = message,
            };

            // Send the email
            smtpClient.Send(mailMessage);

            MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // catch (Exception ex)
        //{
        //     MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}


    }
}
   

