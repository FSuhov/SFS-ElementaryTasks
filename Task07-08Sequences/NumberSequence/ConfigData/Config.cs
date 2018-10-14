// <copyright file="Config.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 7 and 8, Pow sequence and Fibo sequence.
// </copyright>

namespace NumberSequence.ConfigData
{
    using System;

    /// <summary>
    /// Contains static and constant fields for console output and
    /// enums for indicating work status.
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Contains result of evaluation of number of command line arguments provided by user
        /// </summary>
        public enum Args
        {
            /// <summary> No command line arguments provided upon launch. </summary>
            NoArgs,

            /// <summary> One command line argument provided. </summary>
            OneArg,

            /// <summary> Two command line argument provided. </summary>
            TwoArgs
        }

        /// <summary>
        /// Contains result of arguments validation and work mode if argsa are valid
        /// </summary>
        public enum AppStatus
        {
            /// <summary> No valid arguments. </summary>
            InvalidArgs,

            /// <summary> Application works in Pow mode (Task 7). </summary>
            PowerSequence,

            /// <summary> Application works in Fibo mode (Task 8)</summary>
            FiboSequence
        }

        /// <summary> User manual to be printed on console. </summary>
        public static readonly string USER_MANUAL = string.Format(
                          "========================================================================================={0}" +  
                          "This application designed to generate the number sequence depending on algorythms choosen.{0}" +
                          "It starts with command prompt.{0}" +
                          "If one command line argument provided, the generated sequence contains natural numbers{0}" +
                          "whose pow 2 is smaller than limit, i.e. argument.{0}" +
                          "If two arguments provided, the sequence contains Fibonacci numbers withing the range.{0}" +
                          "The arguments must be positive integer values{0}" +
                          "If Fibonacci algorythm choosen, the second number must be bigger than first (i.e. limit more than start).{0}" +
                          "========================================================================================={0}",
                          Environment.NewLine);

        /// <summary> Message to be printed when invalid argumetns provided. </summary>
        public static readonly string MESSAGE_INVALID_ARGS = "No or Invalid arguments. Please check arguments you entered.";
    }
}
