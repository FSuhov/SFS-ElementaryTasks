// <copyright file="Program.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 01 - Chessboard.
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
            string[] localArgs = { };
            ChessBoardConsoleUserInterface chessBoard = new ChessBoardConsoleUserInterface();
            chessBoard.ReadInputAndSetStatus(localArgs);
            chessBoard.PrintBoardOrMessage();
        }
    }
}
