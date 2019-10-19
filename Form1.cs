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
    public partial class JABO : Form
    {
        public JABO()
        {
            InitializeComponent();
        }

        private void JABO_Load(object sender, EventArgs e)
        {

        }
        bool track;
        private void NotesOpenButton_Click(object sender, EventArgs e)
        {
            track = true;
            JABONotes newForm = new JABONotes();
            newForm.Show();
            
            //if (track == true)
            //{
            //    this.Opacity = 0;
            //}
            //else
            //{
            //    track = false;
            //    this.Opacity = 100;
            //}
        }
    }
}
