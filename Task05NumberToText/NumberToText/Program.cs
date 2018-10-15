// <copyright file="Program.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
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
            string[] localArgs = { "1150909", "ru" };
            ConsoleNumberToWordsConverter converter = new ConsoleNumberToWordsConverter();
            converter.Run(localArgs);
        }
    }
}
