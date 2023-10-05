namespace WinFormsApp1
{
    partial class Form2
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
            ComposeBT = new Button();
            SearchBar = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sign_out = new Button();
            folders_Box = new ListBox();
            messages_box = new ListBox();
            messageContentTextBox = new RichTextBox();
            moveButton = new Button();
            SuspendLayout();
            // 
            // ComposeBT
            // 
            ComposeBT.Location = new Point(675, 5);
            ComposeBT.Margin = new Padding(1);
            ComposeBT.Name = "ComposeBT";
            ComposeBT.Size = new Size(79, 35);
            ComposeBT.TabIndex = 0;
            ComposeBT.Text = "Compose";
            ComposeBT.UseVisualStyleBackColor = true;
            ComposeBT.Click += InboxBT1_Click;
            // 
            // SearchBar
            // 
            SearchBar.Cursor = Cursors.Hand;
            SearchBar.Location = new Point(351, 13);
            SearchBar.Margin = new Padding(1);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Search ....";
            SearchBar.Size = new Size(296, 23);
            SearchBar.TabIndex = 7;
            // 
            // sign_out
            // 
            sign_out.Location = new Point(756, 6);
            sign_out.Margin = new Padding(1);
            sign_out.Name = "sign_out";
            sign_out.Size = new Size(79, 34);
            sign_out.TabIndex = 8;
            sign_out.Text = "Sign out";
            sign_out.UseVisualStyleBackColor = true;
            sign_out.Click += sign_out_Click;
            // 
            // folders_Box
            // 
            folders_Box.FormattingEnabled = true;
            folders_Box.ItemHeight = 15;
            folders_Box.Location = new Point(10, 12);
            folders_Box.Name = "folders_Box";
            folders_Box.Size = new Size(160, 154);
            folders_Box.TabIndex = 9;
            folders_Box.SelectedIndexChanged += folders_Box_SelectedIndexChanged;
            // 
            // messages_box
            // 
            messages_box.FormattingEnabled = true;
            messages_box.ItemHeight = 15;
            messages_box.Location = new Point(10, 175);
            messages_box.Name = "messages_box";
            messages_box.Size = new Size(158, 199);
            messages_box.TabIndex = 10;
            messages_box.SelectedIndexChanged += messages_box_SelectedIndexChanged;
            // 
            // messageContentTextBox
            // 
            messageContentTextBox.Location = new Point(174, 48);
            messageContentTextBox.Name = "messageContentTextBox";
            messageContentTextBox.Size = new Size(647, 326);
            messageContentTextBox.TabIndex = 11;
            messageContentTextBox.Text = "";
            messageContentTextBox.TextChanged += messageContentTextBox_TextChanged;
            // 
            // moveButton
            // 
            moveButton.Location = new Point(174, 4);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(77, 36);
            moveButton.TabIndex = 12;
            moveButton.Text = "MoveMail";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += moveButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 386);
            Controls.Add(moveButton);
            Controls.Add(messageContentTextBox);
            Controls.Add(messages_box);
            Controls.Add(folders_Box);
            Controls.Add(sign_out);
            Controls.Add(SearchBar);
            Controls.Add(ComposeBT);
            Margin = new Padding(1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ComposeBT;
        private TextBox SearchBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button sign_out;
        private ListBox folders_Box;
        private ListBox messages_box;
        private RichTextBox messageContentTextBox;
        private Button moveButton;
    }
}