using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.DataTransferObjects;
using BusinessLayer.Interfaces;
using LibraryManager.Models;

namespace LibraryManager
{
    public partial class DetailBookForm : Form
    {
        private readonly IBookService _bookService;
        private  BookBO _book;
        public DetailBookForm(IBookService bookService, BookBO book)
        {
            InitializeComponent();
            _bookService = bookService;
            _book = book;
        }

        private void DetailBookForm_Load(object sender, EventArgs e)
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

            int rightStartX = ClientSize.Width - textBoxWidth - 120;

            AddEditableLabelAndTextBox("Title", _book.Title, rightStartX, 10, labelWidth, textBoxWidth, height, out titleTextBox);
            AddEditableLabelAndTextBox("Publish Date", _book.PublishDate.ToString("yyyy-MM-dd"), rightStartX, 10 + height + spacing, labelWidth, textBoxWidth, height, out publishDateTextBox);
            AddEditableLabelAndTextBox("ISBN", _book.ISBN, rightStartX, 10 + 2 * (height + spacing), labelWidth, textBoxWidth, height, out isbnTextBox);


            Button saveChangesButton = new Button
            {
                Text = "Save Changes",
                Location = new Point(rightStartX, 10 + 3 * (height + spacing)),
                Width = textBoxWidth,
                Height = height
            };
            saveChangesButton.Click += SaveChangesButton_Click;
            this.Controls.Add(saveChangesButton);


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

        private void AddEditableLabelAndTextBox(string labelText, string textBoxText, int x, int y, int labelWidth, int textBoxWidth, int height, out TextBox textBox)
        {
            Label label = new Label
            {
                Text = labelText,
                Location = new Point(x, y),
                Width = labelWidth,
                Height = height
            };
            textBox = new TextBox
            {
                Text = textBoxText,
                Location = new Point(x + labelWidth + 5, y),
                Width = textBoxWidth,
                Height = height
            };

            this.Controls.Add(label);
            this.Controls.Add(textBox);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            BookDTO.Update dtoUpdate = new BookDTO.Update
            {
                Title = titleTextBox.Text,
                PublishDate = DateTime.TryParse(publishDateTextBox.Text, out var publishDate) ? (DateTime?)publishDate : null,
                ISBN = isbnTextBox.Text,
                Available = _book.Available
            };

            if(!_bookService.CheckAccessibility(dtoUpdate.Title, dtoUpdate.ISBN))
            {
                MessageBox.Show("Book with the same title or ISBN already exists.");
                return;
            }

            _bookService.Update(_book.Id, dtoUpdate);
            MessageBox.Show("Book details updated successfully.");
            _book = _bookService.Get(_book.Id);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
