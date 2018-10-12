using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    class LuckyTicketMoscow : ILuckyTicketIdentifier
    {        
        public string Number { get; set; }

        const int maxNumber = 999_999;

        public virtual bool IsLuckyTicket()
        {
            return (this[0] + this[1] + this[2]) == (this[3] + this[4] + this[5]);
        }

        public int this[int index]
        {
            get
            {
                return (int)char.GetNumericValue(Number.ToCharArray()[index]);
            }
        }

        public virtual int CountNumberOfLuckyTickets()
        {
            int counter = 0;
            for(int i = 0; i < maxNumber; i++)
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
