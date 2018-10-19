using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText.Classes
{
    public abstract class BaseConverter
    {
        protected Dictionary<long, string> _smallNumbersText;
        protected Dictionary<long, string> _largeNumbersText;
        protected StringBuilder _result;
        protected string _negative;

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
                this._result.AppendFormat("{0} ", this._negative);
                num = Math.Abs(num);
            }

            num = this._largeNumbersText.Aggregate(num, (current, scale) => this.Append(current, scale.Key));
            this.AppendLessThanOneThousand(num);

            return this._result.ToString().Trim();
        }

        protected virtual long Append(long num, long largeDigit)
        {
            if (num > largeDigit - 1)
            {
                long baseScale = num / largeDigit;
                this.AppendLessThanOneThousand(baseScale);
                this._result.AppendFormat("{0} ", this._largeNumbersText[largeDigit]);
                num = num - (baseScale * largeDigit);
            }

            return num;
        }

        protected virtual long AppendHundreds(long num)
        {
            if (num > 99)
            {
                long hundreds = num / 100;
                this._result.AppendFormat("{0} {1} ", this._smallNumbersText[hundreds], this._smallNumbersText[100]);
                num = num - (hundreds * 100);
            }

            return num;
        }

        protected long AppendLessThanOneThousand(long num)
        {
            num = this.AppendHundreds(num);
            num = this.AppendTens(num);
            this.AppendUnits(num);
            return num;
        }

        protected void AppendUnits(long num)
        {
            if (num > 0)
            {
                this._result.AppendFormat("{0} ", this._smallNumbersText[num]);
            }
        }

        protected long AppendTens(long num)
        {
            if (num > 20)
            {
                var tens = ((long)(num / 10)) * 10;
                this._result.AppendFormat("{0} ", this._smallNumbersText[tens]);
                num = num - tens;
            }

            return num;
        }
    }
}
