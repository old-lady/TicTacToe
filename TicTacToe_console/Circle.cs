using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    public class Circle : Piece
    {
        public Circle((int, int) position, int type = 1) : base(type, position)
        {
        }
    }
}
