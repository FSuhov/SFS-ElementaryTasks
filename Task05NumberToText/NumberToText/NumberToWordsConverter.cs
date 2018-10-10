
namespace NumberToText
{
    using System;

    internal static class NumberToWordsConverter
    {
        private static readonly string[] units = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                                  "eleven", "twelve", "thirteen", "fourtheen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static readonly string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        public static string Convert(int number)
        {
            if (number == 0)
            {
                return units[number];
            }
            if (number < 0)
            {
                return Convert(Math.Abs(number));
            }

            string result = String.Empty;

            if (number / 1_000_000_000 > 0)
            {
                result += Convert(number / 1_000_000_000) + " billion ";
                number %= 1_000_000_000;
            }

            if (number / 1_000_000 > 0)
            {
                result += Convert(number / 1_000_000) + " million ";
                number %= 1_000_000;
            }

            if (number / 1_000 > 0)
            {
                result += Convert(number / 1_000) + " thousand ";
                number %= 1_000;
            }

            if (number / 100 > 0)
            {
                result += Convert(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if ( result != String.Empty)
                {
                    result += "and ";
                }

                if (number < 20)
                {
                    result += units[number];
                }
                else
                {
                    result += tens[number / 10];
                    if ((number % 10) > 0)
                    {
                        result += " " + units[number % 10];
                    }
                }
            }
            return result;
        }
    }
}
