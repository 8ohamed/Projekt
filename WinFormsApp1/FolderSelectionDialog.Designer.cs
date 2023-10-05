namespace WinFormsApp1
{
    partial class FolderSelectionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderListBox = new ListBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // folderListBox
            // 
            folderListBox.FormattingEnabled = true;
            folderListBox.ItemHeight = 15;
            folderListBox.Location = new Point(12, 12);
            folderListBox.Name = "folderListBox";
            folderListBox.Size = new Size(401, 214);
            folderListBox.TabIndex = 0;
            folderListBox.SelectedIndexChanged += folderListBox_SelectedIndexChanged;
            // 
            // okButton
            // 
            okButton.Location = new Point(445, 193);
            okButton.Name = "okButton";
            okButton.Size = new Size(79, 30);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(445, 229);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(78, 31);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // FolderSelectionDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 263);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(folderListBox);
            Name = "FolderSelectionDialog";
            Text = "FolderSelectionDialog";
            Load += FolderSelectionDialog_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox folderListBox;
        private Button okButton;
        private Button cancelButton;
    }
}