using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    class LuckyTicketMoscowExtended : LuckyTicketMoscow
    {
        long maxNumber;

        public LuckyTicketMoscowExtended(int digits)
        {
            this.maxNumber = GetMaxNumber(digits);
        }

        public override bool IsLuckyTicket()
        {
            int digits = maxNumber.ToString().Length;
            long leftSum = 0;
            long rightSum = 0;
            for(int i = 0, j = digits/2; i < digits / 2 && j < digits; i++, j++)
            {
                leftSum += this[i];
                rightSum += this[j];
            }
            return leftSum == rightSum;
        }

        public override int CountNumberOfLuckyTickets()
        {
            string format = "D" + maxNumber.ToString().Length;
            int counter = 0;
            for (long i = 1; i < maxNumber; i++)
            {
                Number = i.ToString(format);
                if (IsLuckyTicket())
                {
                    counter++;
                }
            }
            return counter;
        }

        private long GetMaxNumber(int digits)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < digits; i++)
            {
                result.Append("9");
            }
            return long.Parse(result.ToString());
        }
    }
}
