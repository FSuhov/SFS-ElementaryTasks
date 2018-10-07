// <copyright file="UserInterfaceConsole.cs" company="Oleksandr Brylov">
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
    /// Contains fields and methods for user interaction via Console
    /// </summary>
    public class UserInterfaceConsole : IBoardCreator, IBoardVisualiser
    {
        private int width;
        private int height;
        private bool isWhiteBelow;

        /// <summary>
        /// Reads user input and creates a new instance of Board
        /// </summary>
        /// <param name="args"> Command line arguments </param>
        /// <returns>New instance of Board </returns>
        public Board CreateBoard(string[] args)
        {
            BoardConfig.ArgsStatus status = this.ValidateArgs(args);
            switch (status)
            {
                case BoardConfig.ArgsStatus.InvalidArgs:
                    Console.WriteLine("Something wrong with arguments");
                    Console.WriteLine("===================================");
                    Console.WriteLine(BoardConfig.UserManual);
                    break;
                case BoardConfig.ArgsStatus.NoArgs:
                    Console.WriteLine("No arguments passed.");
                    Console.WriteLine("===================================");
                    Console.WriteLine(BoardConfig.UserManual);
                    break;
                default:
                    return this.CreateBoard(this.width, this.height, this.isWhiteBelow);
            }

            return null;
        }

        /// <summary>
        /// Validates command line arguments and records it to fields of current instance
        /// </summary>
        /// <param name="args"> Command line arguments </param>
        /// <returns> Validation result </returns>
        public BoardConfig.ArgsStatus ValidateArgs(string[] args)
        {
            int numberOfArgs = args.Length;
            switch ((BoardConfig.ArgsStatus)numberOfArgs)
            {
                case BoardConfig.ArgsStatus.ThreeArgs:
                    {
                        if (this.ParseThreeArgs(args))
                        {
                            return BoardConfig.ArgsStatus.ThreeArgs;
                        }
                    }

                    break;

                case BoardConfig.ArgsStatus.TwoArgs:
                    {
                        if (this.ParseTwoArgs(args))
                        {
                            return BoardConfig.ArgsStatus.TwoArgs;
                        }
                    }

                    break;

                case BoardConfig.ArgsStatus.OneArg:
                    {
                        if (int.TryParse(args[0], out this.width) && this.ValidateMinMaxSize(this.width, this.width))
                        {
                            this.height = this.width;
                            return BoardConfig.ArgsStatus.OneArg;
                        }
                    }

                    break;

                case BoardConfig.ArgsStatus.NoArgs:
                    return BoardConfig.ArgsStatus.NoArgs;

                default:
                    return BoardConfig.ArgsStatus.InvalidArgs;
            }

            return BoardConfig.ArgsStatus.InvalidArgs;
        }

        /// <summary>
        /// Prints Chessboard on the console
        /// </summary>
        /// <param name="board"> Instance of Board </param>
        public void PrintBoard(Board board)
        {
            Console.Write("  ");
            if (board.IsWhitesBelow)
            {
                for (int i = 0; i < BoardConfig.NumberOfCellsHorizontal; i++)
                {
                    for (int j = 0; j < board.WhiteCell.Width; j++)
                    {
                        if (j == board.WhiteCell.Width / 2)
                        {
                            Console.Write(BoardConfig.Letters[i]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0, j = 7; i < BoardConfig.NumberOfCellsVertical / 2; i++, j--)
                {
                    this.PrintOneRowOfCellsStartsWithWhiteCell(board, j);
                    this.PrintOneRowOfCellsStartsWithBlackCell(board, --j);
                }
            }
            else
            {
                for (int i = BoardConfig.NumberOfCellsHorizontal - 1; i >= 0; i--)
                {
                    for (int j = 0; j < board.WhiteCell.Width; j++)
                    {
                        if (j == board.WhiteCell.Width / 2)
                        {
                            Console.Write(BoardConfig.Letters[i]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0, j = 0; i < BoardConfig.NumberOfCellsVertical / 2; i++, j++)
                {
                    this.PrintOneRowOfCellsStartsWithBlackCell(board, j);
                    this.PrintOneRowOfCellsStartsWithWhiteCell(board, ++j);
                }
            }
        }

        private bool ParseThreeArgs(string[] args)
        {
            return int.TryParse(args[0], out this.width) &&
                   int.TryParse(args[1], out this.height) &&
                   bool.TryParse(args[2], out this.isWhiteBelow) &&
                   this.ValidateMinMaxSize(this.width, this.height);
        }

        private bool ParseTwoArgs(string[] args)
        {
            return int.TryParse(args[0], out this.width) &&
                   int.TryParse(args[1], out this.height) &&
                   this.ValidateMinMaxSize(this.width, this.height);
        }

        private bool ValidateMinMaxSize(int width, int height)
        {
            return width >= BoardConfig.MinWidth &&
                   width <= BoardConfig.MaxWidth &&
                   height >= BoardConfig.MinHeight &&
                   height <= BoardConfig.MaxHeight;
        }

        private Board CreateBoard(int width, int height, bool isWhite = true)
        {
            return new Board(width, height, isWhite);
        }

        private void PrintCell(Cell cell)
        {
            for (int i = 0; i < cell.Width; i++)
            {
                if (cell.IsWhite)
                {
                    Console.Write(BoardConfig.SymbolWhite);
                }
                else
                {
                    Console.Write(BoardConfig.SymbolBlack);
                }
            }
        }

        private void PrintOneLineStartsWithWhiteCell(Board board)
        {
            for (int i = 0; i < BoardConfig.NumberOfCellsHorizontal / 2; i++)
            {
                this.PrintCell(board.WhiteCell);
                this.PrintCell(board.BlackCell);
            }

            Console.WriteLine();
        }

        private void PrintOneLineStartsWithBlackCell(Board board)
        {
            for (int i = 0; i < BoardConfig.NumberOfCellsHorizontal / 2; i++)
            {
                this.PrintCell(board.BlackCell);
                this.PrintCell(board.WhiteCell);
            }

            Console.WriteLine();
        }

        private void PrintOneRowOfCellsStartsWithWhiteCell(Board board, int row)
        {
            for (int i = 0; i < board.WhiteCell.Height; i++)
            {
                if (i == board.WhiteCell.Height / 2)
                {
                    Console.Write(BoardConfig.Numbers[row] + " ");
                }
                else
                {
                    Console.Write("  ");
                }

                this.PrintOneLineStartsWithWhiteCell(board);
            }
        }

        private void PrintOneRowOfCellsStartsWithBlackCell(Board board, int row)
        {
            for (int i = 0; i < board.BlackCell.Height; i++)
            {
                if (i == board.BlackCell.Height / 2)
                {
                    Console.Write(BoardConfig.Numbers[row] + " ");
                }
                else
                {
                    Console.Write("  ");
                }

                this.PrintOneLineStartsWithBlackCell(board);
            }
        }
    }
}
