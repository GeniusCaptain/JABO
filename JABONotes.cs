using System.Windows.Forms;

namespace JABO
{
	public partial class JABONotes : Form
    {
        public JABONotes()
        {
            InitializeComponent();
        }

        private void JABONotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.Instance.GetForm<JABO>().Show();
			e.Cancel = true;
			Hide();
        }
    }
}
