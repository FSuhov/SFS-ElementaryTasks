// <copyright file="ConsoleLuckyTicketCounter.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    using System;
    using System.IO;

    /// <summary> Represents a class for interaction with user via console. </summary>
    internal class ConsoleLuckyTicketCounter
    {
        private LuckyTicketCounter _ticketCounter;

        private LuckyTicketsConfig.Status _status;

        /// <summary>
        /// Sets the status of application depending on arguments received.
        /// </summary>
        /// <param name="args"> Command line arguments submitted by user. </param>
        public void SetStatus(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    this._status = LuckyTicketsConfig.Status.NoArgs;
                    break;
                case 1:
                    this._status = this.InitLuckyTicket(args[0]);
                    break;
                case 2:
                    this._status = this.InitLuckyTicket(args[0], args[1]);
                    break;
                default:
                    this._status = LuckyTicketsConfig.Status.InvalidArgs;
                    break;
            }
        }

        /// <summary>
        /// Visualizes the results of application run via console output.
        /// </summary>
        public void ShowResult()
        {
            if (this._status == LuckyTicketsConfig.Status.Success)
            {
                int result = 0;
                try
                {
                    result = this._ticketCounter.CountNumberOfLuckyTickets();
                    Console.WriteLine("There are {0} lucky tickets possible using {1} ", result, this._ticketCounter.ToString());
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("There was an error accessing one of tickets.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                switch (this._status)
                {
                    case LuckyTicketsConfig.Status.NoArgs:
                        Console.WriteLine("No command line arguments provided");
                        Console.ResetColor();
                        Console.WriteLine(LuckyTicketsConfig.ERROR_ADVISE_NO_ARGS);
                        Console.WriteLine(LuckyTicketsConfig.USER_MANUAL);
                        break;
                    case LuckyTicketsConfig.Status.InvalidPath:
                        Console.Error.WriteLine("Unable to locate file");
                        Console.ResetColor();
                        Console.WriteLine(LuckyTicketsConfig.ERROR_ADVISE_INVALID_PATH);
                        break;
                    case LuckyTicketsConfig.Status.InvalidFileContent:
                        Console.Error.WriteLine("Unable to idetnify the algorythm (wrong data in the file)");
                        Console.ResetColor();
                        Console.WriteLine(LuckyTicketsConfig.ERROR_ADVISE_INVALID_CONTENT);
                        break;
                    case LuckyTicketsConfig.Status.InvalidArgs:
                        Console.Error.WriteLine("Wrong second command line argument");
                        Console.ResetColor();
                        Console.WriteLine(LuckyTicketsConfig.ERROR_ADVISE_INVALID_ARGS);
                        break;
                    default:
                        break;
                }
            }
        }

        private string ReadFile(string path)
        {
            string result;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    result = reader.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                result = "File not found";
            }

            return result;
        }

        private LuckyTicketsConfig.Status InitLuckyTicket(string path)
        {
            string mode = this.ReadFile(path);

            LuckyTicketsConfig.Status status;

            switch (mode)
            {
                case "Moscow":
                    this._ticketCounter = new LuckyTicketCounter(new LuckyTicketMoscow());
                    status = LuckyTicketsConfig.Status.Success;
                    break;
                case "Piter":
                    this._ticketCounter = new LuckyTicketCounter(new LuckyTicketPeter());
                    status = LuckyTicketsConfig.Status.Success;
                    break;
                case "File not found":
                    status = LuckyTicketsConfig.Status.InvalidPath;
                    break;
                default:
                    status = LuckyTicketsConfig.Status.InvalidFileContent;
                    break;
            }

            return status;
        }

        private LuckyTicketsConfig.Status InitLuckyTicket(string path, string digits)
        {
            string mode = this.ReadFile(path);

            LuckyTicketsConfig.Status status;

            int parsedDigits = 0;
            if (int.TryParse(digits, out parsedDigits) && this.IsValidNumberOfDigits(parsedDigits))
            {
                switch (mode)
                {
                    case "Moscow":
                        this._ticketCounter = new LuckyTicketCounter(new LuckyTicketMoscow(), parsedDigits);
                        status = LuckyTicketsConfig.Status.Success;
                        break;
                    case "Piter":
                        this._ticketCounter = new LuckyTicketCounter(new LuckyTicketPeter(), parsedDigits);
                        status = LuckyTicketsConfig.Status.Success;
                        break;
                    case "File not found":
                        status = LuckyTicketsConfig.Status.InvalidPath;
                        break;
                    default:
                        status = LuckyTicketsConfig.Status.InvalidFileContent;
                        break;
                }
            }
            else
            {
                status = LuckyTicketsConfig.Status.InvalidArgs;
            }

            return status;
        }

        private bool IsValidNumberOfDigits(int number)
        {
            return number % 2 == 0 && number > 0 && number < 19;
        }
    }
}
