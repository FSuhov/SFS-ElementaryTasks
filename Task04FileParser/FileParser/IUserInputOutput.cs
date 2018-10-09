// <copyright file="IUserInputOutput.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FileParser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contains methods for getting the data required for file parsing
    /// and for visual representation of the parsing results
    /// </summary>
    internal interface IUserInputOutput
    {
        /// <summary>
        /// Declaration of method that reads or gets data for file parsing
        /// </summary>
        /// <param name="args"> Array containing path, string to find and replacement [optional] </param>
        void ReadUserInput(string[] args);

        /// <summary>
        /// Declaration of method that does implements the logic of file parsing
        /// </summary>
        void ParseFile();

        /// <summary>
        /// Declaration of method that visualises the results of parsing
        /// </summary>
        /// <param name="count">Number of entries found during file parsing</param>
        void ShowResult(int count);
    }
}
