// <copyright file="ConsoleUserInterface.cs" company="Oleksandr Brylov">
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
    public class ConsoleUserInterface
    {
        private IFileParser _fileParser;
        private Config.WorkMode _workMode;

        /// <summary>
        /// Interacts with user console entry, valudates the entered data, sets workMode and print result.
        /// </summary>
        /// <param name="args">Command line arguments </param>
        public void ReadUserInput(string[] args)
        {
            try
            {
                switch ((Config.NumberOfArgs)args.Length)
                {
                    case Config.NumberOfArgs.NoArgs:
                        Console.WriteLine(Config.USER_MANUAL);
                        break;
                    case Config.NumberOfArgs.TwoArgs:
                        this.CheckFilePath(args[0]);
                        this._workMode = Config.WorkMode.Find;
                        this._fileParser = new Seeker(args[0], args[1]);
                        break;
                    case Config.NumberOfArgs.ThreeArgs:
                        this.CheckFilePath(args[0]);
                        this._workMode = Config.WorkMode.Replace;
                        this._fileParser = new Replacer(args[0], args[1], args[2]);
                        break;
                    default:
                        Console.WriteLine(Config.USER_MANUAL);
                        break;
                }

                try
                {
                    this.ParseFileAndPrintResult();
                }
                catch (FailedToReplaceFileException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FailedToDeleteTempFileException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (FileToParseNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ParseFileAndPrintResult()
        {
            if (this._workMode != Config.WorkMode.NotSet)
            {
                int result = this._fileParser.ParseFile();
                Console.WriteLine($"File has been parsed in {this._workMode} mode");
                switch (this._workMode)
                {
                    case Config.WorkMode.Find:
                        Console.WriteLine($"{result} have been found");
                        break;
                    case Config.WorkMode.Replace:
                        Console.WriteLine($"{result} have been replaced");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong or no arguments have been submitted");
                Console.WriteLine(Config.USER_MANUAL);
            }
        }

        private void CheckFilePath(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileToParseNotFoundException(path);
            }
        }
    }
}
