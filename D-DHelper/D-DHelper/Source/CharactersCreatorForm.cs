using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_DHelper
{
    public partial class CharactersCreatorForm : Form
    {
        private Form prmainform; // = CommonChoiceForm

        public CharactersCreatorForm()
        {
            InitializeComponent();
        }

        public CharactersCreatorForm(Form mainform)
        {
            InitializeComponent();
            prmainform = mainform;
            mainform.Hide();
        }

        public static void BackToCommonChooseForm(Form closingform, Form mainform)
        {
            closingform.Hide();
            mainform.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e) // Back to Players or Masters Form
        {
            BackToCommonChooseForm(this, prmainform);
        }
    }
}
