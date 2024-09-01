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
using Manager.Helpers;
using BusinessLayer.DataTransferObjects;

namespace LibraryManager
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserService _userService;
        //private readonly IBookService _bookService;
        public RegistrationForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            var user = new UserDTO.Create
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            if (!_userService.CheckName(user.Name))
            {
                MessageBox.Show("This name is already taken");
                return;
            }
            if (!_userService.CheckEmail(user.Email))
            {
                MessageBox.Show("This email is already taken");
                return;
            }
            _userService.Register(user);
            MessageBox.Show("You have successfully registered");
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
