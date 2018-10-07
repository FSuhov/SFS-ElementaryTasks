// <copyright file="Cell.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ChessBoard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents a cell of Chessboard
    /// </summary>
    public struct Cell
    {
        /// <summary> Width of cell </summary>
        public int Width;

        /// <summary> Height of cell </summary>
        public int Height;

        /// <summary> Indicates whether the cell is white </summary>
        public bool IsWhite;
    }
}
