using RepositoryLayer.Interfaces;
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
using BusinessLayer.DataTransferObjects;

namespace LibraryManager
{
    public partial class PublisherCreateForm : Form
    {
        private readonly IPublisherService _publisherService;
        public PublisherCreateForm(IPublisherService publisherService)
        {
            InitializeComponent();
            _publisherService = publisherService;
        }

        private void publisherEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var publisher = new PublisherDTO.Create
            {
                Name = publisherName.Text,
                Email = publisherEmail.Text
            };

            if(!_publisherService.CheckExistingPublisherByName(publisher.Name))
            {
                MessageBox.Show("Publisher with this name already exists");
                return;
            }

            if(!_publisherService.CheckExistingPublisherByEmail(publisher.Email))
            {
                MessageBox.Show("Publisher with this email already exists");
                return;
            }

            _publisherService.Create(publisher);
        }

        private void PublisherCreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
