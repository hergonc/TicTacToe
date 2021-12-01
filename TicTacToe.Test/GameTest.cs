using System;
using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class GameTest
    {
        [Fact]
        public void When_the_game_start_the_board_is_empty()
        {
            var boardExpected = new[] { "", "", "", "", "", "", "", "", "" };

            var board = new Game().GetBoard();

            Assert.Equal(boardExpected, board);
        }
    }
}
