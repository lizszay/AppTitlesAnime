// Подключаем пространство имен для работы с компонентами и валидацией.
using System.ComponentModel;
// Псевдоним для класса AppContext, представляющего контекст базы данных приложения.
using AppContext = AppTitlesAnime.Models.AppContext;

// Определяем пространство имен для организации кода.
namespace AppTitlesAnime
{
	// Объявляем частичный класс FormAddStatus, наследующий от класса Form.
	public partial class FormAddStatus : Form
	{
		private AppContext db; // Объявляем поле для контекста базы данных.

		// Конструктор класса FormAddStatus.
		public FormAddStatus()
		{
			// Инициализируем компоненты формы (автоматически сгенерированный код).
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			// Вызов базовой реализации метода OnLoad.
			base.OnLoad(e);
			// Создание нового экземпляра базы данных.
			this.db = new AppContext();
		}

		// Обработчик события валидации текстового поля.
		private void TextBoxStatusName_Validating(object sender, CancelEventArgs e)
		{
			string newStatusName = textBoxStatusName.Text; // Сохраняем текст в newStatusName

            // Проверяем, пустое ли текстовое поле.
            if (String.IsNullOrEmpty(newStatusName))
			{
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым"); // Устанавливаем сообщение об ошибке
                btnSaveChanges.Enabled = false; // Отключаем кнопку сохранения
                return; // Выходим из метода
            }

            bool exists = db.Statuses.Any(o => o.StatusName == newStatusName); // Проверяем, существует ли статус с таким именем

            if (exists)
            {
                errorProvider.SetError(textBoxStatusName, "Поле должно быть уникальным"); // Устанавливаем сообщение об ошибке
                btnSaveChanges.Enabled = false; // Отключаем кнопку сохранения
            }
            else
            {
                // Очищаем сообщения об ошибках при наличии текста в поле.
                errorProvider.Clear(); // Убираем сообщение об ошибке
                btnSaveChanges.Enabled = true; // Включаем кнопку сохранения
            }
        }

        // Обработчик события изменения текста в текстовом поле.
        private void TextBoxStatusName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text)) // Проверяем, пустое ли текстовое поле
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым"); // Устанавливаем сообщение об ошибке
                btnSaveChanges.Enabled = false; // Отключаем кнопку сохранения
            }
            else
            {
                // Очищаем сообщения об ошибках при наличии текста в поле.
                errorProvider.Clear(); // Убираем сообщение об ошибке
                btnSaveChanges.Enabled = true; // Включаем кнопку сохранения
            }
        }
    }
}