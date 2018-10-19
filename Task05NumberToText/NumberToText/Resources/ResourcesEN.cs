// <copyright file="ResourcesEN.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains text and Dictionary resources required for NumberToWordsConverter and console output
    /// </summary>
    public static class ResourcesEN
    {
        /// <summary> Maximum limit of number this application can convert </summary>
        public const long MAX = 9_999_999_999_999_999;

        /// <summary> Minimum limit of number this application can convert </summary>
        public const long MIN = -9_999_999_999_999_999;

        /// <summary> User manual text to be printed on the console if wrong arguments. </summary>
        public static readonly string USER_MANUAL = string.Format(
                         "========================================================================================={0}" +
                         "This application converts numeric input into text output.{0}" +
                         "It is limited to integer numbers, so the range varies from –2,147,483,648 to 2,147,483,647,{0}" +
                         "but can easily be extended to larger numbers.{0}" +
                         "You may launch it from command line by entering the number after the .exe file name:{0}" +
                         "print: NumberToText.exe followed by space and the number to convert.{0}" +
                         "You may also enter second optional argument for localized version: 0 - for English (default) or 1 - for Russian.{0}" +
                         "========================================================================================={0}",
                         Environment.NewLine);

        /// <summary> A word to be added if negative number submitted. </summary>
        public static readonly string MINUS = "minus";

        /// <summary> Keys and values for large numbers. </summary>
        public static readonly Dictionary<long, string> TEXT_LARGE_NUMBERS = new Dictionary<long, string>()
        {
            { 1000000000000000, "quadrillion" },
            { 1000000000000, "trillion" },
            { 1000000000, "billion" },
            { 1000000, "million" },
            { 1000, "thousand" },
        };

        /// <summary> Keys and values for units and tens. </summary>
        public static readonly Dictionary<long, string> TEXT_NUMBERS = new Dictionary<long, string>()
        {
            { 0, "zero" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18, "eighteen" },
            { 19, "nineteen" },
            { 20, "twenty" },
            { 30, "thirty" },
            { 40, "forty" },
            { 50, "fifty" },
            { 60, "sixty" },
            { 70, "seventy" },
            { 80, "eighty" },
            { 90, "ninety" },
            { 100, "hundred" },
        };
    }
}
