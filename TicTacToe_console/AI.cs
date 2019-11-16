using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    public class AI
    {
        private int typeOfPiecesIAmPlayingWith;
        private static Random rand = new Random();
        

        public AI(bool AmIPlayingCircle)
        {
            if (AmIPlayingCircle) typeOfPiecesIAmPlayingWith = 1;
            else typeOfPiecesIAmPlayingWith = 2;
        }
        public void TakeTurn(TicTacToeBoard board)
        {
            


            //Piece newPiece = new Piece(typeOfPiecesIAmPlayingWith);
            //board.AddPiece(newPiece)
        }
        //private (int, int) FindGoodSpot(TicTacToeBoard board)
        //{
        //    foreach (var item in board.FreeSpots)
        //    {

        //    }
        //}
        //private bool WillThisSpotWin((int, int) spot)
        //{

        //}


    }
}
