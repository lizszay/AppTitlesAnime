using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form
    {
        public FormAddGenre()
        {
            InitializeComponent();
        }

        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = false;
            }
        }

        private void TextBoxGenreName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = false;
            }
        }
    }
}
