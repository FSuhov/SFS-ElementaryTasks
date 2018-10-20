// <copyright file="ConverterRU.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText.Classes
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a class that can convert the value into Russian text representation.
    /// Contains extra Dictionary properties that are required for Russian translation.
    /// Contains method for loading Russian language resources.
    /// Inherites methods from ConverterEurope that common for all languages.
    /// Overrides methods when ConverterEurope logic does not fit Russian semantic.
    /// </summary>
    public class ConverterRU : ConverterEurope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConverterRU"/> class.
        /// Loads required resources.
        /// </summary>
        public ConverterRU()
        {
            this.LoadResources();
        }

        /// <summary> Gets or sets extra dictionary containing numeric keys and corresponding
        /// verbal values for large scale numbers in plural view (i.e. 1_000_000, "миллионов"). </summary>
        protected Dictionary<long, string> LargeNumbersTextLargePlurals { get; set; }

        /// <summary> Gets or sets extra dictionary containing numeric keys and corresponding
        /// verbal values for large scale numbers in plural view when leading number is between 2 and 4
        /// (i.e. 1_000_000, "миллионa"). </summary>
        protected Dictionary<long, string> LargeNumbersTextSmallPlurals { get; set; }

        /// <summary> Gets or sets extra dictionary containing numeric keys and corresponding
        /// verbal values for leading hundreds (i.e. 800, "восеьмсот"). </summary>
        protected Dictionary<long, string> HundredsText { get; set; }

        /// <summary> Gets or sets dictionary containing numeric keys and corresponding
        /// verbal values less than 100 where some numbers are plurals (i.e. 1, "одна"). </summary>
        protected Dictionary<long, string> SmallNumbersTextPlurals { get; set; }

        /// <summary>
        /// Appends values from Dictionaries corresponding to the number.
        /// </summary>
        /// <param name="num"> Value to be converted. Can </param>
        /// <param name="largeDigit"> The key of corresponging Dictionary </param>
        /// <returns> Leftovers of value after appending larger digits </returns>
        protected override long Append(long num, long largeDigit)
        {
            if (num > largeDigit - 1)
            {
                long baseScale = num / largeDigit;
                int lastDigit = this.GetLastDigit(baseScale);
                if ((lastDigit == 1 || lastDigit == 2) && largeDigit == 1000)
                {
                    this.HandleThousands(baseScale);
                }
                else
                {
                    this.AppendLessThanOneThousand(baseScale);
                }

                if (lastDigit > 4 || ((baseScale % 100 > 10) && (baseScale % 100 < 20)) || (baseScale % 10 == 0))
                {
                    this.Result.AppendFormat("{0} ", this.LargeNumbersTextLargePlurals[largeDigit]);
                }
                else if (lastDigit > 1)
                {
                    this.Result.AppendFormat("{0} ", this.LargeNumbersTextSmallPlurals[largeDigit]);
                }
                else
                {
                    this.Result.AppendFormat("{0} ", this.LargeNumbersText[largeDigit]);
                }

                num = num - (baseScale * largeDigit);
            }

            return num;
        }

        /// <summary> Appends hundred scale text </summary>
        /// <param name="num"> Value to be converted </param>
        /// <returns> Leftovers of number </returns>
        protected override long AppendHundreds(long num)
        {
            if (num > 99)
            {
                long hundreds = num / 100;
                this.Result.AppendFormat("{0} ", this.HundredsText[hundreds]);
                num = num - (hundreds * 100);
            }

            return num;
        }

        /// <summary> Loads Russian dictionaries. </summary>
        protected virtual void LoadResources()
        {
            this.SmallNumbersTextPlurals = ResourcesRU.TEXT_NUMBERS_SOME_PLURALS;
            this.SmallNumbersText = ResourcesRU.TEXT_NUMBERS;
            this.LargeNumbersText = ResourcesRU.TEXT_LARGE_NUMBERS;
            this.LargeNumbersTextLargePlurals = ResourcesRU.TEXT_LARGE_NUMBERS_LARGE_PLURALS;
            this.LargeNumbersTextSmallPlurals = ResourcesRU.TEXT_LARGE_NUMBERS_SMALL_PLURALS;
            this.Negative = ResourcesRU.MINUS;
            this.HundredsText = ResourcesRU.TEXT_HUNDREDS;
        }

        /// <summary>
        /// Helper method required to apply correcy plural representation.
        /// </summary>
        /// <param name="number"> Value to be converted. </param>
        /// <returns> Last digit of that value. </returns>
        protected int GetLastDigit(long number)
        {
            string text = number.ToString();
            string last = text[text.Length - 1].ToString();
            return int.Parse(last);
        }

        /// <summary>
        /// Helper method that reverses the resources
        /// when converting thousands in Russian semantic.
        /// </summary>
        /// <param name="baseScale"> Current basescale. </param>
        protected void HandleThousands(long baseScale)
        {
            Dictionary<long, string> temp = this.SmallNumbersText;
            this.SmallNumbersText = this.SmallNumbersTextPlurals;
            this.AppendLessThanOneThousand(baseScale);
            this.SmallNumbersText = temp;
        }
    }
}
