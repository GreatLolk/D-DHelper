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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            DiceRoller.DiceChoice = 4;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            DiceRoller.DiceChoice = 6;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            DiceRoller.DiceChoice = 8;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            DiceRoller.DiceChoice = 10;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton1.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            DiceRoller.DiceChoice = 12;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton1.Checked = false;
            radioButton7.Checked = false;
            DiceRoller.DiceChoice = 20;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton1.Checked = false;
            DiceRoller.DiceChoice = 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DiceRoller.DiceCounter = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DiceRoller.DiceCounter = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DiceRoller.DiceCounter = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DiceRoller.DiceCounter = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DiceRoller.DiceCounter = 5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DiceRoller.DiceCounter = 6;
        }
    }
}
