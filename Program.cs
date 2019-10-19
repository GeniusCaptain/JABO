using System;
using System.Windows.Forms;

namespace JABO
{
	static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			var formManager = FormManager.Instance;
            formManager.GetForm<JABO>().Show();

			while (!formManager.IsAllFormsHidden)
				Application.DoEvents();
        }
    }
}
