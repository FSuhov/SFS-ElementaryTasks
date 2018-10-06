// <copyright file="EnvelopesLogger.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Envelopes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary> Class containing methods for logging of the application.</summary>
    public class EnvelopesLogger
    {
        private string pathToLogFile;

        /// <summary> Initializes a new instance of the <see cref="EnvelopesLogger"/> class. </summary>
        public EnvelopesLogger()
        {
            this.pathToLogFile = Path.GetRandomFileName() + ".txt";
        }

        /// <summary> Overloaded method recording a log entry about user input </summary>
        /// <param name="userInput">
        ///  String entered by user, to be passed inside
        ///  UserInterfaceConsole.ReadEnvelopeSideLength method </param>
        /// <param name="currentLength">
        /// Current value of side length in UserInterfaceConsole.ReadEnvelopeSideLength method.
        /// </param>
        /// <param name="message"> Message to be written in logging file</param>
        public void Log(string userInput, float currentLength, string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(this.pathToLogFile, true))
            {
                string msg = string.Format(
                                            "{0}||User entered [{1}] || Current sideLength [{2}] || Message [{3}]",
                                            DateTime.Now,
                                            userInput,
                                            currentLength,
                                            message);
                streamWriter.WriteLine(msg);
                streamWriter.Close();
            }
        }

        /// <summary> Overloaded method recording a log entry about result of comparison </summary>
        /// <param name="envelope1"> First instance of envelope </param>
        /// <param name="envelope2"> Second instance of envelope </param>
        /// <param name="result"> Message containing result of comparison</param>
        /// <param name="isContinue"> Whether user wants to continue or exit </param>
        public void Log(Envelope envelope1, Envelope envelope2, string result, bool isContinue)
        {
            using (StreamWriter streamWriter = new StreamWriter(this.pathToLogFile, true))
            {
                string msg = string.Format(
                                            "{0}||Envelop 1: [{1}] || Envelope 2: [{2}] || Message [{3}] || Continue? [{4}]",
                                            DateTime.Now,
                                            envelope1.ToString(),
                                            envelope2.ToString(),
                                            result,
                                            isContinue);
                streamWriter.WriteLine(msg);
                streamWriter.Close();
            }
        }
    }
}
