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

        private void InTextToTextboxAndLabel(Label label, TextBox textbox) // For Lables
        {
            label.Hide();
            textbox.Show();
        }

        private void OutTextToTextboxAndLabel(Label label, TextBox textbox) // For Textbox
        {
            textbox.Hide();
            label.Text = textbox.Text;
            label.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label1, CharactersNameTextBox);
        }

        private void CharactersNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label1, CharactersNameTextBox);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label2, ClassTextbox);
        }

        private void ClassTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label2, ClassTextbox);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label3, LevelTextbox);
        }

        private void LevelTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label3, LevelTextbox);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label4, RaceTextbox);
        }

        private void RaceTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label4, RaceTextbox);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label5, AlignmentTextbox);
        }

        private void AlignmentTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label5, AlignmentTextbox);
        }
    }
}
