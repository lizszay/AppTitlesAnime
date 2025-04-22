using System.ComponentModel;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
	public partial class FormAddType : Form
	{
		private AppContext db;

		public FormAddType()
		{
			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.db = new AppContext();
		}

		private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
		{
			string newTypeName = textBoxTypeName.Text; 

			if (String.IsNullOrEmpty(newTypeName))
			{
				errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
				btnSaveChanges.Enabled = false;
				return;
			}

			bool exists = db.Types.Any(o => o.TypeName == newTypeName);

			if (exists)
			{
				errorProvider.SetError(textBoxTypeName, "Поле должно быть уникальным");
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
			if (String.IsNullOrEmpty(textBoxTypeName.Text))
			{
				errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
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
