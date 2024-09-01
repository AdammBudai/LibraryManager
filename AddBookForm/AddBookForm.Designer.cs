namespace AddBookForm
{
    partial class AddBookForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnSave;

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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.PlaceholderText = "Title";

            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(12, 38);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(200, 20);
            this.txtAuthorName.TabIndex = 1;
            this.txtAuthorName.PlaceholderText = "Author Name";

            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(12, 64);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(200, 20);
            this.txtPublisherName.TabIndex = 2;
            this.txtPublisherName.PlaceholderText = "Publisher Name";

            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(12, 90);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPublishDate.TabIndex = 3;

            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(12, 116);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 20);
            this.txtISBN.TabIndex = 4;
            this.txtISBN.PlaceholderText = "ISBN";

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // AddBookForm
            // 
            this.ClientSize = new System.Drawing.Size(234, 181);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtPublisherName);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnSave);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
