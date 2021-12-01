using System;
using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class GameShould
    {
        [Fact]
        public void When_the_game_start_the_board_is_empty()
        {
            var boardExpected = new[] { "", "", "", "", "", "", "", "", "" };

            var board = new Game().GetBoard();

            Assert.Equal(boardExpected, board);
        }

        [Fact]
        public void Player1_start_playing()
        {
            var boardExpected = new[] { string.Empty, string.Empty, string.Empty, 
                                        string.Empty, "X", string.Empty,
                                        string.Empty, string.Empty, string.Empty };

            var game = new Game();
            game.Play(4);
            var board = game.GetBoard();

            Assert.Equal(boardExpected, board);
        }
    }
}
