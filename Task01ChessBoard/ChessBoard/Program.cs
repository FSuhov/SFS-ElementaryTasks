// <copyright file="Program.cs" company="Oleksandr Brylov">
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

    /// <summary> Contains an entry point of application </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] localArgs = { "48", "32", "true" };
            UserInterfaceConsole userInterface = new UserInterfaceConsole();
            Board board = userInterface.CreateBoard(localArgs);
            if (board != null)
            {
                userInterface.PrintBoard(board);
            }
        }
    }
}
