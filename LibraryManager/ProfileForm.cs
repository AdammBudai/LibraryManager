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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            var _user = SessionManager.Instance.LoggedInUser;

            int startX = 10;
            int startY = 10;
            int labelWidth = 100;
            int textBoxWidth = 200;
            int height = 25;
            int spacing = 10;

            AddLabelAndTextBox("Name", _user.Name, startX, startY, labelWidth, textBoxWidth, height);
            AddLabelAndTextBox("Email", _user.Email, startX, startY += height + spacing, labelWidth, textBoxWidth, height);
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
