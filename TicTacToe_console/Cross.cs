using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    public class Cross : Piece
    {
        public Cross((int, int) position, int type = 2) : base(type, position)
        {
        }
    }
}
