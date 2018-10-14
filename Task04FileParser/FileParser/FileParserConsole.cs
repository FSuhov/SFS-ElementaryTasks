// <copyright file="FileParserConsole.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    using System;
    using System.IO;

    /// <summary>
    /// Implements the spesific logic for console input/output.
    /// Validates and determines entered arguments
    /// </summary>
    public class FileParserConsole : FileParser, IUserInputOutput
    {
        private Config.WorkMode workMode = Config.WorkMode.NotSet;

        /// <summary>
        /// Interacts with user console entry, valudates the entered data, sets workMode.
        /// </summary>
        /// <param name="args">Command line arguments </param>
        public void ReadUserInput(string[] args)
        {
            int argsNumber = args.Length;
            switch ((Config.WorkMode)argsNumber)
            {
                case Config.WorkMode.NotSet:
                    Console.WriteLine(Config.USER_MANUAL);
                    break;
                case Config.WorkMode.Find:
                    this.workMode = Config.WorkMode.Find;
                    this.FilePath = args[0];
                    this.StringToFind = args[1];
                    break;
                case Config.WorkMode.Replace:
                    this.workMode = Config.WorkMode.Replace;
                    this.FilePath = args[0];
                    this.StringToFind = args[1];
                    this.StringReplacement = args[2];
                    break;
                default:
                    Console.WriteLine(Config.USER_MANUAL);
                    break;
            }

            if (!File.Exists(this.FilePath))
            {
                this.workMode = Config.WorkMode.NotSet;
                Console.WriteLine("Invalid path, file not found");
            }
        }

        /// <summary>
        /// Implements the specific console logic of file parsing depending on workMode set.
        /// </summary>
        public void ParseFile()
        {
            int entryCount = 0;
            if (this.workMode == Config.WorkMode.Find)
            {
                entryCount = this.FindEntries();
            }
            else if (this.workMode == Config.WorkMode.Replace)
            {
                entryCount = this.ReplaceEntries();
            }

            this.ShowResult(entryCount);
        }

        /// <summary>
        /// Implements visualisation of parsing results for console output
        /// </summary>
        /// <param name="entryCount"> Result of file parsing </param>
        public void ShowResult(int entryCount)
        {
            if (this.workMode == Config.WorkMode.Find)
            {
                Console.WriteLine($"Search completed, {entryCount} entries found");
            }
            else if (this.workMode == Config.WorkMode.Replace)
            {
                Console.WriteLine($"Replacement completed, {entryCount} entries replaced");
            }
            else
            {
                Console.WriteLine("Workmode not set");
            }
        }
    }
}
