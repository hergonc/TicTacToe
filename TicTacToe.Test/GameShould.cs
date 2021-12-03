using System;
using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class GameShould
    {
        private readonly Game game = new Game();

        [Fact]
        public void When_the_game_start_the_board_is_empty()
        {
            var boardExpected = new[] { "", "", "", "", "", "", "", "", "" };

            var board = game.Render();

            Assert.Equal(boardExpected, board);
        }

        [Fact]
        public void Player1_start_playing()
        {
            var boardExpected = new[] { string.Empty, string.Empty, string.Empty, 
                                        string.Empty, "X", string.Empty,
                                        string.Empty, string.Empty, string.Empty };

            game.Play(4);
            var board = game.Render();

            Assert.Equal(boardExpected, board);
        }

        [Fact]
        public void Second_Movement_is_player2()
        {
            var boardExpected = new[] { string.Empty, string.Empty, string.Empty,
                string.Empty, "X", string.Empty,
                string.Empty, string.Empty, "O" };

            game.Play(4);
            game.Play(8);
            var board = game.Render();

            Assert.Equal(boardExpected, board);
        }

        [Fact]
        public void Player1_wins_in_five_movements()
        {
            var winnerExpected = "X";
            int[] moves = { 4, 0, 1, 6, 7};

            foreach (var move in moves)
            {
                game.Play(move);
                if (game.IsThereWinner())
                    break;
            }
            
            Assert.Equal(winnerExpected, game.Winner());
        }

        [Fact]
        public void Player2_wins_in_diagonal_line()
        {
            var winnerExpected = "O";
            int[] moves = { 0, 4, 3, 6, 5, 2 };

            foreach (var move in moves)
            {
                game.Play(move);
                if (game.IsThereWinner())
                    break;
            }

            Assert.Equal(winnerExpected, game.Winner());
        }
    }
}
