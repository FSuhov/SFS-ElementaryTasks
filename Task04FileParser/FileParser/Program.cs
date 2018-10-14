// <copyright file="Program.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    /// <summary> Contains an entry point of application. </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] localArgs = { "input.txt", "REPLACED", "is", "tr" };
            FileParserConsole fileParcer = new FileParserConsole();
            fileParcer.ReadUserInput(localArgs);
            fileParcer.ParseFile();
        }
    }
}
