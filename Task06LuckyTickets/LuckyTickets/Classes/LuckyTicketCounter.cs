// <copyright file="LuckyTicketCounter.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    using System.Text;

    /// <summary>
    /// Represents an object which can count the possible number of lucky tickets.
    /// </summary>
    public class LuckyTicketCounter
    {
        private long _maxNumber;
        private int _digits;

        private ILuckyTicketIdentifier _ticketIdentifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="LuckyTicketCounter"/> class.
        /// </summary>
        /// <param name="ticketIdentifier"> An instance of object that implements ILuckyTicketIdentifier interface. </param>
        public LuckyTicketCounter(ILuckyTicketIdentifier ticketIdentifier)
        {
            this._ticketIdentifier = ticketIdentifier;
            this._maxNumber = 999_999;
            this._digits = LuckyTicketsConfig.DEFAULT_DIGITS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuckyTicketCounter"/> class.
        /// </summary>
        /// <param name="ticketIdentifier"> An instance of object that implements ILuckyTicketIdentifier interface. </param>
        /// <param name="digits"> A number of digits in the ticket. </param>
        public LuckyTicketCounter(ILuckyTicketIdentifier ticketIdentifier, int digits)
        {
            this._ticketIdentifier = ticketIdentifier;
            this._maxNumber = this.GetMaxNumber(digits);
            this._digits = digits;
        }

        /// <summary>
        /// Checks and returns the possible number of lucky tickets.
        /// </summary>
        /// <returns> Possible number of lucky tickets. </returns>
        public int CountNumberOfLuckyTickets()
        {
            int counter = 0;
            for (int i = 1; i <= this._maxNumber; i++)
            {
                if (this._ticketIdentifier.IsLuckyTicket(new Ticket(i, this._digits)))
                {
                    counter++;
                }
            }

            return counter;
        }

        private long GetMaxNumber(int digits)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < digits; i++)
            {
                result.Append("9");
            }

            return long.Parse(result.ToString());
        }
    }
}
