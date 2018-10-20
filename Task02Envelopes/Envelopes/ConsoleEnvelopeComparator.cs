// <copyright file="ConsoleEnvelopeComparator.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 2 - ENVELOPES.
// </copyright>

namespace Envelopes
{
    using System;

    /// <summary> Representation of the result of comparison </summary>
    public enum ComparisonResult
    {
        /// <summary> Representing the case when first envelope can be placed into another </summary>
        FirstToSecond = -1,

        /// <summary> Representing the case when non of envelope can be placed into the other </summary>
        Non,

        /// <summary> Representing the case when another envelope can be placed into this </summary>
        SecondToFirst
    }

    /// <summary>Represents an object for interaction with user. </summary>
    internal class ConsoleEnvelopeComparator
    {
        private Envelope _envelopeA;
        private Envelope _envelopeB;

        /// <summary>
        /// Implements the interaction with user via command line/console input/output.
        /// Reads command line arguments, validates it, prints result.
        /// Prompts user to continue.
        /// </summary>
        /// <param name="args"> Command line arguments provided at launch of application. </param>
        public void Run(string[] args)
        {
            if (args.Length == 4)
            {
                if (this.IsEnvelopesCreated(args))
                {
                    this.PrintResult();
                }
            }
            else
            {
                this.PrintResult();
            }

            if (this.IsWantToContinue())
            {
                this.RepeatEntry();
            }

            Console.WriteLine(ConfigEnvelopes.GOODBUY_MESSAGE);
        }

        private bool IsWantToContinue()
        {
            Console.WriteLine(ConfigEnvelopes.ASK_TO_CONTINUE_MESSAGE);
            string userInput = Console.ReadLine().ToLower();
            return userInput.Equals("yes") || userInput.Equals("y");
        }

        private void PrintResult()
        {
            if (this._envelopeA != null && this._envelopeB != null)
            {
                ComparisonResult result = (ComparisonResult)this._envelopeA.CompareTo(this._envelopeB);
                Console.WriteLine(
                    "Comparing envelopes:\n Envelope 1: {0}{2} Envelope 2: {1}{2}",
                     this._envelopeA.ToString(),
                     this._envelopeB.ToString(),
                     Environment.NewLine);
                switch (result)
                {
                    case ComparisonResult.FirstToSecond:
                        Console.WriteLine(ConfigEnvelopes.FIRST_CAN_BE_PLACED);
                        break;
                    case ComparisonResult.SecondToFirst:
                        Console.WriteLine(ConfigEnvelopes.SECOND_CAN_BE_PLACED);
                        break;
                    case ComparisonResult.Non:
                        Console.WriteLine(ConfigEnvelopes.NON_CAN_BE_PLACED);
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine(ConfigEnvelopes.DELIMITER);
            }
            else
            {
                Console.WriteLine(ConfigEnvelopes.WRONG_VALUE_MESSAGE);
                Console.WriteLine(ConfigEnvelopes.USER_MANUAL);
            }
        }

        private bool IsEnvelopesCreated(string[] args)
        {
            float a, b, c, d;
            if (float.TryParse(args[0], out a) && float.TryParse(args[1], out b)
                && float.TryParse(args[2], out c) && float.TryParse(args[3], out d))
            {
                this._envelopeA = new Envelope(a, b);
                this._envelopeB = new Envelope(c, d);
                return true;
            }

            return false;
        }

        private void RepeatEntry()
        {
            Console.WriteLine(ConfigEnvelopes.DELIMITER);
            int i = 0;
            float a = this.ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i++]);
            float b = this.ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i++]);
            float c = this.ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i++]);
            float d = this.ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i]);
            this.Run(new string[4] { a.ToString(), b.ToString(), c.ToString(), d.ToString() });
        }

        private float ReadEnvelopeSideLength(string askUser)
        {
            float length = -1;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine(askUser);
                string userInput = Console.ReadLine();
                if (float.TryParse(userInput, out length) && length > 0)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine(ConfigEnvelopes.WRONG_VALUE_MESSAGE);
                }
            }

            return length;
        }
    }
}
