// <copyright file="Program.cs" company="Alex Brylov">
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

    /// <summary>
    /// Class Program contains application entry point
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            EnvelopesLogger logger = new EnvelopesLogger();
            Action<string, float, string> userInputLogHandler = logger.Log;
            Action<Envelope, Envelope, string, bool> comparisonResultLogHandler = logger.Log;

            UserInterfaceConsole.Run(userInputLogHandler, comparisonResultLogHandler);
        }
    }
}
