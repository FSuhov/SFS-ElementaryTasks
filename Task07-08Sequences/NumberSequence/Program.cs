// <copyright file="Program.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 7 and 8, Pow sequence and Fibo sequence.
// </copyright>

namespace NumberSequence
{
    using NumberSequence.ConsoleClasses;

    /// <summary> Contains an entry point of application. </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] localArgs = { "45", "150"};
            SequenceConsole sequenceConsole = new SequenceConsole();
            sequenceConsole.ReadInputAndSetStatus(localArgs);
            sequenceConsole.PrintSequenceOrMessage();
        }
    }
}
