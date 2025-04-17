using System.ComponentModel;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        private AppContext db;

        public FormListGenres()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o=>o.GenreName).ToList();

            //скрытие столбцов
            dataGridViewGenres.Columns["Id"].Visible = false;
            dataGridViewGenres.Columns["TitlesGenres"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewGenres.Columns["GenreName"].HeaderText = "Жанр аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxGenreName.Text;

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
    }
}
