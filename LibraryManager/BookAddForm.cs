using BusinessLayer.DataTransferObjects;
using BusinessLayer.Interfaces;
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
    public partial class BookAddForm : Form
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IPublisherService _publisherService;
        public BookAddForm(IBookService bookService, IAuthorService authorService, IPublisherService publisherService)
        {
            InitializeComponent();
            _bookService = bookService;
            _authorService = authorService;
            _publisherService = publisherService;
        }

        private void BookAddForm_Load(object sender, EventArgs e)
        {

        }


        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void bookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(_authorService.CheckAccessibility(authorName.Text, ""))
            {
                MessageBox.Show("Author does not exists!");
                return;
            }

            if(_publisherService.CheckExistingPublisherByName(publisherName.Text))
            {
               MessageBox.Show("Publisher does not exists!");
                return;
            }

            var book = new BookDTO.Create
            {
                Title = bookTitle.Text,
                AuthorName = authorName.Text,
                PublisherName = publisherName.Text,
                ISBN = isbn.Text
            };

            if(!_bookService.CheckAccessibility(book.Title, book.ISBN))
            {
                MessageBox.Show("Book with this title or ISBN already exists.");
                return;
            }

            _bookService.Create(book);
            MessageBox.Show("Book has been successfully added.");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
