using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JABO
{
    public class FormManager
    {
        public Dictionary<Type, Form> Forms;
        private static FormManager instance;
        public static FormManager Instance
        {
            get
            {
                if (instance == null) instance = new FormManager();

                return instance;

            }
        }
        public T GetForm<T>() where T : Form, new()
        {
            var type = typeof(T);
            if (Forms.ContainsKey(type)) return Forms[type] as T;
            Forms[type] = new T();
            return Forms[type] as T;
        }
        public FormManager()
        {
            Forms = new Dictionary<Type, Form>();
        }
    }
}
