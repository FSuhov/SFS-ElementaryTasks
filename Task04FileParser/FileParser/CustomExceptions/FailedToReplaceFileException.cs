// <copyright file="FailedToReplaceFileException.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    using System;

    /// <summary>
    /// Represents a class of custom exception occuring
    /// in case original file could not be replaced with temporary file.
    /// </summary>
    public class FailedToReplaceFileException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToReplaceFileException"/> class.
        /// </summary>
        public FailedToReplaceFileException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToReplaceFileException"/> class.</summary>
        /// <param name="path">Path to original file.</param>
        public FailedToReplaceFileException(string path)
            : base(string.Format("The file {0} could not be replaced", path))
        {
        }
    }
}
