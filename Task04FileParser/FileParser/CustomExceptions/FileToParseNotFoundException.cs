// <copyright file="FileToParseNotFoundException.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    using System;

    /// <summary>
    /// Represents a class of custom exception to be thrown if file could not be found at path provided by user.
    /// </summary>
    public class FileToParseNotFoundException : ApplicationException
    {
        /// <summary>Initializes a new instance of the <see cref="FileToParseNotFoundException"/> class.</summary>
        public FileToParseNotFoundException()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="FileToParseNotFoundException"/> class.</summary>
        /// <param name="path">Path to file that could not be found.</param>
        public FileToParseNotFoundException(string path)
            : base(string.Format("The file {0} does not exist", path))
        {
        }
    }
}
