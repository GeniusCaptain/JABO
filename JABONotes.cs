using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JABO
{
    public partial class JABONotes : Form
    {
        public JABONotes()
        {
            InitializeComponent();
        }

        private void JABONotes_Load(object sender, EventArgs e)
        {
            FormManager.Instance.GetForm<JABO>().Hide();
        }

        private void JABONotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.Instance.GetForm<JABO>().Show();
        }
    }
}
