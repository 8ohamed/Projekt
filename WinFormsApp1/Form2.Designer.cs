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
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            SearchBar = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            // button3
            // 
            button3.Location = new Point(1, 220);
            button3.Name = "button3";
            button3.Size = new Size(275, 111);
            button3.TabIndex = 2;
            button3.Text = "Important";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1, 326);
            button1.Name = "button1";
            button1.Size = new Size(275, 111);
            button1.TabIndex = 3;
            button1.Text = "Blacklist";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // button2
            // 
            button2.Location = new Point(1, 433);
            button2.Name = "button2";
            button2.Size = new Size(275, 111);
            button2.TabIndex = 6;
            button2.Text = "Bin";
            button2.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            SearchBar.Cursor = Cursors.Hand;
            SearchBar.Location = new Point(485, 39);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Search ....";
            SearchBar.Size = new Size(947, 43);
            SearchBar.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 952);
            Controls.Add(SearchBar);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button3);
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
        private Button button3;
        private Button button1;
        private Label label2;
        private Button button2;
        private TextBox SearchBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}