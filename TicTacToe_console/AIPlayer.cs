using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    class AIPlayer : Player
    {
        private static bool amICircle;
        public AIPlayer(string name = "Computer") : base(name, amICircle)
        {
            amICircle = true;
            
        }
    }
}
