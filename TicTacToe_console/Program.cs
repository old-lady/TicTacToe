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



            Player player01 = new Player("Julia", true);
            Player player02 = new Player("Julia2", false);
            //AIPlayer player02 = new AIPlayer(false);
            //Console.WriteLine(player01);

            while (board.GameOverCheck(board) == false)
            {
                int userChoice;

                UI.PrintFreeSpots(board);
                userChoice = UI.InputChoise("Pick a spot, player 1", board);
                player01.TakeTurn(board, board.FreeSpots[userChoice - 1]);
                UI.PrintBoard(board.Board);

                if (board.GameOverCheck(board) == true) continue;
                UI.PrintFreeSpots(board);
                userChoice = UI.InputChoise("Pick a spot, player 2", board);
                player02.TakeTurn(board, board.FreeSpots[userChoice - 1]);
                //Console.WriteLine("Player 2:");
                //player02.TakeTurn(board);
                UI.PrintBoard(board.Board);
                

            }

        }
    }
}
