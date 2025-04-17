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
    public partial class FormListStatuses : Form
    {
        public FormListStatuses()
        {
            InitializeComponent();
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new();
            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            /*Status status = new Status();
            status.TypeName = formAddStatus.textBoxStatusName.Text;

            db.Statuses.Add(status);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();*/
        }
    }
}
