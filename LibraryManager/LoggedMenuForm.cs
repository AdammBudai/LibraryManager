using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LibraryManager
{
    public partial class LoggedMenuForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public LoggedMenuForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void LoggedMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profile = _serviceProvider.GetRequiredService<ProfileForm>();
            profile.FormClosed += (s, args) =>
            {
                this.Show();
            };
            profile.Show();
        }

        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            var booksAll = _serviceProvider.GetRequiredService<BooksAll>();
            booksAll.FormClosed += (s, args) =>
            {
                this.Show();
            };
            booksAll.Show();
        }

        private void buttonShowBorrowedBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            var booksBorrowed = _serviceProvider.GetRequiredService<BooksBorrowed>();
            booksBorrowed.FormClosed += (s, args) =>
            {
                this.Show();
            };
            booksBorrowed.Show();
        }

        private void buttonCreateBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bookAddForm = _serviceProvider.GetRequiredService<BookAddForm>();
            bookAddForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            bookAddForm.Show();
        }

        private void buttonCreateAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var authorCreateForm = _serviceProvider.GetRequiredService<AuthorCreateForm>();
            authorCreateForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            authorCreateForm.Show();
        }

        private void buttonCreatePublisher_Click(object sender, EventArgs e)
        {
            this.Hide();
            var publisherCreateForm = _serviceProvider.GetRequiredService<PublisherCreateForm>();
            publisherCreateForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            publisherCreateForm.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.LogOut();
            this.Close();
            var menu = _serviceProvider.GetRequiredService<Menu>();
            menu.Show();
        }
    }
}
