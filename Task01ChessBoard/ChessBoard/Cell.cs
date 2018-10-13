// <copyright file="Cell.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 01 - Chessboard.
// </copyright>

namespace ChessBoard
{
    /// <summary>
    /// Represents a cell of Chessboard
    /// </summary>
    public class Cell
    {
        /// <summary> Initializes a new instance of the <see cref="Cell"/> class. </summary>
        /// <param name="width"> Width of cell. </param>
        /// <param name="height"> Height of cell. </param>
        /// <param name="isWhite"> Indicates whether the color of cell is white. </param>
        public Cell(int width, int height, bool isWhite)
        {
            this.Width = width;
            this.Height = height;
            this.IsWhite = isWhite;
        }

        /// <summary> Gets or sets width of cell </summary>
        public int Width { get; set; }

        /// <summary> Gets or sets height of cell </summary>
        public int Height { get; set; }

        /// <summary> Gets or sets a value indicating whether the color of cell is white </summary>
        public bool IsWhite { get; set; }
    }
}
