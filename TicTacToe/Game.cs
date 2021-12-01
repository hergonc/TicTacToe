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
        private int countMoves = 1;

        public string[] GetBoard()
        {
            return board;
        }

        public void Play(int i)
        {
            board[i] = countMoves++ % 2 == 0 ? "O" : "X";
        }
    }
}
