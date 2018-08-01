using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_DHelper
{
    class DiceRoller
    {
        private static Random rnd = new Random();

        public static int DiceChoice { get; set; }

        public static int DiceCounter { get; set; } = 1;

        public static void OpenDiceRoller(Form form)
        {
            DiceRollerForm dicerollerform = new DiceRollerForm(form);
            dicerollerform.Show();
        }

        private void DiceRoll()
        {
            for (int index = 1; index <= DiceCounter; index++)
            {
                rnd.Next(1, DiceChoice);
            }
        }
    }
}
