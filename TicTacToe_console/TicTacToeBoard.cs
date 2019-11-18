using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    public class TicTacToeBoard
    {
        private int[,] board;
        private List<Piece> piecesOnBoard = new List<Piece>();
        private List<(int, int)> freeSpots = new List<(int, int)>();
        private bool gameOver = false;
        private int winner = 0;

        public int[,] Board { get => board; }
        public List<(int, int)> FreeSpots { get => freeSpots; }
        public int Winner { get => winner; }

        public TicTacToeBoard(int size = 3)
        {
            board = new int[size, size];
            GetFreeSports();
        }

        public bool AddPiece(Piece newPiece)
        {

            if (gameOver == true) return false;
            if (!freeSpots.Contains(newPiece.Position))
            {
                Console.WriteLine("This spot is taken");
                return false;

            }
            else
            {
                piecesOnBoard.Add(newPiece);
                Update();
                //Console.WriteLine("Piece placed");
                return true;
            }
        }

        private void GetFreeSports()
        {
            freeSpots = new List<(int, int)>();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 0)
                    {
                        freeSpots.Add((i, j));
                    }
                }
            }
        }
        public bool Update()
        {
            // checks if game is already over
            if (GameOverCheck(this) == true || gameOver == true)
            {
                gameOver = true;
                Console.WriteLine("And the winner is....." + winner);
                return false;
            }
            // puts each piece on the board as an int
            foreach (var item in piecesOnBoard)
            {
                board[item.Position.i, item.Position.j] = (int)(item.PieceType);
            }
            // updates free sports
            GetFreeSports();
            return true;
        }
        public bool IsBoardFilled()
        {
            if (freeSpots.Count == 0) return true;
            else return false;
        }
        public bool GameOverCheck(TicTacToeBoard board)
        {
            if (freeSpots.Count <= 0)
            {
                winner = 0;
                return true;
            }
            // checks if game is over and sets winner
            List<int[]> allPosibilities = new List<int[]>();

            // checking winning conditions
            int[] row01 = new int[3];
            int[] row02 = new int[3];
            int[] row03 = new int[3];
            int[] column01 = new int[3];
            int[] column02 = new int[3];
            int[] column03 = new int[3];
            List<int> cross01 = new List<int>();
            List<int> cross02 = new List<int>();
            allPosibilities.Add(row01);
            allPosibilities.Add(row02);
            allPosibilities.Add(row03);
            allPosibilities.Add(column01);
            allPosibilities.Add(column02);
            allPosibilities.Add(column03);

            //rows
            for (int i = 0; i < 3; i++)
            {
                    //columns
                for (int j = 0; j < 3; j++)
                {
                    switch (i)
                    {
                        case 0:
                            row01[j] = board.board[i, j];
                            if (j == 2) cross02.Add(board.board[i, j]);
                            switch (j)
                            {
                                case 0:
                                    column01[0] = board.board[i, j];
                                    break;
                                case 1:
                                    column02[0] = board.board[i, j];
                                    break;
                                case 2:
                                    column03[0] = board.board[i, j];
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 1:
                            row02[j] = board.board[i, j];
                            if (j == 1) cross02.Add(board.board[i, j]);
                            switch (j)
                            {
                                case 0:
                                    column01[1] = board.board[i, j];
                                    break;
                                case 1:
                                    column02[1] = board.board[i, j];
                                    break;
                                case 2:
                                    column03[1] = board.board[i, j];
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            row03[j] = board.board[i, j];
                            if (j == 0) cross02.Add(board.board[i, j]);
                            switch (j)
                            {
                                case 0:
                                    column01[2] = board.board[i, j];
                                    break;
                                case 1:
                                    column02[2] = board.board[i, j];
                                    break;
                                case 2:
                                    column03[2] = board.board[i, j];
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    if (i == j) cross01.Add(board.board[i, j]);
                }
            }
            allPosibilities.Add(cross01.ToArray());
            allPosibilities.Add(cross02.ToArray());

            foreach (var item in allPosibilities)
            {
                if (item.ToList().Contains(0))
                {
                    continue;
                }
                if (item.ToList().Distinct().ToList().Count == 1)
                {
                    winner = item[0];
                    return true;
                }
            }
            return false;
        }
    }
}
