// <copyright file="Program.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 3 - TRIANGLES
// </copyright>

namespace Triangles
{
    /// <summary> Contains an entry point of the application </summary>
    internal class Program
    {
        /// <summary> An entry point of application </summary>
        /// <param name="args"> Optional arguments to be passed </param>
        private static void Main(string[] args)
        {
            string[] localArgs = { "First", "23", "17.5", "12" };
            ShapeConsoleTester shapeConsole = new ShapeConsoleTester();
            shapeConsole.Run(localArgs);
        }
    }
}
