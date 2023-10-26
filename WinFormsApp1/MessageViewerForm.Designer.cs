namespace WinFormsApp1
{
    partial class MessageViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Other controls declarations go here...

        private Label senderLabel;
        private Label subjectLabel;
        private Label dateLabel;
        private Button closeButton;

        private void InitializeComponent()
        {
            senderLabel = new Label();
            subjectLabel = new Label();
            dateLabel = new Label();
            closeButton = new Button();
            ReadMessage = new RichTextBox();
            replyBT = new Button();
            forwardBT = new Button();
            SuspendLayout();
            // 
            // senderLabel
            // 
            senderLabel.AutoSize = true;
            senderLabel.Location = new Point(12, 9);
            senderLabel.Name = "senderLabel";
            senderLabel.Size = new Size(47, 15);
            senderLabel.TabIndex = 0;
            senderLabel.Text = "Sender:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new Point(12, 41);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(51, 15);
            subjectLabel.TabIndex = 1;
            subjectLabel.Text = "Subject:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(12, 73);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(37, 15);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(117, 114);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ReadMessage
            // 
            ReadMessage.Location = new Point(12, 43);
            ReadMessage.Name = "ReadMessage";
            ReadMessage.ReadOnly = true;
            ReadMessage.Size = new Size(715, 358);
            ReadMessage.TabIndex = 2;
            ReadMessage.Text = "";
            ReadMessage.TextChanged += ReadMessage_TextChanged;
            // 
            // replyBT
            // 
            replyBT.Location = new Point(749, 51);
            replyBT.Name = "replyBT";
            replyBT.Size = new Size(112, 44);
            replyBT.TabIndex = 3;
            replyBT.Text = "Reply";
            replyBT.UseVisualStyleBackColor = true;
            replyBT.Click += replyBT_Click;
            // 
            // forwardBT
            // 
            forwardBT.Location = new Point(749, 110);
            forwardBT.Name = "forwardBT";
            forwardBT.Size = new Size(112, 44);
            forwardBT.TabIndex = 4;
            forwardBT.Text = "Forward";
            forwardBT.UseVisualStyleBackColor = true;
            forwardBT.Click += forwardBT_Click;
            // 
            // MessageViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 423);
            Controls.Add(forwardBT);
            Controls.Add(replyBT);
            Controls.Add(ReadMessage);
            Name = "MessageViewerForm";
            Load += MessageViewerForm_Load;
            ResumeLayout(false);
        }

        private RichTextBox ReadMessage;
        private Button replyBT;
        private Button forwardBT;
    }
}
