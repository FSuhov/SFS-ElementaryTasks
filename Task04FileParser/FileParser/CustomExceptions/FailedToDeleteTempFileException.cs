// <copyright file="FailedToDeleteTempFileException.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    using System;

    /// <summary>
    /// Represents a class of custom exception occuring
    /// in case temporary file could not be removed.
    /// </summary>
    public class FailedToDeleteTempFileException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToDeleteTempFileException"/> class.
        /// </summary>
        public FailedToDeleteTempFileException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToDeleteTempFileException"/> class.
        /// </summary>
        /// <param name="path"> Path to file that could not be removed.</param>
        public FailedToDeleteTempFileException(string path)
            : base(string.Format("Failed to delete temporary file {0}", path))
        {
        }
    }
}
