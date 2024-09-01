using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class DetailBorrowedBookForm : Form
    {
        private readonly BookBO _book;
        public DetailBorrowedBookForm(BookBO book)
        {
            InitializeComponent();
            _book = book;
        }

        private void DetailBorrowedBookForm_Load(object sender, EventArgs e)
        {
            int startX = 10;
            int startY = 10;
            int labelWidth = 100;
            int textBoxWidth = 200;
            int height = 25;
            int spacing = 10;

            AddLabelAndTextBox("Title", _book.Title, startX, startY, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("AuthorId", _book.AuthorId.ToString(), startX, startY += height + spacing, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("PublishDate", _book.PublishDate.ToString("yyyy-MM-dd"), startX, startY += height + spacing, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("ISBN", _book.ISBN, startX, startY += height + spacing, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("AuthorName", _book.AuthorName, startX, startY += height + spacing, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("PublisherId", _book.PublisherId.ToString(), startX, startY += height + spacing, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("PublisherName", _book.PublisherName, startX, startY += height + spacing, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("Available", _book.Available ? "Yes" : "No", startX, startY += height + spacing, labelWidth, textBoxWidth, height);
        }

        private void AddLabelAndTextBox(string labelText, string textBoxText, int x, int y, int labelWidth, int textBoxWidth, int height)
        {
            Label label = new Label
            {
                Text = labelText,
                Location = new Point(x, y),
                Width = labelWidth,
                Height = height
            };
            TextBox textBox = new TextBox
            {
                Text = textBoxText,
                Location = new Point(x + labelWidth + 5, y),
                Width = textBoxWidth,
                Height = height,
                ReadOnly = true
            };

            this.Controls.Add(label);
            this.Controls.Add(textBox);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
