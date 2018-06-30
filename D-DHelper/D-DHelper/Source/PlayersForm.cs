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
    public partial class PlayersForm : Form
    {
        private Form prmainform; // = CommonChoiceForm

        public PlayersForm()
        {
            InitializeComponent();
        }

        public PlayersForm(Form mainform)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackToCommonChooseForm(this, prmainform);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CharactersCreator.OpenCharactersCreator();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CharactersBase.OpenCharactersBase();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DiceRoller.OpenDiceRoller();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SpellsBase.OpenSpellsBase();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ItemsBase.OpenItemsBase();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MonstersBase.OpenMonstersBase();
        }
    }
}
