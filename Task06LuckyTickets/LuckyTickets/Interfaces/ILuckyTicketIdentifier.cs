using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public interface ILuckyTicketIdentifier
    {
        bool IsLuckyTicket(Ticket ticket);             
    }
}
