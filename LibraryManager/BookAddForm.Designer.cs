namespace LibraryManager
{
    partial class BookAddForm
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
            bookTitle = new TextBox();
            authorName = new TextBox();
            isbn = new TextBox();
            labelTitle = new Label();
            labelAuthor = new Label();
            labelIsbn = new Label();
            buttonSubmit = new Button();
            buttonBack = new Button();
            labelPublisherName = new Label();
            publisherName = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bookTitle
            // 
            bookTitle.Location = new Point(186, 60);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(144, 23);
            bookTitle.TabIndex = 0;
            bookTitle.TextChanged += bookTitle_TextChanged;
            // 
            // authorName
            // 
            authorName.Location = new Point(186, 137);
            authorName.Name = "authorName";
            authorName.Size = new Size(144, 23);
            authorName.TabIndex = 1;
            authorName.TextChanged += authorName_TextChanged;
            // 
            // isbn
            // 
            isbn.Location = new Point(186, 278);
            isbn.Name = "isbn";
            isbn.Size = new Size(144, 23);
            isbn.TabIndex = 2;
            isbn.TextChanged += isbn_TextChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 68);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(32, 15);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Title:";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(12, 145);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(47, 15);
            labelAuthor.TabIndex = 5;
            labelAuthor.Text = "Author:";
            labelAuthor.Click += labelAuthor_Click;
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Location = new Point(12, 286);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(35, 15);
            labelIsbn.TabIndex = 6;
            labelIsbn.Text = "ISBN:";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(186, 365);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(144, 59);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(628, 365);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(144, 59);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelPublisherName
            // 
            labelPublisherName.AutoSize = true;
            labelPublisherName.Location = new Point(12, 221);
            labelPublisherName.Name = "labelPublisherName";
            labelPublisherName.Size = new Size(94, 15);
            labelPublisherName.TabIndex = 10;
            labelPublisherName.Text = "Publisher Name:";
            // 
            // publisherName
            // 
            publisherName.Location = new Point(186, 213);
            publisherName.Name = "publisherName";
            publisherName.Size = new Size(144, 23);
            publisherName.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book;
            pictureBox1.Location = new Point(456, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 259);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 153, 102);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(publisherName);
            Controls.Add(labelPublisherName);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(labelIsbn);
            Controls.Add(labelAuthor);
            Controls.Add(labelTitle);
            Controls.Add(isbn);
            Controls.Add(authorName);
            Controls.Add(bookTitle);
            Name = "BookAddForm";
            Text = "BookAddForm";
            Load += BookAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bookTitle;
        private TextBox authorName;
        private TextBox isbn;
        private Label labelTitle;
        private Label labelAuthor;
        private Label labelIsbn;
        private Button buttonSubmit;
        private Button buttonBack;
        private Label labelPublisherName;
        private TextBox publisherName;
        private PictureBox pictureBox1;
    }
}