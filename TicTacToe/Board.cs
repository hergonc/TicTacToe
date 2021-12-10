using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Board
    {
        private readonly List<Cell> board = new List<Cell>()
        {
            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Diagonal1, Cell.TypeLine.Horizontal1, Cell.TypeLine.Vertical1}),
            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Horizontal1, Cell.TypeLine.Vertical2}),
            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Diagonal2, Cell.TypeLine.Horizontal1, Cell.TypeLine.Vertical3}),

            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Horizontal2, Cell.TypeLine.Vertical1}),
            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Diagonal1, Cell.TypeLine.Diagonal2, Cell.TypeLine.Horizontal2, Cell.TypeLine.Vertical2}),
            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Horizontal2, Cell.TypeLine.Vertical3}),

            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Diagonal2, Cell.TypeLine.Horizontal3, Cell.TypeLine.Vertical1}),
            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Horizontal3, Cell.TypeLine.Vertical2}),
            new Cell(new Player(), new List<Cell.TypeLine>(){ Cell.TypeLine.Diagonal1, Cell.TypeLine.Horizontal3, Cell.TypeLine.Vertical3})
        };

        public Player Winner { get; private set; }

        public string[] Render()
        {
            return board.Select(p => p.Player.ToString()).ToArray();
        }

        public void Play(int cell, Player player)
        {
            board[cell].SetPlayer(player);
        }

        public bool ValidateTicTacToe(Player player)
        {
            if (ValidateHorizontalLines(player) 
                || ValidateVerticalLines(player)
                || ValidateDiagonalLines(player))
            {
                Winner = player;
                return true;
            }
            return false;
        }

        private bool ValidateDiagonalLines(Player player)
        {
            return board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Diagonal1)) == 3
                   || board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Diagonal2)) == 3;
        }

        private bool ValidateVerticalLines(Player player)
        {
            return board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Vertical1)) == 3
                   || board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Vertical2)) == 3
                   || board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Vertical3)) == 3;
        }

        private bool ValidateHorizontalLines(Player player)
        {
            return board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Horizontal1)) == 3 
                   || board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Horizontal2)) == 3 
                   || board.Count(c => c.CheckPlayerInTypeLine(player, Cell.TypeLine.Horizontal3)) == 3;
        }
    }
}