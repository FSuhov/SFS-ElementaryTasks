// <copyright file="IFileParser.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    /// <summary>
    /// Declares a method for file parsing in specific classes
    /// </summary>
    internal interface IFileParser
    {
        /// <summary>
        /// Implements the spesific logic of file parsing.
        /// </summary>
        /// <returns> Number of entries. </returns>
        int ParseFile();
    }
}
