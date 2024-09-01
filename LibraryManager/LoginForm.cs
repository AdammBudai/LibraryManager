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
using Microsoft.Extensions.DependencyInjection;
using LibraryManager.Models;

namespace LibraryManager
{
    public partial class LoginForm : Form
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly IUserService _userService;
        public LoginForm(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (!_userService.CheckLogin(userName.Text, password.Text))
            {
                MessageBox.Show("Email or Password is not valid");
                return;
            }

            var loggedUser = _userService.Login(new UserDTO.Login
            {
                Email = userName.Text,
                Password = password.Text
            });


            if (loggedUser != null)
            {
                var actualUser = new UserBO
                {

                    Id = loggedUser.Id,
                    Name = loggedUser.Name,
                    Email = loggedUser.Email,
                    Password = loggedUser.Password
                };
                SessionManager.Instance.SetLoggedInUser(actualUser);
                var loggedMenu = _serviceProvider.GetRequiredService<LoggedMenuForm>();
                loggedMenu.Show();
                this.Hide();
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
