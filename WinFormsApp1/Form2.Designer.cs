﻿namespace WinFormsApp1
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
            SearchBar = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sign_out = new Button();
            folders_Box = new ListBox();
            delete1 = new Button();
            movetospam = new Button();
            markimpo = new Button();
            markReadUnRead = new Button();
            messag = new DataGridView();
            Sender = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            composBT = new Button();
            ((System.ComponentModel.ISupportInitialize)messag).BeginInit();
            SuspendLayout();
            // 
            // SearchBar
            // 
            SearchBar.Cursor = Cursors.Hand;
            SearchBar.Location = new Point(175, 13);
            SearchBar.Margin = new Padding(1);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Search ....";
            SearchBar.Size = new Size(302, 23);
            SearchBar.TabIndex = 7;
            // 
            // sign_out
            // 
            sign_out.Location = new Point(997, 13);
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
            folders_Box.Location = new Point(11, 15);
            folders_Box.Name = "folders_Box";
            folders_Box.Size = new Size(160, 514);
            folders_Box.TabIndex = 9;
            folders_Box.SelectedIndexChanged += folders_Box_SelectedIndexChanged;
            // 
            // delete1
            // 
            delete1.Location = new Point(807, 7);
            delete1.Name = "delete1";
            delete1.Size = new Size(92, 47);
            delete1.TabIndex = 14;
            delete1.Text = "Delete";
            delete1.UseVisualStyleBackColor = true;
            delete1.Click += delete1_Click;
            // 
            // movetospam
            // 
            movetospam.Location = new Point(709, 7);
            movetospam.Name = "movetospam";
            movetospam.Size = new Size(92, 47);
            movetospam.TabIndex = 15;
            movetospam.Text = "MoveToSpam";
            movetospam.UseVisualStyleBackColor = true;
            movetospam.Click += movetospam_Click;
            // 
            // markimpo
            // 
            markimpo.Location = new Point(611, 7);
            markimpo.Name = "markimpo";
            markimpo.Size = new Size(92, 47);
            markimpo.TabIndex = 16;
            markimpo.Text = "Mark Important";
            markimpo.UseVisualStyleBackColor = true;
            // 
            // markReadUnRead
            // 
            markReadUnRead.Location = new Point(513, 7);
            markReadUnRead.Name = "markReadUnRead";
            markReadUnRead.Size = new Size(92, 47);
            markReadUnRead.TabIndex = 17;
            markReadUnRead.Text = "Mark read/unread";
            markReadUnRead.UseVisualStyleBackColor = true;
            markReadUnRead.Click += markReadUnRead_Click;
            // 
            // messag
            // 
            messag.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            messag.Columns.AddRange(new DataGridViewColumn[] { Sender, subject });
            messag.Location = new Point(195, 80);
            messag.Name = "messag";
            messag.RowTemplate.Height = 25;
            messag.Size = new Size(840, 405);
            messag.TabIndex = 18;
            messag.CellContentClick += messag_CellContentClick;
            // 
            // Sender
            // 
            Sender.HeaderText = "The sender";
            Sender.Name = "Sender";
            Sender.ReadOnly = true;
            // 
            // subject
            // 
            subject.HeaderText = "The subject";
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // composBT
            // 
            composBT.Location = new Point(903, 7);
            composBT.Margin = new Padding(1);
            composBT.Name = "composBT";
            composBT.Size = new Size(92, 47);
            composBT.TabIndex = 19;
            composBT.Text = "Compose";
            composBT.UseVisualStyleBackColor = true;
            composBT.Click += composBT_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1082, 534);
            Controls.Add(composBT);
            Controls.Add(messag);
            Controls.Add(markReadUnRead);
            Controls.Add(markimpo);
            Controls.Add(movetospam);
            Controls.Add(delete1);
            Controls.Add(folders_Box);
            Controls.Add(sign_out);
            Controls.Add(SearchBar);
            Margin = new Padding(1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)messag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SearchBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button sign_out;
        private ListBox folders_Box;
        private Button delete1;
        private Button movetospam;
        private Button markimpo;
        private Button markReadUnRead;
        private DataGridView messag;
        private DataGridViewTextBoxColumn Sender;
        private DataGridViewTextBoxColumn subject;
        private Button composBT;
    }
}