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
    public partial class CommonChoiceForm : Form
    {
        public CommonChoiceForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Show();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PlayersForm playersform1 = new PlayersForm(this);
            playersform1.Show();

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            MastersForm mastersform1 = new MastersForm(this);
            mastersform1.Show();
        }

    }
}
