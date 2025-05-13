using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
using Type = AppTitlesAnime.Models.Type;

namespace AppTitlesAnime
{
	public partial class FormListTitles : Form
	{
		private AppContext db;
		public FormListTitles()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.db = new AppContext();
			this.db.AnimeTitles.Load();
            LoadTitlesAnime();

            //скрытие столбцов 
            dataGridViewTitles.Columns["Id"].Visible = false;

			//изменение названий заголовков столбцов 
			dataGridViewTitles.Columns["TypeName"].HeaderText = "Тип";
			dataGridViewTitles.Columns["OriginalName"].HeaderText = "Оригинальное название";
			dataGridViewTitles.Columns["Name"].HeaderText = "Название";
			dataGridViewTitles.Columns["CountSeries"].HeaderText = "Количество серий";
			dataGridViewTitles.Columns["Duration"].HeaderText = "Продолжительность";
			dataGridViewTitles.Columns["Studio"].HeaderText = "Студия";
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);

			this.db?.Dispose();
			this.db = null;
		}

		private void BtnAddTitles_Click(object sender, EventArgs e)
		{
			FormAddUpdateTitle formAddUpdateTitle = new();

			this.db.Types.Load();
			List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
			formAddUpdateTitle.comboBoxType.DataSource = types;
			formAddUpdateTitle.comboBoxType.DisplayMember = "TypeName";
			formAddUpdateTitle.comboBoxType.ValueMember = "Id";

			DialogResult result = formAddUpdateTitle.ShowDialog(this);

			if (result == DialogResult.Cancel)
				return;

			AnimeTitle animeTitle = new()
			{
				OriginalName = formAddUpdateTitle.textBoxOriginalName.Text,
				Name = formAddUpdateTitle.textBoxName.Text,
				CountSeries = Convert.ToInt16(formAddUpdateTitle.numUpDownCountSeries.Value),
				Duration = Convert.ToInt16(formAddUpdateTitle.numUpDownDuration.Value),
				Studio = formAddUpdateTitle.textBoxStudio.Text,
				Description = formAddUpdateTitle.textBoxDescription.Text
			};

			Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem!;
			animeTitle.IdType = type.Id;

			db.AnimeTitles.Add(animeTitle);
			db.SaveChanges();

			MessageBox.Show("Новый объект добавлен", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			LoadTitlesAnime();
		}

		private void BtnUpdateTitle_Click(object sender, EventArgs e)
		{
			if (dataGridViewTitles.SelectedRows.Count == 0)
				return;

			int index = dataGridViewTitles.SelectedRows[0].Index;
			int id = 0;
			bool converted = Int32.TryParse(dataGridViewTitles[0, index].Value.ToString(), out id);
			if (!converted)
				return;

			AnimeTitle animeTitle = db.AnimeTitles.Find(id)!;
			FormAddUpdateTitle formAddUpdateTitle = new();

			formAddUpdateTitle.textBoxOriginalName.Text = animeTitle.OriginalName;
			formAddUpdateTitle.textBoxName.Text = animeTitle.Name;
			formAddUpdateTitle.numUpDownCountSeries.Value = animeTitle.CountSeries;
			formAddUpdateTitle.numUpDownDuration.Value = animeTitle.Duration;
			formAddUpdateTitle.textBoxStudio.Text = animeTitle.Studio;
			formAddUpdateTitle.textBoxDescription.Text = animeTitle.Description;

			this.db.Types.Load();
			List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
			formAddUpdateTitle.comboBoxType.DataSource = types;
			formAddUpdateTitle.comboBoxType.DisplayMember = "TypeName";
			formAddUpdateTitle.comboBoxType.ValueMember = "Id";

			formAddUpdateTitle.comboBoxType.SelectedItem = animeTitle.Type;

			DialogResult result = formAddUpdateTitle.ShowDialog();

			if (result == DialogResult.Cancel)
				return;

			animeTitle.OriginalName = formAddUpdateTitle.textBoxOriginalName.Text;
			animeTitle.Name = formAddUpdateTitle.textBoxName.Text;
			animeTitle.CountSeries = Convert.ToInt16(formAddUpdateTitle.numUpDownCountSeries.Value);
			animeTitle.Duration = Convert.ToInt16(formAddUpdateTitle.numUpDownDuration.Value);
			animeTitle.Studio = formAddUpdateTitle.textBoxStudio.Text;
			animeTitle.Description = formAddUpdateTitle.textBoxDescription.Text;

			Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem!;
			animeTitle.IdType = type.Id;

			db.AnimeTitles.Update(animeTitle);
			db.SaveChanges();

			MessageBox.Show("Объект изменен", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTitlesAnime();
        }

		private void BtnDeleteTitle_Click(object sender, EventArgs e)
		{
			if (dataGridViewTitles.SelectedRows.Count == 0)
				return;

			DialogResult result = MessageBox.Show(
				"Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
				"",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (result == DialogResult.No)
				return;

			int index = dataGridViewTitles.SelectedRows[0].Index;
			int id = 0;
			bool converted = Int32.TryParse(dataGridViewTitles[0, index].Value.ToString(), out id);
			if (!converted)
				return;

			AnimeTitle animeTitle = db.AnimeTitles.Find(id)!;

			db.AnimeTitles.Remove(animeTitle);
			db.SaveChanges();

			MessageBox.Show("Объект удален", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			LoadTitlesAnime();
        }

		private void LoadTitlesAnime()
		{
			this.dataGridViewTitles.DataSource = this.db.AnimeTitles
			   .Include(i => i.Type)
			   .Select(i => new
			   {
				   i.Id,
				   i.Type.TypeName,
				   i.OriginalName,
				   i.Name,
				   i.CountSeries,
				   i.Duration,
				   i.Studio
			   })
			   .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();
		}
	}
}
