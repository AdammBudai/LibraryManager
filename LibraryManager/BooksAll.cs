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
using LibraryManager.Models;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManager
{
    public partial class BooksAll : Form
    {
        private readonly IBookService _bookService;
        private readonly IBorrowingsService _borrowingsService;
        private readonly IServiceProvider _serviceProvider;
        public BooksAll(IBookService bookService, IBorrowingsService borrowingsService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _bookService = bookService;
            _borrowingsService = borrowingsService;
            _serviceProvider = serviceProvider;
        }

        private void BooksAll_Load(object sender, EventArgs e)
        {
            var books = _bookService.GetAll();
            dataGridView.DataSource = books;

            dataGridView.Columns["Model"].Visible = false;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["AuthorId"].Visible = false;
            dataGridView.Columns["PublisherId"].Visible = false;
            dataGridView.Columns["PublisherName"].Visible = false;
            dataGridView.Columns["PublishDate"].Visible = false;
            dataGridView.Columns["ISBN"].Visible = false;

            DataGridViewButtonColumn borrowButtonColumn = new DataGridViewButtonColumn();
            borrowButtonColumn.Name = "Borrow";
            borrowButtonColumn.Text = "Borrow";
            borrowButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(borrowButtonColumn);

            DataGridViewButtonColumn detailsButtonColumn = new DataGridViewButtonColumn();
            detailsButtonColumn.Name = "Details";
            detailsButtonColumn.Text = "Details";
            detailsButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(detailsButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(deleteButtonColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Borrow"].Index && e.RowIndex >= 0)
            {
                var book = (BookBO)dataGridView.Rows[e.RowIndex].DataBoundItem;
                if (book != null)
                {
                    var loggedInUser = SessionManager.Instance.LoggedInUser;
                    _borrowingsService.Borrow(book.Id, loggedInUser.Id);
                    MessageBox.Show($"Book '{book.Title}' borrowed successfully!");
                    var books = _bookService.GetAllAvailable();
                    dataGridView.DataSource = books;
                }

            }

            if (e.ColumnIndex == dataGridView.Columns["Details"].Index && e.RowIndex >= 0)
            {
                var book = (BookBO)dataGridView.Rows[e.RowIndex].DataBoundItem;
                if (book != null)
                {
                    this.Hide();
                    var detailBookForm = ActivatorUtilities.CreateInstance<DetailBookForm>(_serviceProvider, book);
                    detailBookForm.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };
                    detailBookForm.Show();
                }
            }

            if (e.ColumnIndex == dataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var book = (BookBO)dataGridView.Rows[e.RowIndex].DataBoundItem;
                if (book != null)
                {
                    _bookService.Delete(book.Id);
                    MessageBox.Show($"Book '{book.Title}' deleted successfully!");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void authorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            IEnumerable<BookBO> books;
            if(authorName.Text.Count() > 0 && bookTitle.Text.Count() > 0)
            {
                books = _bookService.GetBooksByAuthorAndTitle(authorName.Text, bookTitle.Text);
            }
            else if(authorName.Text.Count() > 0)
            {
                books = _bookService.GetBooksByAuthor(authorName.Text);
            }
            else if(bookTitle.Text.Count() > 0)
            {
                books = _bookService.GetBooksByTitle(bookTitle.Text);
            }
            else
            {
                books = _bookService.GetAll();
            }

            if (checkedListBox1.CheckedItems.Contains("A-Z"))
            {
                books = books.OrderBy(b => b.Title).ToList();
            }
            else if (checkedListBox1.CheckedItems.Contains("Z-A"))
            {
                books = books.OrderByDescending(b => b.Title).ToList();
            }

            if (checkedListBox1.CheckedItems.Contains("Available"))
            {
                books = books.Where(b => b.Available == true).ToList();
            }
            else
            {
                books = books.Where(b => b.Available == true || b.Available == false).ToList();
            }

            dataGridView.DataSource = books;

        }
    }
}
