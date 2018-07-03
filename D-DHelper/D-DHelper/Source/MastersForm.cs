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
    public partial class MastersForm : Form
    {
        public MastersForm()
        {
            InitializeComponent();
        }

        public MastersForm(Form mainform)
        {
            InitializeComponent();
            mainform.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdventuresJournal.OpenAdventuresJournal();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OwnContentBuilder.OpenOwnContentBuilder();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InitiativeCounter.OpenInitiativeCounter();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CharactersCreator.OpenCharactersCreator();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CharactersBase.OpenCharactersBase();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DiceRoller.OpenDiceRoller();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemsBase.OpenItemsBase();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SpellsBase.OpenSpellsBase();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MonstersBase.OpenMonstersBase();
        }
    }
}
