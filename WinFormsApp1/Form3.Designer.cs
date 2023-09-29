namespace WinFormsApp1
{
    partial class Form3
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
            HomeFcompose = new Button();
            label1 = new Label();
            receiverAdress = new TextBox();
            Subjectbox = new TextBox();
            Messagebox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SendBT = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // HomeFcompose
            // 
            HomeFcompose.Location = new Point(2, 0);
            HomeFcompose.Name = "HomeFcompose";
            HomeFcompose.Size = new Size(169, 106);
            HomeFcompose.TabIndex = 0;
            HomeFcompose.Text = "Inbox";
            HomeFcompose.UseVisualStyleBackColor = true;
            HomeFcompose.Click += HomeFcompose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(637, 35);
            label1.Name = "label1";
            label1.Size = new Size(548, 37);
            label1.TabIndex = 1;
            label1.Text = "                                  Sending an E-mail           ";
            label1.Click += label1_Click;
            // 
            // receiverAdress
            // 
            receiverAdress.Location = new Point(376, 112);
            receiverAdress.Name = "receiverAdress";
            receiverAdress.Size = new Size(977, 43);
            receiverAdress.TabIndex = 2;
            receiverAdress.TextChanged += receiverAdress_TextChanged;
            // 
            // Subjectbox
            // 
            Subjectbox.Location = new Point(376, 183);
            Subjectbox.Name = "Subjectbox";
            Subjectbox.Size = new Size(319, 43);
            Subjectbox.TabIndex = 3;
            // 
            // Messagebox
            // 
            Messagebox.Font = new Font("Helonia", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Messagebox.Location = new Point(305, 250);
            Messagebox.Name = "Messagebox";
            Messagebox.Size = new Size(1489, 659);
            Messagebox.TabIndex = 5;
            Messagebox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 118);
            label2.Name = "label2";
            label2.Size = new Size(44, 37);
            label2.TabIndex = 6;
            label2.Text = "To";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 189);
            label3.Name = "label3";
            label3.Size = new Size(104, 37);
            label3.TabIndex = 7;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 285);
            label4.Name = "label4";
            label4.Size = new Size(69, 37);
            label4.TabIndex = 8;
            label4.Text = "Mail";
            // 
            // SendBT
            // 
            SendBT.Location = new Point(1833, 846);
            SendBT.Name = "SendBT";
            SendBT.Size = new Size(156, 90);
            SendBT.TabIndex = 9;
            SendBT.Text = "Send";
            SendBT.UseVisualStyleBackColor = true;
            SendBT.Click += SendBT_Click;
            // 
            // button1
            // 
            button1.Location = new Point(2, 101);
            button1.Name = "button1";
            button1.Size = new Size(169, 114);
            button1.TabIndex = 10;
            button1.Text = "Important";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(2, 208);
            button2.Name = "button2";
            button2.Size = new Size(169, 114);
            button2.TabIndex = 11;
            button2.Text = "Blacklist";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(2, 318);
            button3.Name = "button3";
            button3.Size = new Size(169, 114);
            button3.TabIndex = 12;
            button3.Text = "Bin";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2003, 986);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SendBT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Messagebox);
            Controls.Add(Subjectbox);
            Controls.Add(receiverAdress);
            Controls.Add(label1);
            Controls.Add(HomeFcompose);
            Name = "Form3";
            Text = "'";
            FormClosed += Form3_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeFcompose;
        private Label label1;
        private TextBox receiverAdress;
        private TextBox Subjectbox;
        private RichTextBox Messagebox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SendBT;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}