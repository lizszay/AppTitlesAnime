using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
using Status = AppTitlesAnime.Models.Status;

namespace AppTitlesAnime
{
    public partial class FormListStatuses : Form
    {
        private AppContext db;

        public FormListStatuses()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Statuses.Load();
            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

            //скрытие столбцов
            dataGridViewStatuses.Columns["Id"].Visible = false;
            dataGridViewStatuses.Columns["TitlesStatuses"].Visible = false;

            //изменение названиий заголовокв столбцов
            dataGridViewStatuses.Columns["StatusName"].HeaderText = "Статус аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new();
            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Status status = new Status();
            status.StatusName = formAddStatus.textBoxStatusName.Text;

            db.Statuses.Add(status);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }
    }
}
