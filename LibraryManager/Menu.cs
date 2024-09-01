using System.Diagnostics;
using BusinessLayer.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManager
{
    public partial class Menu : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Menu(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationForm = _serviceProvider.GetRequiredService<RegistrationForm>();
            registrationForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            registrationForm.Show();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = _serviceProvider.GetRequiredService<LoginForm>();
            loginForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            loginForm.Show();
        }
    }
}
