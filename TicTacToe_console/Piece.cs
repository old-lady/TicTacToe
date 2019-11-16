using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    public class Piece
    {
        private (int i, int j) position;
        private string type;
        private PieceTypeEnum pieceType;

        public (int i, int j) Position { get => position; set => position = value; }
        public PieceTypeEnum PieceType { get => pieceType; set => pieceType = value; }

        public Piece(int type, (int i, int j)position)
        {
            this.type = Enum.GetName(typeof(PieceTypeEnum), type).ToString();
            if (type == 1) this.pieceType = PieceTypeEnum.Circle;
            switch (type)
            {
                case 1:
                    this.pieceType = PieceTypeEnum.Circle;
                    break;
                case 2:
                    this.pieceType = PieceTypeEnum.Cross;
                    break;
                default:
                    break;
            }
            this.position = position;
        }

        public void PlacePiece((int, int) coordinates)
        {
            position = coordinates;
        }
        public enum PieceTypeEnum
        {
            Circle = 1,
            Cross,
        }

        public override string ToString()
        {
            string message = string.Format("I am a {0}", type);
            return message;
        }


    }
}
