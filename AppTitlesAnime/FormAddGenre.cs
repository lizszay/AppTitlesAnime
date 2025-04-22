using System.ComponentModel;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
	public partial class FormAddGenre : Form
	{
		private AppContext db;

		public FormAddGenre()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.db = new AppContext();
		}

		private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
		{
            string newGenreName = textBoxGenreName.Text;

            if (String.IsNullOrEmpty(textBoxGenreName.Text))
			{
				errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
				btnSaveChanges.Enabled = false;
                return;
            }

            bool exists = db.Genres.Any(o => o.GenreName == newGenreName);

            if (exists)
            {
                errorProvider.SetError(textBoxGenreName, "Поле должно быть уникальным");
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
