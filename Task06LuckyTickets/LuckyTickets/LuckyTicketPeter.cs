using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    class LuckyTicketPeter : ILuckyTicketIdentifier
    {
        const int maxNumber = 999_999;

        public string Number { get; set; }

        public int this[int index]
        {
            get
            {
                return (int)char.GetNumericValue(Number.ToCharArray()[index]);
            }
        }

        public bool IsLuckyTicket()
        {
            return (this[0] + this[2] + this[4]) == (this[1] + this[3] + this[5]);
        }

        public int CountNumberOfLuckyTickets()
        {
            int counter = 0;
            for (int i = 1; i < maxNumber; i++)
            {
                Number = i.ToString("D6");
                if (IsLuckyTicket())
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
