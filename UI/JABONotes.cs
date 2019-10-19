using JABO.Data.Models;
using JABO.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JABO
{
	public partial class JABONotes : Form
    {
		private List<TodoMessageModel> _todoMessages;
		
        public JABONotes()
        {
            InitializeComponent();

			// Подписываемся на событие клика кнопки.
			btnMessage.Click += OnMessageButtonClick;
        }

		private void OnMessageButtonClick(object sender, EventArgs e)
		{
			var newTodoText = txtTodoMessage.Text;
			txtTodoMessage.Text = string.Empty;

			// Добавляем на в сам ListBox
			lstTodoMessages.Items.Add(newTodoText);

			// Добавляем в локальный лист 
			// (например, что бы потом его сохранить, не терять дату и т.д)
			_todoMessages.Add(new TodoMessageModel
			{
				AddedDate = DateTime.Now,
				Message = newTodoText
			});
		}

		// Этот метод выполнится один раз за всю жизнь приложения,
		// т.к. у нас кешируеются формы в FormManager-е
		private void JABONotes_Load(object sender, EventArgs e)
		{
			// Получаем модели из репозитория.
			_todoMessages = TodoMessagesRepository.Load().ToList();

			// Берем из наших данных только текст.
			var messages = _todoMessages.Select(c => c.Message).ToArray();

			// Суем его в наш ListBox
			lstTodoMessages.Items.AddRange(messages);
		}

		private void JABONotes_FormClosing(object sender, FormClosingEventArgs e)
        {
			// Когда формочку закрываем, тогда сохраняем 
			// в репозиторий все наши данные.
			TodoMessagesRepository.Save(_todoMessages);

			// Бере нашу основную формочку и показываем ее.
            FormManager.Instance.GetForm<JABO>().Show();

			// Устанавливая этот флаг мы по сути говорим,
			// что форму закрывать не надо. 
			e.Cancel = true;

			// Вместо этого мы ее скрываем (это разные вещи).
			Hide();
        }
	}
}
