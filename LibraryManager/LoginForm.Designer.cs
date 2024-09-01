namespace LibraryManager
{
    partial class LoginForm
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
            userName = new TextBox();
            password = new TextBox();
            buttonLogin = new Button();
            buttonBack = new Button();
            labelEmail = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Location = new Point(333, 148);
            userName.Name = "userName";
            userName.Size = new Size(129, 23);
            userName.TabIndex = 0;
            userName.TextChanged += userName_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(333, 201);
            password.Name = "password";
            password.Size = new Size(129, 23);
            password.TabIndex = 1;
            password.TextChanged += password_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(333, 269);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(129, 41);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(657, 376);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(131, 62);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(257, 156);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(38, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(257, 209);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(38, 15);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(buttonBack);
            Controls.Add(buttonLogin);
            Controls.Add(password);
            Controls.Add(userName);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            this.BackColor = Color.FromArgb(255, 153, 102); // Light brown color
            PerformLayout();
        }

        #endregion

        private TextBox userName;
        private TextBox password;
        private Button buttonLogin;
        private Button buttonBack;
        private Label labelEmail;
        private Label labelPassword;
    }
}