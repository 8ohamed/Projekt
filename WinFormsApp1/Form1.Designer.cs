namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginBT = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            Emailabel = new Label();
            passwordlabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginBT
            // 
            loginBT.Location = new Point(785, 711);
            loginBT.Name = "loginBT";
            loginBT.Size = new Size(169, 52);
            loginBT.TabIndex = 0;
            loginBT.Text = "login";
            loginBT.UseVisualStyleBackColor = true;
            loginBT.Click += loginBT_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(670, 526);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(436, 43);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(670, 598);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(436, 43);
            textBoxPassword.TabIndex = 2;
            // 
            // Emailabel
            // 
            Emailabel.AutoSize = true;
            Emailabel.BackColor = SystemColors.ButtonHighlight;
            Emailabel.Location = new Point(472, 526);
            Emailabel.Name = "Emailabel";
            Emailabel.Size = new Size(176, 37);
            Emailabel.TabIndex = 3;
            Emailabel.Text = "E-Mail adress";
            Emailabel.Click += label1_Click;
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.BackColor = SystemColors.ControlLightLight;
            passwordlabel.Location = new Point(472, 598);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(128, 37);
            passwordlabel.TabIndex = 4;
            passwordlabel.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 331);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1674, 937);
            Controls.Add(pictureBox1);
            Controls.Add(passwordlabel);
            Controls.Add(Emailabel);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(loginBT);
            Name = "Form1";
            Text = "LoginPage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBT;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label Emailabel;
        private Label passwordlabel;
        private PictureBox pictureBox1;
    }
}