namespace WinFormsApp1
{
    partial class forward
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
            forwardbox = new RichTextBox();
            reciever = new TextBox();
            label1 = new Label();
            SendBT = new Button();
            SuspendLayout();
            // 
            // forwardbox
            // 
            forwardbox.Location = new Point(12, 56);
            forwardbox.Name = "forwardbox";
            forwardbox.ReadOnly = true;
            forwardbox.Size = new Size(776, 382);
            forwardbox.TabIndex = 1;
            forwardbox.Text = "";
            forwardbox.TextChanged += forwardbox_TextChanged;
            // 
            // reciever
            // 
            reciever.Location = new Point(107, 12);
            reciever.Name = "reciever";
            reciever.Size = new Size(381, 23);
            reciever.TabIndex = 2;
            reciever.TextChanged += reciever_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Foward To";
            label1.Click += label1_Click;
            // 
            // SendBT
            // 
            SendBT.Location = new Point(695, 5);
            SendBT.Name = "SendBT";
            SendBT.Size = new Size(81, 45);
            SendBT.TabIndex = 4;
            SendBT.Text = "Send";
            SendBT.UseVisualStyleBackColor = true;
            SendBT.Click += SendBT_Click;
            // 
            // forward
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendBT);
            Controls.Add(label1);
            Controls.Add(reciever);
            Controls.Add(forwardbox);
            Name = "forward";
            Text = "forward";
            FormClosed += forward_FormClosed;
            Load += forward_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox forwardbox;
        private TextBox reciever;
        private Label label1;
        private Button SendBT;
    }
}