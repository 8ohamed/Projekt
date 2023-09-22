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
            Compose = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // InboxBT1
            // 
            InboxBT1.Location = new Point(1, 103);
            InboxBT1.Name = "InboxBT1";
            InboxBT1.Size = new Size(275, 111);
            InboxBT1.TabIndex = 0;
            InboxBT1.Text = "InBox";
            InboxBT1.UseVisualStyleBackColor = true;
            InboxBT1.Click += InboxBT1_Click;
            // 
            // Compose
            // 
            Compose.Location = new Point(1, 211);
            Compose.Name = "Compose";
            Compose.Size = new Size(275, 111);
            Compose.TabIndex = 1;
            Compose.Text = "Compose";
            Compose.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1, 318);
            button3.Name = "button3";
            button3.Size = new Size(275, 111);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 952);
            Controls.Add(button3);
            Controls.Add(Compose);
            Controls.Add(InboxBT1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button InboxBT1;
        private Button Compose;
        private Button button3;
    }
}