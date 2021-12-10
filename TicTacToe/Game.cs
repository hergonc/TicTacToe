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
            countMoves = 0;
            board = new Board();
            player1 = new Player(Player.Symbol.X);
            player2 = new Player(Player.Symbol.O);
        }

        public void Play(int cell)
        {
            countMoves++;
            board.Play(cell, ActivePlayer());
        }

        public bool IsThereWinner()
        {
            return board.ValidateTicTacToe(ActivePlayer());
        }

        public string Winner()
        {
            return board.Winner == null ? "" : board.Winner.ToString();
        }

        public string[] Render()
        {
            return board.Render();
        }

        private Player ActivePlayer()
        {
            return countMoves % 2 == 0 ? player2 : player1;
        }
    }
}
