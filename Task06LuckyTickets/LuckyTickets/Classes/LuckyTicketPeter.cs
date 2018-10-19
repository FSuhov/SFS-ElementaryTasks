// <copyright file="LuckyTicketPeter.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    /// <summary> Represents an class that can check the lucky ticket using Piter arlgorythm. </summary>
    public class LuckyTicketPeter : ILuckyTicketIdentifier
    {
        /// <summary>
        /// Implements the lucky ticket check using Piter algorythm.
        /// </summary>
        /// <param name="ticket"> An instance of ticket. </param>
        /// <returns> The result of check. </returns>
        public virtual bool IsLuckyTicket(Ticket ticket)
        {
            ulong leftSum = 0;
            ulong rightSum = 0;
            int digits = ticket.GetNumberLength();

            for (int i = 0, j = 1; i < digits - 1 && j < digits; i += 2, j += 2)
            {
                leftSum += ticket[i];
                rightSum += ticket[j];
            }

            return leftSum == rightSum;
        }

        /// <summary>
        /// Overrides ToString method, returning informative string about algorithm used.
        /// </summary>
        /// <returns> An informative string about algorithm used. </returns>
        public override string ToString()
        {
            return "Piter algorythm ";
        }
    }
}
