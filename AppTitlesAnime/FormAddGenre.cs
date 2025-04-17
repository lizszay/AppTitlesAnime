using System.ComponentModel;

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
                btnSaveChanges.Enabled = true;
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
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
