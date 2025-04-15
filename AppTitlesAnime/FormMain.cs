namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void BtnShowGenres_Click(object sender, EventArgs e)
        {
            FormListGenres formListGenres = new FormListGenres();
            formListGenres.Show();
        }
    }
}
