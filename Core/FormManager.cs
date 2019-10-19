using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JABO
{
	public class FormManager
    {
        private readonly Dictionary<Type, Form> _forms;

        private static FormManager _instance;

        public static FormManager Instance =>
			_instance ?? (_instance = new FormManager());

		public bool IsAllFormsHidden { get; private set; }

		public T GetForm<T>() where T : Form, new()
        {
            var type = typeof(T);

			if (_forms.TryGetValue(type, out var cachedForm))
				return cachedForm as T;

			var form = new T();
            _forms[type] = form;

			form.VisibleChanged += FormVisibleChanged;

            return _forms[type] as T;
        }

		private void FormVisibleChanged(object sender, EventArgs e)
		{
			IsAllFormsHidden = _forms
				.Select(c => c.Value)
				.All(c => !c.Visible);
		}

		public FormManager()
        {
            _forms = new Dictionary<Type, Form>();
			IsAllFormsHidden = false;
        }
    }
}
