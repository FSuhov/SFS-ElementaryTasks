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
            string[] localArgs = { "input.txt", "is", "REPLACED" };
            ConsoleUserInterface userInterface = new ConsoleUserInterface();
            userInterface.ReadUserInput(localArgs);
        }
    }
}
