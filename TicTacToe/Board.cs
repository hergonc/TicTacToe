using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Board
    {
        private readonly List<Player> board = new List<Player>()
        {
            new Player(), new Player(), new Player(),
            new Player(), new Player(), new Player(),
            new Player(), new Player(), new Player()
        };

        public Player Winner { get; private set; }

        public string[] GetBoard()
        {
            return board.Select(p => p.ToString()).ToArray();
        }

        public void Play(int cell, Player player)
        {
            board[cell] = player;
        }

        public bool ValidateTicTacToe()
        {
            if (!string.IsNullOrEmpty(board[1].ToString())
                && board[1] == board[4]
                && board[4] == board[7])
            {
                Winner = board[1];
                return true;
            }
            if (!string.IsNullOrEmpty(board[6].ToString())
                && board[6] == board[4]
                && board[4] == board[2])
            {
                Winner = board[6];
                return true;
            }
            return false;
        }
    }
}