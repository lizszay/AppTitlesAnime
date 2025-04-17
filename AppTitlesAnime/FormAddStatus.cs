using System.ComponentModel;

namespace AppTitlesAnime
{
	public partial class FormAddStatus : Form
	{
		public FormAddStatus()
		{
			InitializeComponent();
		}

		private void TextBoxStatusName_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxStatusName.Text))
			{
				errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым");
				btnSaveChanges.Enabled = false;
			}
			else
			{
				errorProvider.Clear();
				btnSaveChanges.Enabled = true;
			}
		}

		private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxStatusName.Text))
			{
				errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым");
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
