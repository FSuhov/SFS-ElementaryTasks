// <copyright file="Config.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    /// <summary>
    /// Contains constants and static data for the application
    /// </summary>
    internal static class Config
    {
        /// <summary> User manual to be shown when invalid input </summary>
        public const string USER_MANUAL = "FILE PARSER\n" +
                                          "This application is designed to find entries in the text file.\n" +
                                          "You may launch it from command line passing either two or three arguments:\n" +
                                          "first - path to file, second - string to be found and third (optional) - replacement";

        /// <summary> Represents the possible number of arguments provided by user. </summary>
        public enum NumberOfArgs
        {
            /// <summary> When no arguments passed. </summary>
            NoArgs,

            /// <summary> When two arguments passed. </summary>
            TwoArgs = 2,

            /// <summary> When three arguments passed. </summary>
            ThreeArgs
        }

        /// <summary> Enumerates the work mode available </summary>
        public enum WorkMode
        {
            /// <summary> Work mode not defined: incorrect user input or file not found </summary>
            NotSet,

            /// <summary> Find mode </summary>
            Find,

            /// <summary> Replace mode </summary>
            Replace
        }
    }
}
