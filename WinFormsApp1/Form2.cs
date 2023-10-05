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
using MailKit;
using MimeKit;
using MailKit.Security;
using System.ComponentModel.DataAnnotations;
using MailKit.Search;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private List<string> folderNames = new List<string>(); // Declare folderNames at the class level
        private List<MimeMessage> messages = new List<MimeMessage>(); // Declare messages at the class level
        private string currentFolder; // Declare currentFolder at the class level
        public Form2()
        {
            InitializeComponent();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            sign_out.Click += sign_out_Click;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            // Disable the "Move" button initially
            moveButton.Enabled = false;
        }

        private void InboxBT1_Click(object sender, EventArgs e)
        {
            Form3 Compose = new Form3();
            this.Hide();
            Compose.Show();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            RetrieveFolders(); // Call this method to retrieve folders when the form loads

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }





        private void RetrieveFolders()
        {
            try
            {
                // Clear the existing items in the folderNames list
                folderNames.Clear();

                // Retrieve the username and password
                string useremail = Properties.Settings.Default.current_username;
                string userpassword = Properties.Settings.Default.current_password;

                using (var client = new ImapClient())
                {
                    // Connect to the IMAP server (e.g., Gmail)
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                    // Authenticate with the email account
                    client.Authenticate(useremail, userpassword);

                    // Check if there are any personal namespaces available
                    if (client.PersonalNamespaces.Count > 0)
                    {
                        // Get the list of folders from the first personal namespace
                        var folders = client.GetFolders(client.PersonalNamespaces[0]);

                        // Populate the folders_Box list box with folder names and folderNames list
                        foreach (var folder in folders)
                        {
                            folders_Box.Items.Add(folder.FullName);
                            folderNames.Add(folder.FullName); // Add folder names to the folderNames list
                        }
                    }
                    else
                    {
                        // Handle the case where no personal namespaces are available
                        MessageBox.Show("No personal namespaces available.");
                    }

                    // Disconnect from the server when done
                    client.Disconnect(true);
                }
            }
            catch (ImapCommandException imapEx)
            {
                MessageBox.Show($"IMAP Command Error: {imapEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RetrieveMessages(string folderName)
        {
            try
            {
                // to retrieve the username and password
                string useremail = Properties.Settings.Default.current_username;
                string userpassword = Properties.Settings.Default.current_password;

                using (var client = new ImapClient())
                {
                    // Connect to the IMAP server (e.g., Gmail)
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                    // Authenticate with the email account
                    client.Authenticate(useremail, userpassword);

                    // Get the selected folder
                    var folder = client.GetFolder(folderName);

                    if (folder != null)
                    {
                        // Open the folder in read-write mode
                        folder.Open(FolderAccess.ReadOnly);

                        // Retrieve messages
                        var messages = folder.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope);

                        foreach (var message in messages)
                        {
                            if (message.Envelope.Subject != null)
                            {
                                messages_box.Items.Add(message.Envelope.Subject);
                            }
                            else
                            {
                                messages_box.Items.Add("<No Subject>");
                            }
                        }

                        // Close the folder when done
                        folder.Close();
                    }

                    // Disconnect from the server when done
                    client.Disconnect(true);
                }
            }
            catch (ImapCommandException imapEx)
            {
                MessageBox.Show($"IMAP Command Error: {imapEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void folders_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFolder = folders_Box.SelectedItem as string; // Set the currentFolder when a folder is selected
            RetrieveMessages(currentFolder);

            // Clear the messages_box when a new folder is selected
            messages_box.Items.Clear();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string selectedFolderName = folders_Box.SelectedItem as string;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            // Check if a folder is selected
            if (!string.IsNullOrEmpty(selectedFolderName))
            {
                // Retrieve messages from the selected folder
                RetrieveMessages(selectedFolderName);
            }
        }


        private void messages_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (messages_box.SelectedItem is MessageSummary selectedMessage)
            {
                var selectedEmailId = selectedMessage.UniqueId;
                // Now you have the selectedEmailId, and you can use it to move the email.
                
            }
            int selectedIndex = messages_box.SelectedIndex;

            if (selectedIndex >= 0)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string selectedFolderName = folders_Box.SelectedItem as string;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                using (var client = new ImapClient())
                {
                    string useremail = Properties.Settings.Default.current_username;
                    string userpassword = Properties.Settings.Default.current_password;

                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(useremail, userpassword);

                    var folder = client.GetFolder(selectedFolderName);
                    folder.Open(FolderAccess.ReadOnly);

                    var message = folder.GetMessage(selectedIndex);
                    // Enable the "Move" button since an email is selected
                    moveButton.Enabled = true;
                    // Display the message content in the messageContentTextBox
                    messageContentTextBox.Text = message.TextBody; // You can customize this based on the message format (HTML, plain text, etc.)
                }
            }
            else
            {
                // If no message is selected, clear the messageContentTextBox
                messageContentTextBox.Clear();
                // Enable the "Move" button since an email is selected
                moveButton.Enabled = false;
            }
        }



        private void messageContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }




        private void MoveEmailToFolder(UniqueId emailId, string sourceFolder, string destinationFolder)
        {
            if (emailId == null || string.IsNullOrEmpty(sourceFolder) || string.IsNullOrEmpty(destinationFolder))
            {
                MessageBox.Show("Please select a folder and one or more emails to move.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var client = new ImapClient())
                {
                    string useremail = Properties.Settings.Default.current_username;
                    string userpassword = Properties.Settings.Default.current_password;

                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(useremail, userpassword);

                    // Get the source and destination folders
                    var source = client.GetFolder(sourceFolder);
                    var destination = client.GetFolder(destinationFolder);

                    // Move the email with the specified UID to the target folder
                    source.MoveTo(emailId, destination);

                    // Refresh the list of messages in the current folder
                    RetrieveMessages(currentFolder);
                    MessageBox.Show("Email moved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private void moveButton_Click(object sender, EventArgs e)
        {
            using (var folderSelectionDialog = new FolderSelectionDialog(folderNames))
            {
                if (folderSelectionDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderSelectionDialog.SelectedFolderName;

                    if (messages_box.SelectedItem is MessageSummary selectedMessage)
                    {
                        var selectedEmailId = selectedMessage.UniqueId;

                        // Move the email to the selected folder
                        MoveEmailToFolder(selectedEmailId, currentFolder, selectedFolder);
                    }
                }
            }
        }
    }
}
