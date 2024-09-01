namespace LibraryManager
{
    partial class AuthorCreateForm
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
            textAuthorName = new TextBox();
            textAuthorEmail = new TextBox();
            buttonSubmit = new Button();
            labelAuthorName = new Label();
            labelAuthorEmail = new Label();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textAuthorName
            // 
            textAuthorName.Location = new Point(163, 139);
            textAuthorName.Name = "textAuthorName";
            textAuthorName.Size = new Size(162, 23);
            textAuthorName.TabIndex = 0;
            // 
            // textAuthorEmail
            // 
            textAuthorEmail.Location = new Point(163, 225);
            textAuthorEmail.Name = "textAuthorEmail";
            textAuthorEmail.Size = new Size(162, 23);
            textAuthorEmail.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(163, 287);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(162, 54);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelAuthorName
            // 
            labelAuthorName.AutoSize = true;
            labelAuthorName.Location = new Point(12, 147);
            labelAuthorName.Name = "labelAuthorName";
            labelAuthorName.Size = new Size(82, 15);
            labelAuthorName.TabIndex = 3;
            labelAuthorName.Text = "Author Name:";
            // 
            // labelAuthorEmail
            // 
            labelAuthorEmail.AutoSize = true;
            labelAuthorEmail.Location = new Point(12, 233);
            labelAuthorEmail.Name = "labelAuthorEmail";
            labelAuthorEmail.Size = new Size(79, 15);
            labelAuthorEmail.TabIndex = 4;
            labelAuthorEmail.Text = "Author Email:";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(626, 384);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(162, 54);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.author;
            pictureBox1.Location = new Point(415, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 343);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // AuthorCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 153, 102);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack);
            Controls.Add(labelAuthorEmail);
            Controls.Add(labelAuthorName);
            Controls.Add(buttonSubmit);
            Controls.Add(textAuthorEmail);
            Controls.Add(textAuthorName);
            Name = "AuthorCreateForm";
            Text = "AuthorCreateForm";
            Load += AuthorCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAuthorName;
        private TextBox textAuthorEmail;
        private Button buttonSubmit;
        private Label labelAuthorName;
        private Label labelAuthorEmail;
        private Button buttonBack;
        private PictureBox pictureBox1;
    }
}