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
            InboxBT1 = new Button();
            label2 = new Label();
            SearchBar = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sign_out = new Button();
            SuspendLayout();
            // 
            // InboxBT1
            // 
            InboxBT1.Location = new Point(1, 114);
            InboxBT1.Name = "InboxBT1";
            InboxBT1.Size = new Size(275, 111);
            InboxBT1.TabIndex = 0;
            InboxBT1.Text = "Compose";
            InboxBT1.UseVisualStyleBackColor = true;
            InboxBT1.Click += InboxBT1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Padding = new Padding(85, 30, 85, 30);
            label2.Size = new Size(255, 99);
            label2.TabIndex = 5;
            label2.Text = "Inbox";
            label2.Click += label2_Click;
            // 
            // SearchBar
            // 
            SearchBar.Cursor = Cursors.Hand;
            SearchBar.Location = new Point(393, 30);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Search ....";
            SearchBar.Size = new Size(947, 43);
            SearchBar.TabIndex = 7;
            // 
            // sign_out
            // 
            sign_out.Location = new Point(1440, 59);
            sign_out.Name = "sign_out";
            sign_out.Size = new Size(169, 52);
            sign_out.TabIndex = 8;
            sign_out.Text = "Sign out";
            sign_out.UseVisualStyleBackColor = true;
            sign_out.Click += sign_out_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 952);
            Controls.Add(sign_out);
            Controls.Add(SearchBar);
            Controls.Add(label2);
            Controls.Add(InboxBT1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InboxBT1;
        private Label label2;
        private TextBox SearchBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button sign_out;
    }
}