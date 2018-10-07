// <copyright file="Board.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ChessBoard
{
    /// <summary>
    /// Represents a chessboard containing black and white cells
    /// </summary>
    public class Board
    {
        /// <summary> White cell for this board </summary>
        public Cell WhiteCell;

        /// <summary> Black cell for this board </summary>
        public Cell BlackCell;

        /// <summary> Is white player located in the bottom </summary>
        public bool IsWhitesBelow;

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="width"> Width of board </param>
        /// <param name="height"> Height of board </param>
        /// <param name="isWhitesBelow"> Indicates is the position of white player is in the bottom </param>
        public Board(int width, int height, bool isWhitesBelow)
        {
            this.WhiteCell.IsWhite = true;
            this.WhiteCell.Width = width / BoardConfig.NumberOfCellsHorizontal;
            this.WhiteCell.Height = height / BoardConfig.NumberOfCellsVertical;
            this.BlackCell.IsWhite = false;
            this.BlackCell.Width = width / BoardConfig.NumberOfCellsHorizontal;
            this.BlackCell.Height = height / BoardConfig.NumberOfCellsVertical;
            this.IsWhitesBelow = isWhitesBelow;
        }
    }
}
