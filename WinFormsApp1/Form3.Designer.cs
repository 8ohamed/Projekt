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
            sign_out = new Button();
            SuspendLayout();
            // 
            // HomeFcompose
            // 
            HomeFcompose.Location = new Point(10, 10);
            HomeFcompose.Margin = new Padding(1);
            HomeFcompose.Name = "HomeFcompose";
            HomeFcompose.Size = new Size(113, 63);
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
            label1.Location = new Point(297, 14);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 1;
            label1.Text = "                                  Sending an E-mail           ";
            label1.Click += label1_Click;
            // 
            // receiverAdress
            // 
            receiverAdress.Location = new Point(205, 47);
            receiverAdress.Margin = new Padding(1);
            receiverAdress.Name = "receiverAdress";
            receiverAdress.Size = new Size(458, 23);
            receiverAdress.TabIndex = 2;
            receiverAdress.TextChanged += receiverAdress_TextChanged;
            // 
            // Subjectbox
            // 
            Subjectbox.Location = new Point(205, 76);
            Subjectbox.Margin = new Padding(1);
            Subjectbox.Name = "Subjectbox";
            Subjectbox.Size = new Size(151, 23);
            Subjectbox.TabIndex = 3;
            // 
            // Messagebox
            // 
            Messagebox.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Messagebox.Location = new Point(142, 101);
            Messagebox.Margin = new Padding(1);
            Messagebox.Name = "Messagebox";
            Messagebox.Size = new Size(769, 342);
            Messagebox.TabIndex = 5;
            Messagebox.Text = "";
            Messagebox.TextChanged += Messagebox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 50);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 6;
            label2.Text = "To";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 79);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 116);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Mail";
            // 
            // SendBT
            // 
            SendBT.Location = new Point(814, 35);
            SendBT.Margin = new Padding(1);
            SendBT.Name = "SendBT";
            SendBT.Size = new Size(87, 40);
            SendBT.TabIndex = 9;
            SendBT.Text = "Send";
            SendBT.UseVisualStyleBackColor = true;
            SendBT.Click += SendBT_Click;
            // 
            // sign_out
            // 
            sign_out.Location = new Point(10, 401);
            sign_out.Margin = new Padding(1);
            sign_out.Name = "sign_out";
            sign_out.Size = new Size(102, 29);
            sign_out.TabIndex = 10;
            sign_out.Text = "Sign Out";
            sign_out.UseVisualStyleBackColor = true;
            sign_out.Click += sign_out_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 453);
            Controls.Add(sign_out);
            Controls.Add(SendBT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Messagebox);
            Controls.Add(Subjectbox);
            Controls.Add(receiverAdress);
            Controls.Add(label1);
            Controls.Add(HomeFcompose);
            Margin = new Padding(1);
            Name = "Form3";
            Text = "Compose";
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
        private Button sign_out;
    }
}