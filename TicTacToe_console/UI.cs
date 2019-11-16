using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    public static class UI
    {
        public static void PrintBoard(int[,] board)
        {
            Console.WriteLine();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1) Console.ForegroundColor = ConsoleColor.Red;
                    else if (board[i, j] == 2) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(board[i,j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintFreeSpots(this TicTacToeBoard board)
        {
            for (int i = 0; i < board.FreeSpots.Count; i++)
            {
                Console.WriteLine(i + 1 + " " + board.FreeSpots[i]);
            }
        }
        
        public static int InputChoise(string message, TicTacToeBoard board)
        {
            int[] choices = new int[board.FreeSpots.Count];
            for (int i = 0; i < choices.Length; i++)
            {
                choices[i] = i + 1;
            }
        start:
            Console.CursorVisible = true;
            bool choiceMade = false;
            int userInput = -1;
            int wrongUserInput = -1;
            string errorText = " is not valid input. ";

            int[] rightAnswers = choices;

            Console.WriteLine(message);
            do
            {
                try
                {
                    Console.Write("\n Your input ->  ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    wrongUserInput = userInput;
                    errorText = wrongUserInput + errorText;

                    if (Array.Exists(rightAnswers, element => element == userInput)) return userInput;
                    else Console.WriteLine(errorText);
                }
                catch (Exception)
                {
                    Console.WriteLine("This " + errorText);
                    goto start;
                }
            } while (choiceMade == false);
            return choices[0];
        }

    }
}
