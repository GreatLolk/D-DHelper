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

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label6, ACTextbox);
        }

        private void ACTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label6, ACTextbox);
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label7, InitiativeTextbox);
        }

        private void InitiativeTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label7, InitiativeTextbox);
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label8, SpeedTextbox);
        }

        private void SpeedTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label8, SpeedTextbox);
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label9, AttacksTextbox);
        }

        private void AttacksTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label9, AttacksTextbox);
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label10, OtherTextbox);
        }

        private void OtherTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label10, OtherTextbox);
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label11, STRTextbox);
        }

        private void STRTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label11, STRTextbox);
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label12, DEXTextbox);
        }

        private void DEXTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label12, DEXTextbox);
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label13, CONTextbox);
        }

        private void CONTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label13, CONTextbox);
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label14, INTTextbox);
        }

        private void INTTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label14, INTTextbox);
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label15, WISTextbox);
        }

        private void WISTextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label15, WISTextbox);
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label16, CHATextbox);
        }

        private void CHATextbox_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label16, CHATextbox);
        }
    }
}
