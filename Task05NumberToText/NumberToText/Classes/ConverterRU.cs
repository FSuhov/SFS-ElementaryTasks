// <copyright file="ConverterRU.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText.Classes
{
    using System.Collections.Generic;

    public class ConverterRU : BaseConverter
    {
        protected Dictionary<long, string> _smallNumbersTextPlurals;
        protected Dictionary<long, string> _largeNumbersTextLargePlurals;
        protected Dictionary<long, string> _largeNumbersTextSmallPlurals;
        protected Dictionary<long, string> _hundredsText;
        protected string _negative;

        public ConverterRU()
        {
            this.LoadResources();
        }

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
                    this._result.AppendFormat("{0} ", this._largeNumbersTextLargePlurals[largeDigit]);
                }
                else if (lastDigit > 1 )
                {
                    this._result.AppendFormat("{0} ", this._largeNumbersTextSmallPlurals[largeDigit]);
                }
                else
                {
                    this._result.AppendFormat("{0} ", this._largeNumbersText[largeDigit]);
                }

                num = num - (baseScale * largeDigit);
            }

            return num;
        }

        protected override long AppendHundreds(long num)
        {
            if (num > 99)
            {
                long hundreds = num / 100;
                this._result.AppendFormat("{0} ", this._hundredsText[hundreds]);
                num = num - (hundreds * 100);
            }

            return num;
        }

        protected virtual void LoadResources()
        {
            this._smallNumbersTextPlurals = ResourcesRU.TEXT_NUMBERS_SOME_PLURALS;
            this._smallNumbersText = ResourcesRU.TEXT_NUMBERS;
            this._largeNumbersText = ResourcesRU.TEXT_LARGE_NUMBERS;
            this._largeNumbersTextLargePlurals = ResourcesRU.TEXT_LARGE_NUMBERS_LARGE_PLURALS;
            this._largeNumbersTextSmallPlurals = ResourcesRU.TEXT_LARGE_NUMBERS_SMALL_PLURALS;
            this._negative = ResourcesRU.MINUS;
            this._hundredsText = ResourcesRU.TEXT_HUNDREDS;
        }

        protected int GetLastDigit(long number)
        {
            string text = number.ToString();
            string last = text[text.Length - 1].ToString();
            return int.Parse(last);
        }

        protected void HandleThousands(long baseScale)
        {
            Dictionary<long, string> temp = this._smallNumbersText;
            this._smallNumbersText = this._smallNumbersTextPlurals;
            this.AppendLessThanOneThousand(baseScale);
            this._smallNumbersText = temp;
        }
    }
}
