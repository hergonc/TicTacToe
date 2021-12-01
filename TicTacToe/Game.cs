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
        public string Winner { get; private set; }

        public string[] GetBoard()
        {
            return board;
        }

        public void Play(int i)
        {
            board[i] = countMoves++ % 2 == 0 ? "O" : "X";
        }

        public bool IsThereWinner()
        {
            if (!string.IsNullOrEmpty(board[1]) 
                && board[1] == board[4] 
                && board[4] == board[7]) 
                Winner = board[1];
            return !string.IsNullOrEmpty(Winner);
        }
    }
}
