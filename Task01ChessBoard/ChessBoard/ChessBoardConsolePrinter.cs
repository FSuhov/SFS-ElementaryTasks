// <copyright file="ChessBoardConsolePrinter.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 01 - Chessboard.
// </copyright>

namespace ChessBoard
{
    using System;

    /// <summary>
    /// Contains static methods for console visualization of chessboard
    /// </summary>
    public class ChessBoardConsolePrinter
    {
        /// <summary> Prints chessboard on the console. </summary>
        /// <param name="board">An instance of Board. </param>
        public static void PrintBoard(Board board)
        {
            PrintFirstLine(board);
            for (int i = 0; i < BoardConfig.CELLS_VERTICAL; i++)
            {
                PrintRow(board, i);
            }
        }

        private static void PrintCell(Cell cell)
        {
            for (int i = 0; i < cell.Width; i++)
            {
                if (cell.IsWhite)
                {
                    Console.Write(BoardConfig.SYMBOL_WHITE);
                }
                else
                {
                    Console.Write(BoardConfig.SYMBOL_BLACK);
                }
            }
        }

        private static void PrintOneLineStraight(Board board)
        {
            for (int i = 0; i < BoardConfig.CELLS_HORIZONTAL / 2; i++)
            {
                PrintCell(board.FirstCell);
                PrintCell(board.SecondCell);
            }

            Console.WriteLine();
        }

        private static void PrintOneLineReverse(Board board)
        {
            for (int i = 0; i < BoardConfig.CELLS_HORIZONTAL / 2; i++)
            {
                PrintCell(board.SecondCell);
                PrintCell(board.FirstCell);
            }

            Console.WriteLine();
        }

        private static void PrintRow(Board board, int row)
        {
            for (int i = 0; i < board.FirstCell.Height; i++)
            {
                if (i == board.FirstCell.Height / 2)
                {
                    Console.Write(board.VerticalCoords[row] + " ");
                }
                else
                {
                    Console.Write("  ");
                }

                if (row % 2 == 0)
                {
                    PrintOneLineStraight(board);
                }
                else
                {
                    PrintOneLineReverse(board);
                }
            }
        }

        private static void PrintFirstLine(Board board)
        {
            Console.Write("  ");

            for (int i = 0; i < BoardConfig.CELLS_HORIZONTAL; i++)
            {
                for (int j = 0; j < board.FirstCell.Width; j++)
                {
                    if (j == board.FirstCell.Width / 2)
                    {
                        Console.Write(board.HorizontalCoords[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
