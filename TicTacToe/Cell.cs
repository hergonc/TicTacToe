using System.Collections.Generic;

namespace TicTacToe
{
    public class Cell
    {
        public Player Player { get; set; }
        public List<TypeLine> TypesLine { get; }

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

        public bool CheckPlayerInTpeLine(Player player, TypeLine typeLine)
        {
            return this.Player == player && this.TypesLine.Contains(typeLine);
        }
    }
}