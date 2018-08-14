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
    public partial class InitiativeCounterForm : Form
    {
        private Form prmainform; // = PlayersForm OR MastersForm

        public InitiativeCounterForm()
        {
            InitializeComponent();
        }

        public InitiativeCounterForm(Form mainform)
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

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label25, textBox1);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label25, textBox1);
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label26, textBox2);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label26, textBox2);
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label27, textBox3);
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label27, textBox3);
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label28, textBox4);
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label28, textBox4);
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label29, textBox5);
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label29, textBox5);
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label30, textBox6);
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label30, textBox6);
        }

        private void label54_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label54, textBox12);
        }

        private void textBox12_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label54, textBox12);
        }

        private void label53_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label53, textBox11);
        }

        private void textBox11_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label53, textBox11);
        }

        private void label52_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label52, textBox10);
        }

        private void textBox10_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label52, textBox10);
        }

        private void label51_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label51, textBox9);
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label51, textBox9);
        }

        private void label50_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label50, textBox8);
        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label50, textBox8);
        }

        private void label49_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label49, textBox7);
        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label49, textBox7);
        }

        private void label60_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label60, textBox18);
        }

        private void textBox18_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label60, textBox18);
        }

        private void label59_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label59, textBox17);
        }

        private void textBox17_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label59, textBox17);
        }

        private void label58_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label58, textBox16);
        }

        private void textBox16_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label58, textBox16);
        }

        private void label57_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label57, textBox15);
        }

        private void textBox15_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label57, textBox15);
        }

        private void label56_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label56, textBox14);
        }

        private void textBox14_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label56, textBox14);
        }

        private void label55_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label55, textBox13);
        }

        private void textBox13_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label55, textBox13);
        }

        private void label66_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label66, textBox24);
        }

        private void textBox24_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label66, textBox24);
        }

        private void label65_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label65, textBox23);
        }

        private void textBox23_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label65, textBox23);
        }

        private void label64_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label64, textBox22);
        }

        private void textBox22_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label64, textBox22);
        }

        private void label63_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label63, textBox21);
        }

        private void textBox21_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label63, textBox21);
        }

        private void label62_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label62, textBox20);
        }

        private void textBox20_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label62, textBox20);
        }

        private void label61_MouseEnter(object sender, EventArgs e)
        {
            InTextToTextboxAndLabel(label61, textBox19);
        }

        private void textBox19_MouseLeave(object sender, EventArgs e)
        {
            OutTextToTextboxAndLabel(label61, textBox19);
        }
    }
}
