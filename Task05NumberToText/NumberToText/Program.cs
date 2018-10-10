// <copyright file="Program.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NumberToText
{
    /// <summary>
    /// Contains an entry point of application.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] localArgs = { "998001" };
            ConsoleNumberToWordsConverter converter = new ConsoleNumberToWordsConverter();
            converter.Run(localArgs);
        }
    }
}
