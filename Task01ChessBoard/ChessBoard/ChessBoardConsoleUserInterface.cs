// <copyright file="ChessBoardConsoleUserInterface.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 01 - Chessboard.
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
    public class ChessBoardConsoleUserInterface
    {
        private Board _board;

        private BoardConfig.ApplicationStatus _status;

        /// <summary>
        /// Reads command line arguments, initializes instance of Board if valid, sets status of application.
        /// </summary>
        /// <param name="args"> Command line arguments proivided on launch. </param>
        public void ReadInputAndSetStatus(string[] args)
        {
            switch ((BoardConfig.ArgsStatus)args.Length)
            {
                case BoardConfig.ArgsStatus.NoArgs:
                    this._status = BoardConfig.ApplicationStatus.NoArgs;
                    break;
                case BoardConfig.ArgsStatus.OneArg:
                    this._status = this.InitBoard(args[0]);
                    break;
                case BoardConfig.ArgsStatus.TwoArgs:
                    this._status = this.InitBoard(args[0], args[1]);
                    break;
                case BoardConfig.ArgsStatus.ThreeArgs:
                    this._status = this.InitBoard(args[0], args[1], args[2]);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Prints on the console chessboard or error message and advise
        /// </summary>
        public void PrintBoardOrMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            switch (this._status)
            {
                case BoardConfig.ApplicationStatus.NoArgs:
                    Console.WriteLine("No arguments");
                    Console.ResetColor();
                    Console.WriteLine(BoardConfig.MESSAGE_NO_ARGS);
                    Console.WriteLine(BoardConfig.USER_MANUAL);
                    break;
                case BoardConfig.ApplicationStatus.InvalidArgs:
                    Console.WriteLine("Invalid arguments");
                    Console.ResetColor();
                    Console.WriteLine(BoardConfig.MESSAGE_INVALID_ARGS);
                    Console.WriteLine(BoardConfig.USER_MANUAL);
                    break;
                case BoardConfig.ApplicationStatus.BadSizing:
                    Console.WriteLine("Invalid arguments");
                    Console.ResetColor();
                    Console.WriteLine(BoardConfig.MESSAGE_BAD_SIZING);
                    Console.WriteLine(BoardConfig.USER_MANUAL);
                    break;
                default:
                    Console.ResetColor();
                    ChessBoardConsolePrinter.PrintBoard(this._board);
                    break;
            }
        }

        /// <summary> Gets current status of application. </summary>
        /// <returns> Current status of application. </returns>
        public BoardConfig.ApplicationStatus GetStatus()
        {
            return this._status;
        }

        private BoardConfig.ApplicationStatus InitBoard(string width)
        {
            BoardConfig.ApplicationStatus status;
            int boardWidth;
            if (int.TryParse(width, out boardWidth))
            {
                if (this.IsValidSizing(boardWidth))
                {
                    this._board = new Board(boardWidth, boardWidth);
                    status = BoardConfig.ApplicationStatus.Success;
                }
                else
                {
                    status = BoardConfig.ApplicationStatus.BadSizing;
                }
            }
            else
            {
                status = BoardConfig.ApplicationStatus.InvalidArgs;
            }

            return status;
        }

        private BoardConfig.ApplicationStatus InitBoard(string width, string height)
        {
            BoardConfig.ApplicationStatus status;
            int boardWidth;
            int boardHeight;
            if (int.TryParse(width, out boardWidth) && int.TryParse(height, out boardHeight))
            {
                if (this.IsValidSizing(boardWidth, boardHeight))
                {
                    this._board = new Board(boardWidth, boardHeight);
                    status = BoardConfig.ApplicationStatus.Success;
                }
                else
                {
                    status = BoardConfig.ApplicationStatus.BadSizing;
                }
            }
            else
            {
                status = BoardConfig.ApplicationStatus.InvalidArgs;
            }

            return status;
        }

        private BoardConfig.ApplicationStatus InitBoard(string width, string height, string whites)
        {
            BoardConfig.ApplicationStatus status;
            int boardWidth;
            int boardHeight;
            bool isWhite;
            if (int.TryParse(width, out boardWidth)
                && int.TryParse(height, out boardHeight)
                && bool.TryParse(whites, out isWhite))
            {
                if (this.IsValidSizing(boardWidth, boardHeight))
                {
                    this._board = new Board(boardWidth, boardHeight, isWhite);
                    status = BoardConfig.ApplicationStatus.Success;
                }
                else
                {
                    status = BoardConfig.ApplicationStatus.BadSizing;
                }
            }
            else
            {
                status = BoardConfig.ApplicationStatus.InvalidArgs;
            }

            return status;
        }

        private bool IsValidSizing(int boardWidth)
        {
            return boardWidth <= BoardConfig.MAX_WIDTH
                  && boardWidth >= BoardConfig.MIN_WIDTH
                  && boardWidth <= BoardConfig.MAX_HEIGHT
                  && boardWidth >= BoardConfig.MIN_HEIGHT;
        }

        private bool IsValidSizing(int boardWidth, int boardHeight)
        {
            return boardWidth <= BoardConfig.MAX_WIDTH
                  && boardWidth >= BoardConfig.MIN_WIDTH
                  && boardHeight <= BoardConfig.MAX_HEIGHT
                  && boardHeight >= BoardConfig.MIN_HEIGHT;
        }
    }
}
