using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DHelper
{
    class CommonChoose
    {
        public static int UserChoice { get; private set; } = 0;

        public static void UserIsPlayerChoice()
        {
            UserChoice = 1;
        }

        public static void UserIsMasterChoice()
        {
            UserChoice = 2;
        }
    }
}
