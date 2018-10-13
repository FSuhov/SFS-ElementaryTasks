// <copyright file="LuckyTicketPeterExtended.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    /// <summary>
    /// Represents LuckyTicketPeter class with extended options.
    /// </summary>
    public class LuckyTicketPeterExtended : LuckyTicketPeter
    {
        private int _digits;

        /// <summary>
        /// Initializes a new instance of the <see cref="LuckyTicketPeterExtended"/> class.
        /// </summary>
        /// <param name="digits"> Number of digits in tickets serial number. </param>
        public LuckyTicketPeterExtended(int digits)
        {
            this._digits = digits;
        }

        /// <summary>
        /// Overrides the lucky ticket check using Piter algorythm.
        /// </summary>
        /// <param name="ticket"> An instance of ticket. </param>
        /// <returns> The result of check. </returns>
        public override bool IsLuckyTicket(Ticket ticket)
        {
            long leftSum = 0;
            long rightSum = 0;

            for (int i = 0, j = 1; i < this._digits - 1 && j < this._digits; i++, j++)
            {
                leftSum += ticket[i];
                rightSum += ticket[j];
            }

            return leftSum == rightSum;
        }
    }
}
