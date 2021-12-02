using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Game
    {
        private int countMoves;
        private readonly Board board;
        private readonly Player player1;
        private readonly Player player2;

        public Game()
        {
            countMoves = 1;
            board = new Board();
            player1 = new Player(Player.Symbol.X);
            player2 = new Player(Player.Symbol.O);
        }

        public void Play(int cell)
        {
            Player player = countMoves++ % 2 == 0 ? player2 : player1;
            board.Play(cell, player);
        }

        public bool IsThereWinner()
        {
            return board.ValidateTicTacToe();
        }

        public string Winner()
        {
            return board.Winner.ToString();
        }

        public string[] GetBoard()
        {
            return board.GetBoard();
        }
    }
}
