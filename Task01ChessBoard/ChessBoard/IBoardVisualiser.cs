// <copyright file="IBoardVisualiser.cs" company="Oleksandr Brylov">
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
    /// Contains prototypes of method for visualisation of Chessboard
    /// </summary>
    public interface IBoardVisualiser
    {
        /// <summary>
        /// A prototype of method visualising the Chessboard
        /// </summary>
        /// <param name="board"> An instance of Board </param>
        void PrintBoard(Board board);
    }
}
