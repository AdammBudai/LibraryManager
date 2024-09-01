using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using LibraryManager.Models;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManager
{
    public partial class BooksBorrowed : Form
    {
        private readonly IBorrowingsService _borrowingsService;
        private readonly IServiceProvider _serviceProvider;
        public BooksBorrowed(IBorrowingsService borrowingsService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _borrowingsService = borrowingsService;
            _serviceProvider = serviceProvider;
        }

        private void BooksBorrowed_Load(object sender, EventArgs e)
        {
            List<BookBO> borrowedBooks = _borrowingsService.GetBorrowedBooks(SessionManager.Instance.LoggedInUser.Id);
            dataGridView.DataSource = borrowedBooks;

            dataGridView.Columns["Model"].Visible = false;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["AuthorId"].Visible = false;
            dataGridView.Columns["PublisherId"].Visible = false;
            dataGridView.Columns["PublisherName"].Visible = false;
            dataGridView.Columns["PublishDate"].Visible = false;
            dataGridView.Columns["ISBN"].Visible = false;

            DataGridViewButtonColumn returnButtonColumn = new DataGridViewButtonColumn();
            returnButtonColumn.Name = "Return";
            returnButtonColumn.Text = "Return";
            returnButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(returnButtonColumn);

            DataGridViewButtonColumn detailsButtonColumn = new DataGridViewButtonColumn();
            detailsButtonColumn.Name = "Details";
            detailsButtonColumn.Text = "Details";
            detailsButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(detailsButtonColumn);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.ColumnIndex == dataGridView.Columns["Return"].Index && e.RowIndex >= 0)
            {
                var book = (BookBO)dataGridView.Rows[e.RowIndex].DataBoundItem;
                if (book != null)
                {
                    _borrowingsService.Return(book.Id);
                    MessageBox.Show($"Book returned successfully!");
                    var borrowedBooks = _borrowingsService.GetBorrowedBooks(SessionManager.Instance.LoggedInUser.Id);
                    dataGridView.DataSource = borrowedBooks;
                }
            }

            if (e.ColumnIndex == dataGridView.Columns["Details"].Index && e.RowIndex >= 0)
            {
                var book = (BookBO)dataGridView.Rows[e.RowIndex].DataBoundItem;
                if (book != null)
                {
                    this.Hide();
                    var detailBorrowedBookForm = ActivatorUtilities.CreateInstance<DetailBorrowedBookForm>(_serviceProvider, book);
                    detailBorrowedBookForm.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };
                    detailBorrowedBookForm.Show();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
