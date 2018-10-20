// <copyright file="ConfigEnvelopes.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 2 - ENVELOPES.
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
        /// <summary> Result of comparison to be shown upon compltition </summary>
        public const string FIRST_CAN_BE_PLACED = "First envelope can be placed inside second one";

        /// <summary> Result of comparison to be shown upon compltition </summary>
        public const string SECOND_CAN_BE_PLACED = "Second envelope can be placed inside first one";

        /// <summary> Result of comparison to be shown upon compltition </summary>
        public const string NON_CAN_BE_PLACED = "Neither envelope can be placed inside another";

        /// <summary> Description of application and user manual</summary>
        public static readonly string USER_MANUAL = string.Format(
              "This application determines whether one of two envelopes given can be placed into another.{0}"
            + "On launch you have to provide 4 numeric values - sides of envelopes.{0}"
            + "Alternatively you may enter it manually via console."
            + "Numbers must be positive, the decimal separator is \'.\'",
            Environment.NewLine);

        /// <summary> Delimiter to be written on console to separate the stages of application </summary>
        public static readonly string DELIMITER = "===============================================================";

        /// <summary> The message to be displayed when invalid data entered </summary>
        public static readonly string WRONG_VALUE_MESSAGE = "Wrong data. Number most be positive, the decimal separator is \'.\'";

        /// <summary> The message prompting user to continue or stop the application </summary>
        public static readonly string ASK_TO_CONTINUE_MESSAGE = "Would you like to continue? => yes or y";

        /// <summary> The message to be printed on stop of application </summary>
        public static readonly string GOODBUY_MESSAGE = "Thank you for using our application...";

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
