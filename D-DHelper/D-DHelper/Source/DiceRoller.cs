using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DHelper
{
    class DiceRoller
    {
        private static Random rnd = new Random();

        public static int DiceChoice { get; set; }

        public static void OpenDiceRoller()
        {
        }

        private void DiceRoll()
        {
            rnd.Next(1, DiceChoice);
        }
    }
}
