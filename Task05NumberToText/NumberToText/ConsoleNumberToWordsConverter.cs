// <copyright file="ConsoleNumberToWordsConverter.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace NumberToText
{
    using System;

    /// <summary>
    /// Responsible for interaction with user via console input/output
    /// </summary>
    public class ConsoleNumberToWordsConverter
    {
        private const string USER_MANUAL = "This application converts numeric input into text output.\n" +
                                          "It is limited to integer numbers, so the range varies from –2,147,483,648 to 2,147,483,647\n" +
                                          "You may launch it from command line by entering the number after the .exe file name:\n" +
                                          "on Windows 10:\n" +
                                          "1. look up for cmd and launch it\n" +
                                          "2. navigate to directory with .exe file: cd d:\\REPOS\\Elementarytasks\\Task04NumberToText\\NumberToText\\bin\\debug" +
                                          "3. print: NumberToText.exe followed by space and the number to convert";

        private int number;
        private string words;

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
                    Console.WriteLine(USER_MANUAL);
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("The command line argument has not been submitted");
                    this.RepeatEntry();
                    break;
                case InputStatus.InvalidArgs:
                    Console.WriteLine(USER_MANUAL);
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("Invalid command line argument has been submitted");
                    this.RepeatEntry();
                    break;
                default:
                    this.words = NumberToWordsConverter.ConvertToWords(this.number);
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
                if (int.TryParse(args[0], out this.number))
                {
                    status = InputStatus.ValidArgs;
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
            Console.WriteLine(this.words);
        }

        private void RepeatEntry()
        {
            Console.WriteLine("Would you like to enter another number manually=> (y) or exit=> (any other key)?");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Please enter an Integer number followed by enter key");
                string userInput = Console.ReadLine();
                this.Run(new string[] { userInput });
            }
        }
    }
}
