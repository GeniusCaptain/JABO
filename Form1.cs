using System;
using System.Windows.Forms;

namespace JABO
{
	public partial class JABO : Form
    {
        public JABO()
        {
			InitializeComponent();
        }

		private void NotesOpenButton_Click(object sender, EventArgs e)
        {
			var form = FormManager.Instance.GetForm<JABONotes>();

			form.Show();
			Hide();
        }

		private void JABO_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
