// <copyright file="ConfigEnvelopes.cs" company="Alex Brylov">
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
    /// Static class containing constants and static fields like
    /// queries and messages to be written on the console.
    /// </summary>
    public static class ConfigEnvelopes
    {
        /// <summary> Description of application and user manual</summary>
        public const string Manual = "This application determines whether one of two envelopes given can be placed into another.\n" +
                               "You will be asked for two consecutive float numbers " +
                               "for first and second envelope respectively.";

        /// <summary> Console message to be shown when user enters invalid data </summary>
        public const string ErrorMessage = "Wrong parameters entered";

        /// <summary> Result of comparison to be shown upon compltition </summary>
        public const string FirstCanBePlaced = "First envelope can be placed inside second one";

        /// <summary> Result of comparison to be shown upon compltition </summary>
        public const string SecondCanBePlaced = "Second envelope can be placed inside first one";

        /// <summary> Result of comparison to be shown upon compltition </summary>
        public const string NonCanBePlaced = "Neither envelope can be placed inside another";

        /// <summary> Delimiter to be written on console to separate the stages of application </summary>
        public const string Delimiter = "===============================================================";

        /// <summary> The message to be displayed when invalid data entered </summary>
        public const string WrongNumberMessage = "Wrong data. Number most be positive, the decimal separator is \'.\'";

        /// <summary> The message prompting user to continue or stop the application </summary>
        public const string AskToContinueMessage = "Would you like to continue? => yes or y";

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

        /// <summary> Gets queries prompting user to enter the value </summary>
        public static string[] AskUser { get; } =
        {
            "Enter width of Envelope 1",
            "Enter height of Envelope 1",
            "Enter width of Envelope 2",
            "Enter height of Envelope 2"
        };
    }
}
