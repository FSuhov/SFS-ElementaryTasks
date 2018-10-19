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
        private byte[] _numberAsArray;

        /// <summary> Initializes a new instance of the <see cref="Ticket"/> class. </summary>
        /// <param name="number"> Serial number of ticket. </param>
        /// <param name="digits"> Quantity of digits in serial number. </param>
        public Ticket(ulong number, int digits)
        {
            this._numberAsArray = this.NumberToArray(number, digits);
        }

        /// <summary>
        /// Indexer of the Ticket.
        /// Throws exception if called out of range.
        /// </summary>
        /// <param name="index"> Index of digit. </param>
        /// <returns> Value of that digit. </returns>
        public byte this[int index]
        {
            get
            {
                try
                {
                    return this._numberAsArray[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Gets the length of ticket serial number.
        /// Required for methods that identifies whether the ticket is lucky or not.
        /// </summary>
        /// <returns> Length of serial number - i.e. number of digits. </returns>
        public int GetNumberLength()
        {
            return this._numberAsArray.Length;
        }

        private byte[] NumberToArray(ulong number, int digits)
        {
            byte[] numberAsArray = new byte[digits];
            ulong j = 10;
            for (int i = digits - 1; i >= 0; i--)
            {
                numberAsArray[i] = (byte)(number % j);
                number /= j;
            }

            return numberAsArray;
        }
    }
}
