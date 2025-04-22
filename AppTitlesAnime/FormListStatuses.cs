// Пространство имен, предоставляющее классы для поддержки разработки компонентов, таких как привязка данных и лицензирование.
using System.ComponentModel;
// Пространство имен, предоставляющее классы для работы с данными, особенно с ADO.NET.
using System.Data;
// Пространство имен Entity Framework Core, фреймворка ORM для работы с базами данных.
using Microsoft.EntityFrameworkCore;
// Псевдоним для класса AppContext, представляющего контекст базы данных приложения.
using AppContext = AppTitlesAnime.Models.AppContext;
// Псевдоним для класса Status, представляющего сущность "статус" в базе данных.
using Status = AppTitlesAnime.Models.Status;

namespace AppTitlesAnime
{
	// Объявление класса FormListStatuses, который является производным от класса Form (Windows Forms).
	public partial class FormListStatuses : Form
	{
		// Приватное поле db типа AppContext, которое будет содержать экземпляр контекста базы данных.
		private AppContext db;

		// Конструктор класса FormListStatuses.
		public FormListStatuses()
		{
			// Инициализация компонентов формы, сгенерированных в дизайнере.
			InitializeComponent();
		}

		// Переопределенный метод OnLoad, вызываемый при загрузке формы.
		protected override void OnLoad(EventArgs e)
		{
			// Вызов базовой реализации метода OnLoad.
			base.OnLoad(e);
			// Создание нового экземпляра контекста базы данных.
			this.db = new AppContext();
			// Загрузка данных из таблицы Statuses в локальный кэш контекста.
			this.db.Statuses.Load();
			// Привязка данных из локального кэша к элементу управления DataGridView и сортировка по имени статуса.
			this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

			// Скрытие столбца "Id" в DataGridView.
			dataGridViewStatuses.Columns["Id"].Visible = false;
			// Скрытие столбца "TitlesStatuses" в DataGridView.
			dataGridViewStatuses.Columns["TitlesStatuses"].Visible = false;

			// Изменение заголовка столбца "StatusName" в DataGridView.
			dataGridViewStatuses.Columns["StatusName"].HeaderText = "Статус аниме";
		}

		// Переопределенный метод OnClosing, вызываемый при закрытии формы.
		protected override void OnClosing(CancelEventArgs e)
		{
			// Вызов базовой реализации метода OnClosing.
			base.OnClosing(e);

			// Освобождение ресурсов, используемых контекстом базы данных, если он не равен null.
			this.db?.Dispose();
			// Обнуление ссылки на контекст базы данных.
			this.db = null;
		}

		// Обработчик события Click для кнопки добавления статуса.
		private void BtnAddStatus_Click(object sender, EventArgs e)
		{
			// Создание нового экземпляра формы добавления статуса.
			FormAddStatus formAddStatus = new();
			// Отображение формы добавления статуса как модального диалога.
			DialogResult result = formAddStatus.ShowDialog(this);

			// Проверка, была ли отменена операция добавления.
			if (result == DialogResult.Cancel)
				// Выход из обработчика события, если операция была отменена.
				return;

			// Создание нового экземпляра класса Status.
			Status status = new Status();
			// Получение имени статуса из текстового поля формы добавления.
			status.StatusName = formAddStatus.textBoxStatusName.Text;

			// Добавление нового статуса в контекст базы данных.
			db.Statuses.Add(status);
			// Сохранение изменений в базе данных.
			db.SaveChanges();

			// Отображение сообщения об успешном добавлении.
			MessageBox.Show("Новый объект добавлен");

			// Обновление данных в DataGridView.
			this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
		}

		// Обработчик события Click для кнопки обновления статуса.
		private void BtnUpdateStatus_Click(object sender, EventArgs e)
		{
			// Проверка, выбрана ли строка в DataGridView.
			if (dataGridViewStatuses.SelectedRows.Count == 0)
				// Выход из обработчика события, если строка не выбрана.
				return;

			// Получение индекса выбранной строки.
			int index = dataGridViewStatuses.SelectedRows[0].Index;
			// Объявление переменной для хранения идентификатора статуса.
			short id = 0;
			// Преобразование значения ячейки с идентификатором в тип Int16.
			bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);
			
			// Проверка, удалось ли преобразование.
			if (!converted)
				// Выход из обработчика события, если преобразование не удалось.
				return;

			// Поиск статуса в базе данных по идентификатору.
			Status status = db.Statuses.Find(id);
			// Создание нового экземпляра формы добавления статуса.
			FormAddStatus formAddStatus = new();
			// Заполнение текстового поля формы добавления текущим именем статуса.
			formAddStatus.textBoxStatusName.Text = status.StatusName;

			// Отображение формы добавления статуса как модального диалога.
			DialogResult result = formAddStatus.ShowDialog(this);

			// Проверка, была ли отменена операция обновления.
			if (result == DialogResult.Cancel)
				// Выход из обработчика события, если операция была отменена.
				return;

			// Обновление имени статуса из текстового поля формы добавления.
			status.StatusName = formAddStatus.textBoxStatusName.Text;
			// Обновление статуса в контексте базы данных.
			db.Statuses.Update(status);
			// Сохранение изменений в базе данных.
			db.SaveChanges();

			// Отображение сообщения об успешном обновлении.
			MessageBox.Show("Объект изменен");

			// Обновление данных в DataGridView.
			this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
		}

		// Обработчик события Click для кнопки удаления статуса.
		private void BtnDeleteStatus_Click(object sender, EventArgs e)
		{
			// Проверка, выбрана ли строка в DataGridView.
			if (dataGridViewStatuses.SelectedRows.Count == 0)
				// Выход из обработчика события, если строка не выбрана.
				return;

			// Отображение диалогового окна подтверждения удаления.
			DialogResult result = MessageBox.Show(
				"Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
				"",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
				);

			// Проверка, подтвердил ли пользователь удаление.
			if (result == DialogResult.No)
				// Выход из обработчика события, если удаление не подтверждено.
				return;

			// Получение индекса выбранной строки.
			int index = dataGridViewStatuses.SelectedRows[0].Index;
			// Объявление переменной для хранения идентификатора статуса.
			short id = 0;
			// Преобразование значения ячейки с идентификатором в тип Int16.
			bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);
			// Проверка, удалось ли преобразование.
			if (!converted)
				// Выход из обработчика события, если преобразование не удалось.
				return;

			// Поиск статуса в базе данных по идентификатору.
			Status status = db.Statuses.Find(id);

			// Удаление статуса из контекста базы данных.
			db.Statuses.Remove(status);
			// Сохранение изменений в базе данных.
			db.SaveChanges();

			// Отображение сообщения об успешном удалении.
			MessageBox.Show("Объект удален");

			// Обновление данных в DataGridView.
			this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
		}
	}
}
