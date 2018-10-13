// <copyright file="LuckyTicketMoscow.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    /// <summary> Represents an class that can check the lucky ticket using Moscow arlgorythm. </summary>
    public class LuckyTicketMoscow : ILuckyTicketIdentifier
    {
        /// <summary>
        /// Overrides the lucky ticket check using Moscow algorythm.
        /// </summary>
        /// <param name="ticket"> An instance of ticket. </param>
        /// <returns> The result of check. </returns>
        public virtual bool IsLuckyTicket(Ticket ticket)
        {
            return (ticket[0] + ticket[1] + ticket[2])
                == (ticket[3] + ticket[4] + ticket[5]);
        }
    }
}
