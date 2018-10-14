// <copyright file="SequenceConsole.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 7 and 8, Pow sequence and Fibo sequence.
// </copyright>

namespace NumberSequence.ConsoleClasses
{
    using System;
    using System.Linq;
    using NumberSequence.BusineessLogicClasses;
    using NumberSequence.ConfigData;
    using NumberSequence.Inetrfaces;

    /// <summary>
    /// Represents an object that interacts with user via console input/output.
    /// </summary>
    public class SequenceConsole
    {
        private ISequence _sequence;
        private Config.AppStatus _status;

        /// <summary>
        /// Sets the work mode of application depanding on command line arguments provided.
        /// </summary>
        /// <param name="args"> Command line arguments to be entered on application launch. </param>
        public void ReadInputAndSetStatus(string[] args)
        {
            switch ((Config.Args)args.Length)
            {
                case Config.Args.NoArgs:
                    this._status = Config.AppStatus.InvalidArgs;
                    break;
                case Config.Args.OneArg:
                    this._status = this.ValidateAndGetStatus(args[0]);
                    break;
                case Config.Args.TwoArgs:
                    this._status = this.ValidateAndGetStatus(args[0], args[1]);
                    break;
                default:
                    this._status = Config.AppStatus.InvalidArgs;
                    break;
            }
        }

        /// <summary>
        /// Prints either error message to user or numbers sequence.
        /// </summary>
        public void PrintSequenceOrMessage()
        {
            if(this._status == Config.AppStatus.InvalidArgs)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Config.MESSAGE_INVALID_ARGS);
                Console.ResetColor();
                Console.WriteLine(Config.USER_MANUAL);
            }
            else
            {
                int[] result = this._sequence.GetSequence().ToArray();
                Console.WriteLine(this._sequence.ToString());

                this.PrintSequence(result);
            }

            Console.ReadKey();
        }

        /// <summary> Gets current status of application. </summary>
        /// <returns> Current status. </returns>
        public Config.AppStatus GetStatus()
        {
            return this._status;
        }

        private void PrintSequence(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        private Config.AppStatus ValidateAndGetStatus(string firstArgument)
        {
            Config.AppStatus appStatus;
            int limit;
            if (int.TryParse(firstArgument, out limit) && this.IsValidArgument(limit))
            {
                appStatus = Config.AppStatus.PowerSequence;
                this._sequence = new PowSequence(limit);
            }
            else
            {
                appStatus = Config.AppStatus.InvalidArgs;
            }

            return appStatus;
        }

        private Config.AppStatus ValidateAndGetStatus(string firstArgument, string secondArgument)
        {
            Config.AppStatus appStatus;
            int start;
            int limit;
            if (int.TryParse(firstArgument, out start)
                && int.TryParse(secondArgument, out limit)
                && this.IsValidArgument(start, limit))
            {
                appStatus = Config.AppStatus.FiboSequence;
                this._sequence = new FiboSequence(start, limit);
            }
            else
            {
                appStatus = Config.AppStatus.InvalidArgs;
            }

            return appStatus;
        }

        private bool IsValidArgument(int limit)
        {
            return limit > 0;
        }

        private bool IsValidArgument(int start, int limit)
        {
            return start >= 0 && limit > start;
        }
    }
}
