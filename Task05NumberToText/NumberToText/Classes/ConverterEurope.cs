// <copyright file="ConverterEurope.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NumberToText.Interfaces;

    /// <summary>
    /// Abstract class containing fields and methods for converting
    /// value to words.
    /// Implements the logic suitable for most (I hope) european languages:
    /// left-to-right text direction, from large-to-small logic, and tens and larger digit numbers creation style
    /// (a kind of combination of tens and units).
    /// Does not have language resources, therefore can not be instanciated.
    /// </summary>
    public abstract class ConverterEurope : INumberToWordsConverter
    {
        /// <summary> Gets or sets dictionary containing numeric keys and corresponding verbal values less than 100 (i.e. 5, "five"). </summary>
        protected Dictionary<long, string> SmallNumbersText { get; set; }

        /// <summary> Gets or sets Dictionary containing numeric keys and corresponding verbal values larger than 100 (i.e. 1000, "thousand"). </summary>
        protected Dictionary<long, string> LargeNumbersText { get; set; }

        /// <summary> Gets or sets the result of work - verbal representation of value. </summary>
        protected StringBuilder Result { get; set; }

        /// <summary> Gets or sets a verbal representation of minus sign. </summary>
        protected string Negative { get; set; }

        /// <summary>
        /// Converts numeric representation of number into next representation.
        /// </summary>
        /// <param name="num"> Number to be converted. </param>
        /// <returns> Text representation of number. </returns>
        public string ConvertToWords(long num)
        {
            this.Result = new StringBuilder();

            if (num == 0)
            {
                this.Result.Append(this.SmallNumbersText[num]);
                return this.Result.ToString();
            }

            if (num < 0)
            {
                this.Result.AppendFormat("{0} ", this.Negative);
                num = Math.Abs(num);
            }

            num = this.LargeNumbersText.Aggregate(num, (current, scale) => this.Append(current, scale.Key));
            this.AppendLessThanOneThousand(num);

            return this.Result.ToString().Trim();
        }

        /// <summary>
        /// Appends values from Dictionaries corresponding to the number.
        /// </summary>
        /// <param name="num"> Value to be converted. Can </param>
        /// <param name="largeDigit"> The key of corresponging Dictionary </param>
        /// <returns> Leftovers of value after appending larger digits </returns>
        protected virtual long Append(long num, long largeDigit)
        {
            if (num > largeDigit - 1)
            {
                long baseScale = num / largeDigit;
                this.AppendLessThanOneThousand(baseScale);
                this.Result.AppendFormat("{0} ", this.LargeNumbersText[largeDigit]);
                num = num - (baseScale * largeDigit);
            }

            return num;
        }

        /// <summary> Appends hundred scale text </summary>
        /// <param name="num"> Value to be converted </param>
        /// <returns> Leftovers of number </returns>
        protected virtual long AppendHundreds(long num)
        {
            if (num > 99)
            {
                long hundreds = num / 100;
                this.Result.AppendFormat("{0} {1} ", this.SmallNumbersText[hundreds], this.SmallNumbersText[100]);
                num = num - (hundreds * 100);
            }

            return num;
        }

        /// <summary> Appends words between hundreds and thousand scale </summary>
        /// <param name="num"> Value to be converted </param>
        /// <returns> Leftovers of number </returns>
        protected long AppendLessThanOneThousand(long num)
        {
            num = this.AppendHundreds(num);
            num = this.AppendTens(num);
            this.AppendUnits(num);
            return num;
        }

        /// <summary> Appends units, i.e. numbers less than 20 </summary>
        /// <param name="num"> Value to be converted </param>
        protected void AppendUnits(long num)
        {
            if (num > 0)
            {
                this.Result.AppendFormat("{0} ", this.SmallNumbersText[num]);
            }
        }

        /// <summary> Appends text representation of tens </summary>
        /// <param name="num"> Value to be converted </param>
        /// <returns> Leftovers of number </returns>
        protected long AppendTens(long num)
        {
            if (num > 20)
            {
                var tens = ((long)(num / 10)) * 10;
                this.Result.AppendFormat("{0} ", this.SmallNumbersText[tens]);
                num = num - tens;
            }

            return num;
        }
    }
}
