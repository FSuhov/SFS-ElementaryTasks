// <copyright file="Config.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
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

        /// <summary> Enumerates the work mode available </summary>
        public enum WorkMode
        {
            /// <summary> Work mode not defined: incorrect user input or file not found </summary>
            NotSet = 1,

            /// <summary> Find mode </summary>
            Find,

            /// <summary> Replace mode </summary>
            Replace
        }
    }
}
