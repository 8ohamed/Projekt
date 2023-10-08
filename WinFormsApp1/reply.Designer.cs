namespace WinFormsApp1
{
    partial class reply
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
            sendreplyBT = new Button();
            replyBox = new RichTextBox();
            SuspendLayout();
            // 
            // sendreplyBT
            // 
            sendreplyBT.Location = new Point(701, 350);
            sendreplyBT.Name = "sendreplyBT";
            sendreplyBT.Size = new Size(87, 33);
            sendreplyBT.TabIndex = 1;
            sendreplyBT.Text = "Send";
            sendreplyBT.UseVisualStyleBackColor = true;
            sendreplyBT.Click += sendreplyBT_Click;
            // 
            // replyBox
            // 
            replyBox.Location = new Point(12, 12);
            replyBox.Name = "replyBox";
            replyBox.Size = new Size(776, 332);
            replyBox.TabIndex = 2;
            replyBox.Text = "";
            replyBox.TextChanged += replyBox_TextChanged;
            // 
            // reply
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 387);
            Controls.Add(replyBox);
            Controls.Add(sendreplyBT);
            Name = "reply";
            Text = "reply";
            Load += reply_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button sendreplyBT;
        private RichTextBox replyBox;
    }
}