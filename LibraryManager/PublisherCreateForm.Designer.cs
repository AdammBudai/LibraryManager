namespace LibraryManager
{
    partial class PublisherCreateForm
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
            buttonBack = new Button();
            labelPublisherName = new Label();
            publisherName = new TextBox();
            labelPublisherEmail = new Label();
            publisherEmail = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(635, 377);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(153, 61);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelPublisherName
            // 
            labelPublisherName.AutoSize = true;
            labelPublisherName.Location = new Point(12, 139);
            labelPublisherName.Name = "labelPublisherName";
            labelPublisherName.Size = new Size(94, 15);
            labelPublisherName.TabIndex = 1;
            labelPublisherName.Text = "Publisher Name:";
            // 
            // publisherName
            // 
            publisherName.Location = new Point(163, 131);
            publisherName.Name = "publisherName";
            publisherName.Size = new Size(153, 23);
            publisherName.TabIndex = 2;
            // 
            // labelPublisherEmail
            // 
            labelPublisherEmail.AutoSize = true;
            labelPublisherEmail.Location = new Point(12, 243);
            labelPublisherEmail.Name = "labelPublisherEmail";
            labelPublisherEmail.Size = new Size(91, 15);
            labelPublisherEmail.TabIndex = 3;
            labelPublisherEmail.Text = "Publisher Email:";
            // 
            // publisherEmail
            // 
            publisherEmail.Location = new Point(163, 235);
            publisherEmail.Name = "publisherEmail";
            publisherEmail.Size = new Size(153, 23);
            publisherEmail.TabIndex = 4;
            publisherEmail.TextChanged += publisherEmail_TextChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(163, 377);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(153, 61);
            buttonSubmit.TabIndex = 5;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // PublisherCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSubmit);
            Controls.Add(publisherEmail);
            Controls.Add(labelPublisherEmail);
            Controls.Add(publisherName);
            Controls.Add(labelPublisherName);
            Controls.Add(buttonBack);
            Name = "PublisherCreateForm";
            Text = "PublisherCreateForm";
            Load += PublisherCreateForm_Load;
            this.BackColor = Color.FromArgb(255, 153, 102); // Light brown color
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Label labelPublisherName;
        private TextBox publisherName;
        private Label labelPublisherEmail;
        private TextBox publisherEmail;
        private Button buttonSubmit;
    }
}