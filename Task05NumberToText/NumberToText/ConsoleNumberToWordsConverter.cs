// <copyright file="ConsoleNumberToWordsConverter.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText
{
    using System;
    using NumberToText.Classes;

    /// <summary>
    /// Contains the representation of current localization.
    /// </summary>
    public enum Local
    {
        /// <summary> English </summary>
        EN,

        /// <summary> Russian </summary>
        RU,

        /// <summary> Ukrainian </summary>
        UA
    }

    /// <summary> A validation result of arguments submitted by user. </summary>
    public enum InputStatus
    {
        /// <summary> No arguments submitted. </summary>
        NoArgs,

        /// <summary> Invalid arguments submitted. </summary>
        InvalidArgs,

        /// <summary> Valid arguments submitted. </summary>
        ValidArgs
    }

    /// <summary>
    /// Responsible for interaction with user via console input/output
    /// </summary>
    public class ConsoleNumberToWordsConverter
    {
        private long _number;
        private string _words;
        private ConverterEurope _converter;
        private InputStatus _statuse;
        private Local _local;

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
                case InputStatus.ValidArgs:
                    this._converter = this.GetConverter();
                    this._words = this._converter.ConvertToWords(this._number);
                    this.PrintResult();
                    this.RepeatEntry();
                    break;
                default:
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
                if (long.TryParse(args[0], out this._number) && this._number <= ResourcesEN.MAX)
                {
                    status = InputStatus.ValidArgs;
                    if (args.Length > 1)
                    {
                        this._local = this.GetLocale(args[1]);
                    }
                    else
                    {
                        this._local = this.GetLocale();
                    }
                }
                else
                {
                    status = InputStatus.InvalidArgs;
                }
            }

            return status;
        }

        private Local GetLocale(string input = "en")
        {
            Local local;
            string locale = input.ToLower();
            switch (input)
            {
                case "en":
                    local = Local.EN;
                    break;
                case "ru":
                    local = Local.RU;
                    break;
                case "ua":
                    local = Local.UA;
                    break;
                default:
                    local = Local.EN;
                    break;
            }

            return local;
        }

        private ConverterEurope GetConverter()
        {
            ConverterEurope converter = null;
            switch (this._local)
            {
                case Local.RU:
                    converter = new ConverterRU();
                    break;
                case Local.UA:
                    converter = new ConverterUA();
                    break;
                default:
                    converter = new ConverterEN();
                    break;
            }

            return converter;
        }

        private void PrintResult()
        {
            Console.WriteLine(this._number);
            Console.WriteLine(this._words);
        }

        private void RepeatEntry()
        {
            Console.WriteLine("Would you like to enter another number manually=> (y) or exit=> (any other key)?");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine("Please enter an Integer number followed by enter key");
                string userInput = Console.ReadLine();
                string[] args = userInput.Split(' ');
                this.Run(args);
            }
        }
    }
}
