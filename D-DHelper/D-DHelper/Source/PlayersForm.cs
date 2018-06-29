﻿using System;
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
    }
}
