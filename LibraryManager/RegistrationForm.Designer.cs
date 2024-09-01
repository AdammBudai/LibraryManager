namespace LibraryManager
{
    partial class RegistrationForm
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            registerButton = new Button();
            labelName = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(306, 194);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(306, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(132, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(306, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(132, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(306, 317);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(132, 34);
            registerButton.TabIndex = 3;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(219, 202);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 4;
            labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(219, 231);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(219, 260);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password:";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(682, 391);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(106, 47);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(registerButton);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            this.BackColor = Color.FromArgb(255, 153, 102); // Light brown color
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button registerButton;
        private Label labelName;
        private Label labelEmail;
        private Label labelPassword;
        private Button buttonBack;
    }
}