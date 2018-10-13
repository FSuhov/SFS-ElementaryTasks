// <copyright file="Board.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 01 - Chessboard.
// </copyright>

namespace ChessBoard
{
    using System;

    /// <summary>
    /// Represents a chessboard containing black and white cells
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="width"> Width of board </param>
        /// <param name="height"> Height of board </param>
        /// <param name="isWhites"> Indicates is the position of white player is in the bottom </param>
        public Board(int width, int height, bool isWhites = true)
        {
            int cellWidth = width / BoardConfig.CELLS_HORIZONTAL;
            int cellHeight = height / BoardConfig.CELLS_VERTICAL;
            this.InitCells(cellWidth, cellHeight, isWhites);

            this.HorizontalCoords = BoardConfig.LETTERS;
            this.VerticalCoords = BoardConfig.NUMBERS;

            if (!isWhites)
            {
                Array.Reverse(this.HorizontalCoords);
                Array.Reverse(this.VerticalCoords);
            }
        }

        /// <summary> Gets or sets letters to be shown at the top of board. </summary>
        public char[] HorizontalCoords { get; set; }

        /// <summary> Gets or sets numbers to be shown on the left of board. </summary>
        public int[] VerticalCoords { get; set; }

        /// <summary> Gets or sets top left cell of this board. </summary>
        public Cell FirstCell { get; set; }

        /// <summary> Gets or sets top second left cell of this board. </summary>
        public Cell SecondCell { get; set; }

        private void InitCells(int width, int height, bool isWhite)
        {
            bool isFirstCellWhite = isWhite;
            bool isSecondCellWhite = isFirstCellWhite ? false : true;

            this.FirstCell = new Cell(width, height, isFirstCellWhite);
            this.SecondCell = new Cell(width, height, isSecondCellWhite);
        }
    }
}
