// <copyright file="IBoardCreator.cs" company="Oleksandr Brylov">
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

    /// <summary> Contains prototypes of methods for instantiating Board from console input</summary>
    public interface IBoardCreator
    {
        /// <summary>
        /// Validates arguments and creates an instance of Board
        /// </summary>
        /// <param name="args"> Command line arguments </param>
        /// <returns> New instance of Board </returns>
        Board CreateBoard(string[] args);

        /// <summary>
        /// Validates arguments before passing to CreateBoard method
        /// </summary>
        /// <param name="args">Command line arguments </param>
        /// <returns> Validation result </returns>
        BoardConfig.ArgsStatus ValidateArgs(string[] args);
    }
}
