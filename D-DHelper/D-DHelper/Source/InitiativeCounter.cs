using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_DHelper
{
    class InitiativeCounter
    {
        public static void OpenInitiativeCounter(Form form)
        {
            InitiativeCounterForm initiativecounterform = new InitiativeCounterForm(form);
            initiativecounterform.Show();
        }
    }
}
