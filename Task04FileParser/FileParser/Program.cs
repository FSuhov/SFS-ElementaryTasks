// <copyright file="Program.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FileParser
{
    /// <summary> Contains an entry point of application. </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] localArgs = { "input.txt", "REPLACED", "is" };
            FileParserConsole fileParcer = new FileParserConsole();
            fileParcer.ReadUserInput(localArgs);
            fileParcer.ParseFile();
        }
    }
}
