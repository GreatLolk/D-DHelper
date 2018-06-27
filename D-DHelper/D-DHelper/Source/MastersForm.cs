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
    }
}
