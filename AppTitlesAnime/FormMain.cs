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

        // Определение метода, который будет вызываться при клике на кнопку BtnShowStatuses
        private void BtnShowStatuses_Click(object sender, EventArgs e)
        {
            //создаем новую форму, которая будет отображать список статусов
            FormListStatuses formListStatuses = new FormListStatuses();
            //отображение созданной формы
            formListStatuses.Show();
        }
    }
}
