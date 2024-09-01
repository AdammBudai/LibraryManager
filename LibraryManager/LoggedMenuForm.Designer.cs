namespace LibraryManager
{
    partial class LoggedMenuForm
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
            buttonShowProfile = new Button();
            buttonShowBooks = new Button();
            buttonShowBorrowedBooks = new Button();
            buttonLogOut = new Button();
            buttonCreateBook = new Button();
            buttonCreateAuthor = new Button();
            buttonCreatePublisher = new Button();
            SuspendLayout();
            // 
            // buttonShowProfile
            // 
            buttonShowProfile.Location = new Point(88, 103);
            buttonShowProfile.Name = "buttonShowProfile";
            buttonShowProfile.Size = new Size(170, 89);
            buttonShowProfile.TabIndex = 0;
            buttonShowProfile.Text = "Show Profile";
            buttonShowProfile.UseVisualStyleBackColor = true;
            buttonShowProfile.Click += buttonShowProfile_Click;
            // 
            // buttonShowBooks
            // 
            buttonShowBooks.Location = new Point(292, 103);
            buttonShowBooks.Name = "buttonShowBooks";
            buttonShowBooks.Size = new Size(170, 89);
            buttonShowBooks.TabIndex = 1;
            buttonShowBooks.Text = "Show Books";
            buttonShowBooks.UseVisualStyleBackColor = true;
            buttonShowBooks.Click += buttonShowBooks_Click;
            // 
            // buttonShowBorrowedBooks
            // 
            buttonShowBorrowedBooks.Location = new Point(506, 103);
            buttonShowBorrowedBooks.Name = "buttonShowBorrowedBooks";
            buttonShowBorrowedBooks.Size = new Size(170, 89);
            buttonShowBorrowedBooks.TabIndex = 2;
            buttonShowBorrowedBooks.Text = "Show Borrowed Books";
            buttonShowBorrowedBooks.UseVisualStyleBackColor = true;
            buttonShowBorrowedBooks.Click += buttonShowBorrowedBooks_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(12, 377);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(125, 61);
            buttonLogOut.TabIndex = 3;
            buttonLogOut.Text = "LogOut";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonCreateBook
            // 
            buttonCreateBook.Location = new Point(292, 228);
            buttonCreateBook.Name = "buttonCreateBook";
            buttonCreateBook.Size = new Size(170, 89);
            buttonCreateBook.TabIndex = 4;
            buttonCreateBook.Text = "Create Book";
            buttonCreateBook.UseVisualStyleBackColor = true;
            buttonCreateBook.Click += buttonCreateBook_Click;
            // 
            // buttonCreateAuthor
            // 
            buttonCreateAuthor.Location = new Point(88, 228);
            buttonCreateAuthor.Name = "buttonCreateAuthor";
            buttonCreateAuthor.Size = new Size(170, 89);
            buttonCreateAuthor.TabIndex = 6;
            buttonCreateAuthor.Text = "Create Author";
            buttonCreateAuthor.UseVisualStyleBackColor = true;
            buttonCreateAuthor.Click += buttonCreateAuthor_Click;
            // 
            // buttonCreatePublisher
            // 
            buttonCreatePublisher.Location = new Point(506, 228);
            buttonCreatePublisher.Name = "buttonCreatePublisher";
            buttonCreatePublisher.Size = new Size(170, 89);
            buttonCreatePublisher.TabIndex = 7;
            buttonCreatePublisher.Text = "Create Publisher";
            buttonCreatePublisher.UseVisualStyleBackColor = true;
            buttonCreatePublisher.Click += buttonCreatePublisher_Click;
            // 
            // LoggedMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreatePublisher);
            Controls.Add(buttonCreateAuthor);
            Controls.Add(buttonCreateBook);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonShowBorrowedBooks);
            Controls.Add(buttonShowBooks);
            Controls.Add(buttonShowProfile);
            Name = "LoggedMenuForm";
            Text = "LoggedMenuForm";
            Load += LoggedMenuForm_Load;
            this.BackColor = Color.FromArgb(255, 153, 102); // Light brown color
            ResumeLayout(false);
        }

        #endregion

        private Button buttonShowProfile;
        private Button buttonShowBooks;
        private Button buttonShowBorrowedBooks;
        private Button buttonLogOut;
        private Button buttonCreateBook;
        private Button buttonCreateAuthor;
        private Button buttonCreatePublisher;
    }
}