namespace LibraryManager
{
    partial class BooksBorrowed
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
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(658, 382);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(130, 56);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 102);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(776, 261);
            dataGridView.TabIndex = 1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // BooksBorrowed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(buttonBack);
            Name = "BooksBorrowed";
            Text = "BooksBorrowed";
            Load += BooksBorrowed_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            this.BackColor = Color.FromArgb(255, 153, 102); // Light brown color
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private DataGridView dataGridView;
    }
}