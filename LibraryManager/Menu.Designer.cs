namespace LibraryManager
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddBook;

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
            buttonRegister = new Button();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(298, 167);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(174, 67);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(298, 253);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(174, 67);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegister);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            this.BackColor = Color.FromArgb(255, 153, 102); // Light brown color
            ResumeLayout(false);
        }

        #endregion
        private Button buttonRegister;
        private Button buttonLogin;
    }
}
