// <copyright file="UserInterfaceConsole.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Envelopes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary> Static class contains methods for interaction with user. </summary>
    public static class UserInterfaceConsole
    {
        /// <summary> Implements user interaction logic </summary>
        /// <param name="userInputLogHandler">
        ///  Delegate pointing to method Log of EnvelopesLogger class.
        ///  Designed to write a log entries about user input results.
        ///  </param>
        /// <param name="comparisonResultLogHandler">
        /// Delegate pointing to method Log of EnvelopesLogger class.
        /// Designed to write a log entries about comparison result.
        /// </param>
        public static void Run(
                               Action<string, float, string> userInputLogHandler,
                               Action<Envelope, Envelope, string, bool> comparisonResultLogHandler)
        {
            Console.WriteLine(ConfigEnvelopes.Manual);
            while (true)
            {
                Console.WriteLine(ConfigEnvelopes.Delimiter);
                int i = 0;
                float a = ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i++], userInputLogHandler);
                float b = ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i++], userInputLogHandler);
                float c = ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i++], userInputLogHandler);
                float d = ReadEnvelopeSideLength(ConfigEnvelopes.AskUser[i], userInputLogHandler);
                Envelope envelope1 = new Envelope(a, b);
                Envelope envelope2 = new Envelope(c, d);
                int result = envelope1.CompareTo(envelope2);
                Console.WriteLine(
                    "Comparing envelopes:\n Envelope 1: {0}\n Envelope 2: {1}\n",
                     envelope1.ToString(),
                     envelope2.ToString());

                switch ((ConfigEnvelopes.ComparisonResult)result)
                {
                    case ConfigEnvelopes.ComparisonResult.FirstToSecond:
                        Console.WriteLine(ConfigEnvelopes.FirstCanBePlaced);
                        break;
                    case ConfigEnvelopes.ComparisonResult.SecondToFirst:
                        Console.WriteLine(ConfigEnvelopes.SecondCanBePlaced);
                        break;
                    case ConfigEnvelopes.ComparisonResult.Non:
                        Console.WriteLine(ConfigEnvelopes.NonCanBePlaced);
                        break;
                    default:
                        break;
                }

                Console.WriteLine(ConfigEnvelopes.AskToContinueMessage);
                string userInput = Console.ReadLine().ToLower();
                if (!userInput.Equals("yes") && !userInput.Equals("y"))
                {
                    Console.WriteLine("Thank you for using our application...");
                    comparisonResultLogHandler(
                                                envelope1,
                                                envelope2,
                                                ((ConfigEnvelopes.ComparisonResult)result).ToString(),
                                                false);
                    break;
                }

                comparisonResultLogHandler(
                                            envelope1,
                                            envelope2,
                                            ((ConfigEnvelopes.ComparisonResult)result).ToString(),
                                            true);
            }
        }

        /// <summary> A helper method for looping user input until correct data received. </summary>
        /// <param name="queryUser"> A query to be displayed on the console </param>
        /// <param name="logHandler">
        ///  Delegate pointing to method Log of EnvelopesLogger class.
        ///  Designed to write a log entries about user input results.
        ///  </param>
        /// <returns> Side of envelope </returns>
        public static float ReadEnvelopeSideLength(string queryUser, Action<string, float, string> logHandler)
        {
            float length = -1;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine(queryUser);
                string userInput = Console.ReadLine();
                if (float.TryParse(userInput, out length) && length > 0)
                {
                    isValidInput = true;
                    logHandler(userInput, length, "success");
                }
                else
                {
                    Console.WriteLine(ConfigEnvelopes.WrongNumberMessage);
                    logHandler(userInput, length, "error");
                }
            }

            return length;
        }
    }
}
