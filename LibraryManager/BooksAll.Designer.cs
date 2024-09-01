namespace LibraryManager
{
    partial class BooksAll
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
            dataGridView = new DataGridView();
            buttonBack = new Button();
            authorName = new TextBox();
            bookTitle = new TextBox();
            labelAuthorName = new Label();
            labelBookTitle = new Label();
            checkedListBox1 = new CheckedListBox();
            buttonFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 115);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 260);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(636, 381);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(152, 57);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // authorName
            // 
            authorName.Location = new Point(12, 74);
            authorName.Name = "authorName";
            authorName.Size = new Size(157, 23);
            authorName.TabIndex = 2;
            authorName.TextChanged += authorName_TextChanged;
            // 
            // bookTitle
            // 
            bookTitle.Location = new Point(175, 74);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(157, 23);
            bookTitle.TabIndex = 3;
            // 
            // labelAuthorName
            // 
            labelAuthorName.AutoSize = true;
            labelAuthorName.Location = new Point(12, 36);
            labelAuthorName.Name = "labelAuthorName";
            labelAuthorName.Size = new Size(101, 15);
            labelAuthorName.TabIndex = 6;
            labelAuthorName.Text = "Author Name:";
            // 
            // labelBookTitle
            // 
            labelBookTitle.AutoSize = true;
            labelBookTitle.Location = new Point(175, 36);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Size = new Size(81, 15);
            labelBookTitle.TabIndex = 7;
            labelBookTitle.Text = "Book Title:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "A-Z", "Z-A", "Available" });
            checkedListBox1.Location = new Point(375, 39);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(133, 58);
            checkedListBox1.TabIndex = 8;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(534, 57);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(131, 39);
            buttonFilter.TabIndex = 9;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // BooksAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(buttonFilter);
            Controls.Add(checkedListBox1);
            Controls.Add(labelBookTitle);
            Controls.Add(labelAuthorName);
            Controls.Add(bookTitle);
            Controls.Add(authorName);
            Controls.Add(buttonBack);
            Controls.Add(dataGridView);
            Name = "BooksAll";
            Text = "BooksAll";
            Load += BooksAll_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            this.BackColor = Color.FromArgb(255, 153, 102); // Light brown color
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonBack;
        private TextBox authorName;
        private TextBox bookTitle;
        private Label labelAuthorName;
        private Label labelBookTitle;
        private CheckedListBox checkedListBox1;
        private Button buttonFilter;
    }
}