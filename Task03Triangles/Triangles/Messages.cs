// <copyright file="Messages.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 3 - TRIANGLES
// </copyright>

namespace Triangles
{
    using System;

    /// <summary>
    /// Static class containing constants and static fields like
    /// queries and messages to be written on the console.
    /// </summary>
    public static class Messages
    {
        /// <summary> The message asking user to continue or stop the application </summary>
        public const string ASK_TO_CONTINUE_MESSAGE = "Would you like to continue and enter new Triangle data from keyboard? => yes or y";

        /// <summary> The message to be printed on stop of application </summary>
        public const string GOODBUY_MESSAGE = "Thank you for using our application...";

        /// <summary> Delimiter to be written on console to separate the stages of application </summary>
        public const string DELIMITER = "===============================================================";

        /// <summary> Description of application and user manual</summary>
        public static readonly string USER_MANUAL = string.Format(
              "============================================================================================{0}"
            + "This application adds triangles with parameters entered by user and prints it in sorted view.{0}"
            + "Sorting is descedning based on area of triangle calculated by Heron formula.{0}"
            + "On launch you have to provide 4 values - Name of triangle, and length of every side{0}"
            + "Sides can be floating point numbers, positive.{0}"
            + "Decimal separator is \'.\'{0}"
            + "============================================================================================",
            Environment.NewLine);

        /// <summary> The message prompting user enter data for next triangle </summary>
        public static readonly string ASK_TO_ENTER_ARGS = string.Format(
            "Please enter triangle data in the format:{0}"
          + "<name>,<side length>,<side length>,<side length>{0}"
          + "separated by comma=>",
            Environment.NewLine);
    }
}
