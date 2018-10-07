// <copyright file="BoardConfig.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ChessBoard
{
    /// <summary>
    /// Contains static and constant fields for the application
    /// </summary>
    public static class BoardConfig
    {
        /// <summary> Text of user manual </summary>
        public const string UserManual = "Chessboard Application by Alex Brylov \n" +
                                   "Please start this application with command line:\n" +
                                   "on Windows 10:\n" +
                                   "1. look up for cmd and launch it\n" +
                                   "2. navigate to directory with .exe file: cd d:\\All repos goes here\\Elementarytasks\\ElementarytasksAlexBrylov\\bin\\debug" +
                                   "3. print: chessboard.exe followed by desired width and height of chessboard";

        /// <summary> Symbol for black cell </summary>
        public const char SymbolBlack = '*';

        /// <summary> Symbol for white cell </summary>
        public const char SymbolWhite = ' ';

        /// <summary> Width of ChessBoard in cells horizontal </summary>
        public const int NumberOfCellsHorizontal = 8;

        /// <summary> Width of ChessBoard in cells vertical </summary>
        public const int NumberOfCellsVertical = 8;

        /// <summary> Minimal width of Chessboard for valid console visualization </summary>
        public const int MinWidth = 8;

        /// <summary> Minimal height of Chessboard for valid console visualization </summary>
        public const int MinHeight = 8;

        /// <summary> Maximum width of Chessboard for valid console visualization </summary>
        public const int MaxWidth = 128;

        /// <summary> Maximum height of Chessboard for valid console visualization </summary>
        public const int MaxHeight = 96;

        /// <summary> A set of letters for horizontal identification of cell of chessboard </summary>
        public static readonly char[] Letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        /// <summary> A set of numbers for vertical identification of cell of chessboard </summary>
        public static readonly int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

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
            ThreeArgs,

            /// <summary> At least one of arguments is invalid </summary>
            InvalidArgs
        }
    }
}
