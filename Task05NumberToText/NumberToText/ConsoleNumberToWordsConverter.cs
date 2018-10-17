// <copyright file="ConsoleNumberToWordsConverter.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>
namespace NumberToText
{
    using System;

    /// <summary>
    /// Responsible for interaction with user via console input/output
    /// </summary>
    public class ConsoleNumberToWordsConverter
    {
        private long number;
        private string words;
        private NumberToWordsConverter _converter;

        private enum InputStatus
        {
            NoArgs,
            InvalidArgs,
            ValidArgs
        }

        /// <summary>
        /// Gets and validates arguments passed from command line.
        /// Provides user with feedback in case of wrong arguments.
        /// Prompt user to enter the number manually from keyboard,
        /// Prints result on the console upon correct arguments been submitted.
        /// </summary>
        /// <param name="args">Command line arguments. </param>
        public void Run(string[] args)
        {
            InputStatus status = this.ValidateUserInput(args);
            switch (status)
            {
                case InputStatus.NoArgs:
                    Console.WriteLine(ResourcesEN.USER_MANUAL);
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("The command line argument has not been submitted");
                    this.RepeatEntry();
                    break;
                case InputStatus.InvalidArgs:
                    Console.WriteLine(ResourcesEN.USER_MANUAL);
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("Invalid command line argument has been submitted");
                    this.RepeatEntry();
                    break;
                default:
                    this.words = this._converter.ConvertToWords(this.number);
                    this.PrintResult();
                    this.RepeatEntry();
                    break;
            }
        }

        private InputStatus ValidateUserInput(string[] args)
        {
            InputStatus status;
            if (args.Length == 0)
            {
                status = InputStatus.NoArgs;
            }
            else
            {
                if (long.TryParse(args[0], out this.number) && this.number <= ResourcesEN.MAX)
                {
                    status = InputStatus.ValidArgs;
                    if (args.Length > 1)
                    {
                        this._converter = new NumberToWordsConverter(args[1]);
                    }
                    else
                    {
                        this._converter = new NumberToWordsConverter();
                    }
                }
                else
                {
                    status = InputStatus.InvalidArgs;
                }
            }

            return status;
        }

        private void PrintResult()
        {
            Console.WriteLine(this.number);
            Console.WriteLine(this.words);
        }

        private void RepeatEntry()
        {
            Console.WriteLine("Would you like to enter another number manually=> (y) or exit=> (any other key)?");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Please enter an Integer number followed by enter key");
                string userInput = Console.ReadLine();
                string[] args = userInput.Split(' ');
                this.Run(args);
            }
        }
    }
}
