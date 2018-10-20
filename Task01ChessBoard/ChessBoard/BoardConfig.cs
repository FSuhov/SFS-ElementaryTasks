// <copyright file="BoardConfig.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 01 - Chessboard.
// </copyright>

namespace ChessBoard
{
    using System;

    /// <summary>
    /// Contains static and constant fields for the application
    /// </summary>
    public static class BoardConfig
    {
        /// <summary> Symbol for black cell </summary>
        public const char SYMBOL_BLACK = '*';

        /// <summary> Symbol for white cell </summary>
        public const char SYMBOL_WHITE = ' ';

        /// <summary> Advise to be shown when no arguments provided </summary>
        public const string MESSAGE_NO_ARGS = "You have to provide at least one command line argument - widht of board";

        /// <summary> Advise to be shown when arguments can't be parsed </summary>
        public const string MESSAGE_INVALID_ARGS = "Please check arguments: first and second must be a numbers, optional third - true or false";

        /// <summary> Width of ChessBoard in cells horizontal </summary>
        public const int CELLS_HORIZONTAL = 8;

        /// <summary> Width of ChessBoard in cells vertical </summary>
        public const int CELLS_VERTICAL = 8;

        /// <summary> Minimal width of Chessboard for valid console visualization </summary>
        public const int MIN_WIDTH = 8;

        /// <summary> Minimal height of Chessboard for valid console visualization </summary>
        public const int MIN_HEIGHT = 8;

        /// <summary> Maximum width of Chessboard for valid console visualization </summary>
        public const int MAX_WIDTH = 128;

        /// <summary> Maximum height of Chessboard for valid console visualization </summary>
        public const int MAX_HEIGHT = 96;

        /// <summary> Text of user manual </summary>
        public static readonly string USER_MANUAL = string.Format(
                                                   "========================================================================================{0}"
                                                 + "Please start this application with command line:{0}"
                                                 + "1. look up for cmd and launch it{0}"
                                                 + @"2. navigate to directory with.exe file, for example: cd d:\REPOS\CHESSBOARD\{0}"
                                                 + "3.type: chessboard.exe followed by desired width and height of chessboard{0}"
                                                 + "You may also enter optional third boolean argument - whether black player is located above (default, true){0}"
                                                 + "========================================================================================",
                                                   Environment.NewLine);

        /// <summary> Advise to be shown when user wants too small or too large board </summary>
        public static readonly string MESSAGE_BAD_SIZING
                                    = string.Format(
                                      "The size of board you entered will result poor visualization.{0}"
                                    + "Please enter the width between {1} and {2}{0}"
                                    + "and heigt between {3} and {4}",
                                      Environment.NewLine,
                                      MIN_WIDTH,
                                      MAX_WIDTH,
                                      MIN_HEIGHT,
                                      MAX_HEIGHT);

        /// <summary> A set of letters for horizontal identification of cell of chessboard </summary>
        public static readonly char[] LETTERS = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        /// <summary> A set of numbers for vertical identification of cell of chessboard </summary>
        public static readonly int[] NUMBERS = { 8, 7, 6, 5, 4, 3, 2, 1 };

        /// <summary>
        /// Enum representing available command line validation results
        /// </summary>
        public enum ArgsStatus
        {
            /// <summary> Args are empty </summary>
            NoArgs,

            /// <summary> One argument passed </summary>
            OneArg,

            /// <summary> Two argument passed </summary>
            TwoArgs,

            /// <summary> Three argument passed </summary>
            ThreeArgs
        }

        /// <summary> Contains possible application status flags </summary>
        public enum ApplicationStatus
        {
            /// <summary> Args are empty </summary>
            NoArgs,

            /// <summary> At least one of arguments is invalid </summary>
            InvalidArgs,

            /// <summary> Valid arguments submitted, but they will result poor visualization </summary>
            BadSizing,

            /// <summary> Valid arguments provided, board created </summary>
            Success
        }
    }
}
