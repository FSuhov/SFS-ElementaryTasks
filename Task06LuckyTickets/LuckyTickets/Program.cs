using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] localArgs = { "input.txt" };
            ConsoleLuckyTicketCounter ticketCounter = new ConsoleLuckyTicketCounter();
            ticketCounter.Init(localArgs);
            ticketCounter.ShowResult();

            //ILuckyTicketIdentifier ticketIdentifier = new LuckyTicketPeter();
            //int x = ticketIdentifier.CountNumberOfLuckyTickets();
            //Console.WriteLine(x);

            //ticketIdentifier = new LuckyTicketMoscowExtended(8);
            //x = ticketIdentifier.CountNumberOfLuckyTickets();
            //Console.WriteLine(x);
        }
    }
}
