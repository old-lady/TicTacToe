using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    class AIPlayer : Player
    {
        private static Random rand = new Random();
        private static bool amICircle;
        public AIPlayer(bool amICircle, string name = "Computer") : base(name, amICircle)
        {
            //amICircle = true;
        }
        public override void TakeTurn(TicTacToeBoard board, (int, int) spot)
        {
            base.TakeTurn(board, spot);
        }
        public void TakeTurn(TicTacToeBoard board)
        {
            if (board.FreeSpots.Count <= 0) return;
            TakeTurn(board, FindGoodSpot(board));
        }

        private (int, int) FindGoodSpot(TicTacToeBoard board)
        {
            (int, int) goodSpot = board.FreeSpots[rand.Next(0, board.FreeSpots.Count)];

            return goodSpot;
        }
    }
}
