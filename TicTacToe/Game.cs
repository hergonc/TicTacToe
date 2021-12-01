using System;

namespace TicTacToe
{
    public class Game
    {
        private readonly string[] board = {
            string.Empty, string.Empty, string.Empty,
            string.Empty, string.Empty, string.Empty,
            string.Empty, string.Empty, string.Empty
        };

        public string[] GetBoard()
        {
            return board;
        }

        public void Play(int i)
        {
            board[i] = "X";
        }
    }
}
