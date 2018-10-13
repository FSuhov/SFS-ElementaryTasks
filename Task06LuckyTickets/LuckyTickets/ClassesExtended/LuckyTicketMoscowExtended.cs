// <copyright file="LuckyTicketMoscowExtended.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    /// <summary>
    /// Represents LuckyTicketMoscow class with extended options.
    /// </summary>
    public class LuckyTicketMoscowExtended : LuckyTicketMoscow
    {
        private int _digits;

        /// <summary>
        /// Initializes a new instance of the <see cref="LuckyTicketMoscowExtended"/> class.
        /// </summary>
        /// <param name="digits"> Number of digits in tickets serial number. </param>
        public LuckyTicketMoscowExtended(int digits)
        {
            this._digits = digits;
        }

        /// <summary>
        /// Overrides the lucky ticket check using Moscow algorythm.
        /// </summary>
        /// <param name="ticket"> An instance of ticket. </param>
        /// <returns> The result of check. </returns>
        public override bool IsLuckyTicket(Ticket ticket)
        {
            long leftSum = 0;
            long rightSum = 0;

            for (int i = 0, j = this._digits / 2; i < this._digits / 2 && j < this._digits; i++, j++)
            {
                leftSum += ticket[i];
                rightSum += ticket[j];
            }

            return leftSum == rightSum;
        }
    }
}
