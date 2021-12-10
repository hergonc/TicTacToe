using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Cell
    {
        public Player Player { get; private set; }
        private List<TypeLine> TypesLine { get; }

        public enum TypeLine
        {
            Horizontal1,
            Horizontal2,
            Horizontal3,
            Vertical1,
            Vertical2,
            Vertical3,
            Diagonal1,
            Diagonal2
        }

        public Cell(Player player, List<TypeLine> typesLine)
        {
            this.Player = player;
            this.TypesLine = typesLine;
        }

        public bool CheckPlayerInTypeLine(Player player, TypeLine typeLine)
        {
            return this.Player == player && this.TypesLine.Contains(typeLine);
        }
        public void SetPlayer(Player player)
        {
            if (!IsEmpty()) throw new InvalidOperationException();
            this.Player = player;
        }

        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(this.Player.ToString());
        }

    }
}