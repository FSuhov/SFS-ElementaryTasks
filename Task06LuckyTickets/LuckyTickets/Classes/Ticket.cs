// <copyright file="Ticket.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    using System;

    /// <summary>
    /// Represents a ticket containing a serial number of known length.
    /// </summary>
    public class Ticket
    {
        private long _number;
        private int _digits;

        /// <summary> Initializes a new instance of the <see cref="Ticket"/> class. </summary>
        /// <param name="number"> Serial number of ticket. </param>
        /// <param name="digits"> Quantity of digits in serial number. </param>
        public Ticket(long number, int digits)
        {
            this._number = number;
            this._digits = digits;
        }

        /// <summary> Indexer of the Ticket. </summary>
        /// <param name="index"> Index of digit. </param>
        /// <returns> Value of that digit. </returns>
        public int this[int index]
        {
            get
            {
                if (index >= this._digits || index < 0)
                {
                    return 0;
                }
                else
                {
                    return (int)((this._number % Math.Pow(10, this._digits - index))
                                / Math.Pow(10, this._digits - index - 1));
                }
            }
        }
    }
}
