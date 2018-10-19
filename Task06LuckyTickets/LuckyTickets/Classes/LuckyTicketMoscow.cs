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
            long leftSum = 0;
            long rightSum = 0;
            int digits = ticket.GetNumberLength();

            for (int i = 0, j = digits / 2; i < digits / 2 && j < digits; i++, j++)
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
            return "Moscow algorythm ";
        }
    }
}
