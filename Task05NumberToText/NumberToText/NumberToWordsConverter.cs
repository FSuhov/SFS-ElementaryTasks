// <copyright file="NumberToWordsConverter.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace NumberToText
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implements logic of the application:
    /// contains static data arrays and method of convertion of number to text.
    /// </summary>
    public static class NumberToWordsConverter
    {
        private static readonly string[] UNITS =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourtheen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static readonly string[] TENS = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        private static readonly Dictionary<int, string> LARGE_NUMBERS = new Dictionary<int, string>()
        {
            { 100, " hundred " },
            { 1000, " thousand " },
            { 1000000, " million " },
            { 1000000000, " billion " }
        };

        /// <summary>
        /// Converts numeric representation of integer number into next representation.
        /// </summary>
        /// <param name="number"> Integer to be converted. </param>
        /// <returns> Text representation of number. </returns>
        public static string ConvertToWords(int number)
        {
            if (number == 0)
            {
                return UNITS[number];
            }

            if (number < 0)
            {
                return ConvertToWords(Math.Abs(number));
            }

            StringBuilder result = new StringBuilder();

            if (number / 1_000_000_000 > 0)
            {
                result.Append(ConvertToWords(number / 1_000_000_000));
                result.Append(LARGE_NUMBERS[1_000_000_000]);
                number %= 1_000_000_000;
            }

            if (number / 1_000_000 > 0)
            {
                result.Append(ConvertToWords(number / 1_000_000));
                result.Append(LARGE_NUMBERS[1_000_000]);
                number %= 1_000_000;
            }

            if (number / 1_000 > 0)
            {
                result.Append(ConvertToWords(number / 1_000));
                result.Append(LARGE_NUMBERS[1_000]);
                number %= 1_000;
            }

            if (number / 100 > 0)
            {
                result.Append(ConvertToWords(number / 100));
                result.Append(LARGE_NUMBERS[100]);
                number %= 100;
            }

            if (number > 0)
            {
                if (result.ToString() != string.Empty)
                {
                    result.Append("and ");
                }

                if (number < 20)
                {
                    result.Append(UNITS[number]);
                }
                else
                {
                    result.Append(TENS[number / 10]);
                    if ((number % 10) > 0)
                    {
                        result.Append(" " + UNITS[number % 10]);
                    }
                }
            }

            return result.ToString();
        }
    }
}
