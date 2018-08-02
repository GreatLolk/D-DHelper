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

        public static void DiceRoll()
        {
            string[] results = new string[DiceCounter];

            for (int index = 1; index <= DiceCounter; index++)
            {
                results[index - 1] = rnd.Next(1, DiceChoice).ToString();
            }

            switch(DiceCounter)
            {
                case 1:
                    MessageBox.Show("Your result:\r\n" + results[0], "Result", MessageBoxButtons.OK);
                    break;

                case 2:
                    MessageBox.Show("Your result:\r\n" + results[0] + "\r\n" + results[1], "Result", MessageBoxButtons.OK);
                    break;

                case 3:
                    MessageBox.Show("Your result:\r\n" + results[0] + "\r\n" + results[1] + "\r\n" + results[2], "Result", MessageBoxButtons.OK);
                    break;

                case 4:
                    MessageBox.Show("Your result:\r\n" + results[0] + "\r\n" + results[1] + "\r\n" + results[2] + "\r\n" + results[3], "Result", MessageBoxButtons.OK);
                    break;

                case 5:
                    MessageBox.Show("Your result:\r\n" + results[0] + "\r\n" + results[1] + "\r\n" + results[2] + "\r\n" + results[3] + "\r\n" + results[4], "Result", MessageBoxButtons.OK);
                    break;

                case 6:
                    MessageBox.Show("Your result:\r\n" + results[0] + "\r\n" + results[1] + "\r\n" + results[2] + "\r\n" + results[3] + "\r\n" + results[4] + "\r\n" + results[5], "Result", MessageBoxButtons.OK);
                    break;
            }
        }
    }
}
