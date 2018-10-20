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
        private ulong _maxNumber;
        private int _digits;

        private ILuckyTicketIdentifier _ticketIdentifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="LuckyTicketCounter"/> class.
        /// </summary>
        /// <param name="ticketIdentifier"> An instance of object that implements ILuckyTicketIdentifier interface. </param>
        /// <param name="digits"> A number of digits in the ticket. </param>
        public LuckyTicketCounter(ILuckyTicketIdentifier ticketIdentifier, int digits = LuckyTicketsConfig.DEFAULT_DIGITS)
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
            for (ulong i = 1; i <= this._maxNumber; i++)
            {
                if (this._ticketIdentifier.IsLuckyTicket(new Ticket(i, this._digits)))
                {
                    counter++;
                }
            }

            return counter;
        }

        /// <summary>
        /// Creates an informative string about the range of possible tickets serial numbers
        /// </summary>
        /// <returns> A string containing minimal and maximum possible serial number </returns>
        public override string ToString()
        {
            return string.Format("{0} within the range of 0 and {1}", this._ticketIdentifier.ToString(), this._maxNumber);
        }

        private ulong GetMaxNumber(int digits)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < digits; i++)
            {
                result.Append(LuckyTicketsConfig.MAX_VALUE);
            }

            return ulong.Parse(result.ToString());
        }
    }
}
