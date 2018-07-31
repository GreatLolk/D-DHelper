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
    public partial class DiceRollerForm : Form
    {
        private Form prmainform; // = PlayersForm OR MastersForm

        public DiceRollerForm()
        {
            InitializeComponent();
        }

        public DiceRollerForm(Form mainform)
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            BackToCommonChooseForm(this, prmainform);
        }
    }
}
