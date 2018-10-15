// <copyright file="NumberToWordsConverter.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>
namespace NumberToText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Implements logic of the application:
    /// Contains methods of convertion of number to text and set of data.
    /// </summary>
    public class NumberToWordsConverter
    {
        private Dictionary<long, string> _smallNumbersText;
        private Dictionary<long, string> _largeNumbersText;
        private Dictionary<long, string> _largeNumbersTextPlurals;
        private Dictionary<long, string> _hundredsText;
        private string _negative;
        private StringBuilder _result;
        private Locale _locale;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberToWordsConverter"/> class.
        /// </summary>
        /// <param name="localization"> Optional parameter that sets language for output. </param>
        public NumberToWordsConverter(string localization = "en")
        {
            this.SetLocalizedResources(localization);
        }

        private enum Locale
        {
            EN,
            RU
        }

        /// <summary>
        /// Converts numeric representation of number into next representation.
        /// </summary>
        /// <param name="num"> Number to be converted. </param>
        /// <returns> Text representation of number. </returns>
        public string ConvertToWords(long num)
        {
            this._result = new StringBuilder();

            if (num == 0)
            {
                this._result.Append(this._smallNumbersText[num]);
                return this._result.ToString();
            }

            if (num < 0)
            {
                this._result.Append(this._negative);
                num = Math.Abs(num);
            }

            num = this._largeNumbersText.Aggregate(num, (current, scale) => this.Append(current, scale.Key));
            this.AppendLessThanOneThousand(num);

            return this._result.ToString().Trim();
        }

        private long Append(long num, long largeDigit)
        {
            if (num > largeDigit - 1)
            {
                long baseScale = num / largeDigit;
                this.AppendLessThanOneThousand(baseScale);
                if (baseScale > 1)
                {
                    this._result.AppendFormat("{0} ", this._largeNumbersTextPlurals[largeDigit]);
                }
                else
                {
                    this._result.AppendFormat("{0} ", this._largeNumbersText[largeDigit]);
                }

                num = num - (baseScale * largeDigit);
            }

            return num;
        }

        private long AppendLessThanOneThousand(long num)
        {
            num = this.AppendHundreds(num);
            num = this.AppendTens(num);
            this.AppendUnits(num);
            return num;
        }

        private void AppendUnits(long num)
        {
            if (num > 0)
            {
                this._result.AppendFormat("{0} ", this._smallNumbersText[num]);
            }
        }

        private long AppendTens(long num)
        {
            if (num > 20)
            {
                var tens = ((long)(num / 10)) * 10;
                this._result.AppendFormat("{0} ", this._smallNumbersText[tens]);
                num = num - tens;
            }

            return num;
        }

        private long AppendHundreds(long num)
        {
            if (num > 99)
            {
                long hundreds = num / 100;
                switch (this._locale)
                {
                    case Locale.EN:
                        this._result.AppendFormat("{0} hundred ", this._smallNumbersText[hundreds]);
                        break;
                    case Locale.RU:
                        this._result.AppendFormat(" {0} ", this._hundredsText[hundreds]);
                        break;
                }

                num = num - (hundreds * 100);
            }

            return num;
        }

        private void SetLocalizedResources(string localization)
        {
            if (localization.Equals("ru"))
            {
                this._smallNumbersText = ResourcesRU.TEXT_NUMBERS;
                this._largeNumbersText = ResourcesRU.TEXT_LARGE_NUMBERS;
                this._largeNumbersTextPlurals = ResourcesRU.TEXT_LARGE_NUMBERS_PLURALS;
                this._negative = ResourcesRU.MINUS;
                this._hundredsText = ResourcesRU.TEXT_HUNDREDS;
                this._locale = Locale.RU;
            }
            else
            {
                this._smallNumbersText = ResourcesEN.TEXT_NUMBERS;
                this._largeNumbersText = ResourcesEN.TEXT_LARGE_NUMBERS;
                this._largeNumbersTextPlurals = this._largeNumbersText;
                this._negative = ResourcesEN.MINUS;
                this._locale = Locale.EN;
            }
        }
    }
}
