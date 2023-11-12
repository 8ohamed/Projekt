﻿using System;
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
using Org.BouncyCastle.Asn1.X509;

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
            // Define columns for the MEssages DataGridView
            DataGridViewTextBoxColumn senderColumn = new DataGridViewTextBoxColumn();
            senderColumn.HeaderText = "Date";
            senderColumn.Name = "DateCol"; // This should match the column name you use in MEssages_CellContentClick
            messag.Columns.Add(senderColumn);

            //  DataGridViewTextBoxColumn subjectColumn = new DataGridViewTextBoxColumn();
            //subjectColumn.HeaderText = "Subject";
            //subjectColumn.Name = "Subject"; // This should match the column name you use in MEssages_CellContentClick
            //messag.Columns.Add(subjectColumn);

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
                messag.Rows.Clear();
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

                        // Define the list of folder names you want to retrieve
                        var folderNamesToRetrieve = new List<string>
                        {
                           "INBOX",
                           "[Gmail]/Important",
                           "[Gmail]/Sent Mail",
                           "[Gmail]/Trash",
                           "[Gmail]/Spam"
                         };

                        // Populate the folders_Box list box with folder names and folderNames list
                        foreach (var folder in folders.Where(f => folderNamesToRetrieve.Contains(f.FullName)))
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

        private void MEssages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < messag.Rows.Count)
            {
                try
                {
                    string selectedFolderName = folders_Box.SelectedItem as string;

                    using (var client = new ImapClient())
                    {
                        string useremail = Properties.Settings.Default.current_username;
                        string userpassword = Properties.Settings.Default.current_password;

                        client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                        client.Authenticate(useremail, userpassword);

                        var folder = client.GetFolder(selectedFolderName);
                        folder.Open(FolderAccess.ReadOnly);

                        var message = folder.GetMessage(e.RowIndex);

                        string messageContent = message.TextBody; // Retrieve email content
                        Properties.Settings.Default.current_message = messageContent;

                        // Pass the message content to the MessageViewerForm
                        MessageViewerForm viewerForm = new MessageViewerForm(messageContent, message);
                        viewerForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void RetrieveMessages(string folderName)
        {
            try
            {
                messag.Rows.Clear();
                string useremail = Properties.Settings.Default.current_username;
                string userpassword = Properties.Settings.Default.current_password;

                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(useremail, userpassword);

                    var folder = client.GetFolder(folderName);
                    if (folder != null)
                    {
                        folder.Open(FolderAccess.ReadOnly);
                        var messages = folder.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope);

                        foreach (var message in messages)
                        {
                            messag.Rows.Add(
                                message.Envelope.From.ToString(),
                                message.Envelope.Subject,
                                message.Envelope.Date
                            );
                        }

                        folder.Close();
                    }

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
            // Clear the messages_box when a new folder is selected
            //this.Invoke(new Action(() => messag.Rows.Clear())); // Update the UI on the main thread

            string selectedFolderName = folders_Box.SelectedItem as string;

            // Check if a folder is selected
            if (!string.IsNullOrEmpty(selectedFolderName))
            {


                // Retrieve messages on a separate thread and update the UI on the main thread
                Task.Run(() =>
                {
                    // Show "Please Wait" message
                    MessageBox.Show("Please wait while retrieving messages...", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Invoke(new Action(() =>
                    {
                        RetrieveMessages(selectedFolderName);

                    }));

                });


            }

        }




        private MimeMessage originalMessage; // Field to store the original message

        private void messag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < messag.Rows.Count)
            {
                try
                {
                    string selectedFolderName = folders_Box.SelectedItem as string;

                    using (var client = new ImapClient())
                    {
                        string useremail = Properties.Settings.Default.current_username;
                        string userpassword = Properties.Settings.Default.current_password;

                        client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                        client.Authenticate(useremail, userpassword);

                        var folder = client.GetFolder(selectedFolderName);
                        folder.Open(FolderAccess.ReadOnly);

                        var message = folder.GetMessage(e.RowIndex);
                        string messageContent = message.TextBody; // Retrieve email content

                        // Store the original message in the field, in case of reply
                        originalMessage = message;
                        // Pass the message content to the MessageViewerForm
                        MessageViewerForm viewerForm = new MessageViewerForm(messageContent, message);
                        viewerForm.ShowDialog();

                        // Display the sender and subject in DataGridView
                        messag["Sender", e.RowIndex].Value = message.From.ToString(); // Sender
                        messag["Subject", e.RowIndex].Value = message.Subject; // Subject
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void composBT_Click(object sender, EventArgs e)
        {
            Form3 Compose = new Form3();
            this.Hide();
            Compose.Show();
        }



        private void delete1_Click(object sender, EventArgs e)
        {
            if (messag.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an email to move to Trash.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = messag.SelectedRows[0].Index;
            string selectedFolderName = folders_Box.SelectedItem as string;

            if (selectedFolderName.Equals("[Gmail]/Trash", StringComparison.OrdinalIgnoreCase))
            {

                // Ask the user if they want to delete it permanently
                var result = MessageBox.Show("Do you want to delete this email permanently?", "Delete Permanently", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var client = new ImapClient())
                        {
                            string useremail = Properties.Settings.Default.current_username;
                            string userpassword = Properties.Settings.Default.current_password;

                            client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                            client.Authenticate(useremail, userpassword);

                            var folder = client.GetFolder(selectedFolderName);
                            folder.Open(FolderAccess.ReadWrite);

                            var uids = folder.Search(SearchQuery.All);
                            if (rowIndex < uids.Count)
                            {
                                var emailUniqueId = uids[rowIndex];
                                folder.AddFlags(emailUniqueId, MessageFlags.Deleted, true); // Mark for deletion
                                folder.Expunge(new UniqueId[] { emailUniqueId }); // Permanently delete marked email
                                messag.Rows.RemoveAt(rowIndex); // Remove from DataGridView
                            }

                            folder.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else
            {
                try
                {
                    using (var client = new ImapClient())
                    {
                        string useremail = Properties.Settings.Default.current_username;
                        string userpassword = Properties.Settings.Default.current_password;

                        client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                        client.Authenticate(useremail, userpassword);

                        var folder = client.GetFolder(selectedFolderName);
                        folder.Open(FolderAccess.ReadWrite);

                        var uids = folder.Search(SearchQuery.All);
                        if (rowIndex < uids.Count)
                        {
                            var emailUniqueId = uids[rowIndex];

                            // Mark the email as spam by adding the \Flag \Spam flags
                            folder.AddFlags(emailUniqueId, MessageFlags.Flagged, true);
                            folder.AddFlags(emailUniqueId, MessageFlags.Seen, true);

                            // Refresh the messages
                            messag.Rows.Clear();
                            RetrieveMessages(selectedFolderName);

                            // Optionally move the email to the Spam folder
                            string trashFolderName = "[Gmail]/Trash";
                            var trashFolder = client.GetFolder(trashFolderName);
                            if (trashFolder != null)
                            {
                                folder.MoveTo(new UniqueId[] { emailUniqueId }, trashFolder);
                            }
                        }

                        folder.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void movetospam_Click(object sender, EventArgs e)
        {
            if (messag.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an email to mark as spam.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = messag.SelectedRows[0].Index;

            try
            {
                string selectedFolderName = folders_Box.SelectedItem as string;
                using (var client = new ImapClient())
                {
                    string useremail = Properties.Settings.Default.current_username;
                    string userpassword = Properties.Settings.Default.current_password;

                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(useremail, userpassword);

                    var folder = client.GetFolder(selectedFolderName);
                    folder.Open(FolderAccess.ReadWrite);

                    var uids = folder.Search(SearchQuery.All);
                    if (rowIndex < uids.Count)
                    {
                        var emailUniqueId = uids[rowIndex];

                        // Mark the email as spam by adding the \Flag \Spam flags
                        folder.AddFlags(emailUniqueId, MessageFlags.Flagged, true);
                        folder.AddFlags(emailUniqueId, MessageFlags.Seen, true);

                        // Refresh the messages
                        messag.Rows.Clear();
                        RetrieveMessages(selectedFolderName);

                        // Optionally move the email to the Spam folder
                        string spamFolderName = "[Gmail]/Spam";
                        var spamFolder = client.GetFolder(spamFolderName);
                        if (spamFolder != null)
                        {
                            folder.MoveTo(new UniqueId[] { emailUniqueId }, spamFolder);
                        }
                    }

                    folder.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void markReadUnRead_Click(object sender, EventArgs e)
        {

        }

        private void important_Click(object sender, EventArgs e)
        {
            if (messag.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an email to mark as important.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = messag.SelectedRows[0].Index;

            try
            {
                string selectedFolderName = folders_Box.SelectedItem as string;

                using (var client = new ImapClient())
                {
                    string useremail = Properties.Settings.Default.current_username;
                    string userpassword = Properties.Settings.Default.current_password;

                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(useremail, userpassword);

                    var folder = client.GetFolder(selectedFolderName);
                    folder.Open(FolderAccess.ReadWrite);

                    var uids = folder.Search(SearchQuery.All);
                    if (rowIndex < uids.Count)
                    {
                        var emailUniqueId = uids[rowIndex];

                        // Move the email to the "Important" folder
                        string importantFolderName = "[Gmail]/Important";
                        var importantFolder = client.GetFolder(importantFolderName);

                        if (importantFolder != null)
                        {
                            folder.MoveTo(new UniqueId[] { emailUniqueId }, importantFolder);
                        }
                    }

                    folder.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
