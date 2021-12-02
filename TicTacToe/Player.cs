namespace TicTacToe
{
    public class Player
    {
        public enum Symbol
        {
            X,
            O
        }

        private readonly Symbol? symbol;

        public Player()
        {
            symbol = null;
        }

        public Player(Symbol symbol)
        {
            this.symbol = symbol;
        }

        public override string ToString()
        {
            return symbol == null ? "" : this.symbol.ToString();
        }
    }
}