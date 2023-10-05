using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FolderSelectionDialog : Form
    {
        public FolderSelectionDialog()
        {
            InitializeComponent();
        }
        public string SelectedFolderName
        {
            get { return folderListBox.SelectedItem as string; }
        }

        public FolderSelectionDialog(List<string> folderNames)
        {
            InitializeComponent();

            // Populate the ListBox with folder names
            folderListBox.DataSource = folderNames;
        }

        private void FolderSelectionDialog_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (folderListBox.SelectedItem != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void folderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
