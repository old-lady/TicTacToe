using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    class Program
    {


        static void Main(string[] args)
        {
            Testing();
            Console.ReadKey();
        }

        public static void GameLoop()
        {
            TicTacToeBoard board = new TicTacToeBoard();
            while (true)
            {
                UI.PrintBoard(board.Board);
            }
        }
        private static void Testing()
        {
            TicTacToeBoard board = new TicTacToeBoard();
            UI.PrintBoard(board.Board);


            Player player01 = new Player("Julia", false);
            Console.WriteLine(player01);

            while (true)
            {
                UI.PrintFreeSpots(board);
                int userChoice = UI.InputChoise("Pick a spot", board);
                player01.TakeTurn(board, board.FreeSpots[userChoice - 1]);
                UI.PrintBoard(board.Board);

            }

        }
    }
}
