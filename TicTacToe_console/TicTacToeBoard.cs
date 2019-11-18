using System.Collections.Generic;

namespace TicTacToe_console
{
    public class TicTacToeBoard
    {
        private int[,] board;
        private List<Piece> piecesOnBoard = new List<Piece>();
        private List<(int, int)> freeSpots = new List<(int, int)>();

        public int[,] Board { get => board; set => board = value; }
        public List<(int, int)> FreeSpots { get => freeSpots; }

        public TicTacToeBoard(int size = 3)
        {
            board = new int[size, size];
            GetFreeSports();
        }

        public bool AddPiece(Piece newPiece)
        {
            if (!freeSpots.Contains(newPiece.Position))
            {
                System.Console.WriteLine("This spot is taken");
                return false;

            }
            else
            {
                piecesOnBoard.Add(newPiece);
                Update();
                System.Console.WriteLine("Piece placed");
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
        public void Update()
        {
            foreach (var item in piecesOnBoard)
            {
                board[item.Position.i, item.Position.j] = (int)(item.PieceType);
            }
            GetFreeSports();
            
        }
        public bool IsBoardFilled()
        {
            if (freeSpots.Count == 0) return true;
            else return false;
        }
    }       
}           
            