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
using BusinessLayer.DataTransferObjects;

namespace LibraryManager
{
    public partial class AuthorCreateForm : Form
    {
        private readonly IAuthorService _authorService;
        public AuthorCreateForm(IAuthorService authorService)
        {
            InitializeComponent();
            _authorService = authorService;
        }

        private void AuthorCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var author = new AuthorDTO.Create
            {
                Name = textAuthorName.Text,
                Email = textAuthorEmail.Text
            };

           if(! _authorService.CheckAccessibility(author.Name, author.Email))
           {

               MessageBox.Show("Author with this name or email already exists");
                return;
           }
            _authorService.Create(author);
            MessageBox.Show("Author created successfully");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
