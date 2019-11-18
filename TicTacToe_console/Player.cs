using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    class Player
    {
        protected static List<Player> activePlayers = new List<Player>();
        protected string playerName;
        protected int CrossOrCircle;
        protected string color;

        // public getter, so everyone can see the list
        // but protected field, so that player and classes that derive from it can change the list
        public static List<Player> ActivePlayers { get => activePlayers;}
        
        public Player(string name, bool amICircle)
        {
            this.playerName = name;
            if (amICircle == true)
            {
                CrossOrCircle = 1;
                color = "Circle";
            }
            else
            {
                CrossOrCircle = 2;
                color = "Cross";

            }

            activePlayers.Add(this);
        }


        public virtual void TakeTurn(TicTacToeBoard board, (int, int) spot)
        {
            Piece piece = new Piece(CrossOrCircle, spot);
            board.AddPiece(piece);
        }
        public override string ToString()
        {
            string message = string.Format("{0} is playing {1}", playerName, color);
            return message;
        }
    }
}
