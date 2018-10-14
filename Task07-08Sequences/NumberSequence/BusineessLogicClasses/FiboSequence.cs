// <copyright file="FiboSequence.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 7 and 8, Pow sequence and Fibo sequence.
// </copyright>

namespace NumberSequence.BusineessLogicClasses
{
    using System.Collections.Generic;
    using NumberSequence.Inetrfaces;

    /// <summary>
    /// Represents an object that generates a part of Fibonacci sequence
    /// consisting of numbers within the range specified in the constructor.
    /// </summary>
    public class FiboSequence : ISequence
    {
        private int _start;
        private int _limit;

        /// <summary>
        /// Initializes a new instance of the <see cref="FiboSequence"/> class.
        /// </summary>
        /// <param name="start"> Beginning of the range. </param>
        /// <param name="limit"> End of range. </param>
        public FiboSequence(int start, int limit)
        {
            this._start = start;
            this._limit = limit;
        }

        /// <summary>
        /// Implements the logic:
        /// Goes throw Fibonacci sequence and records into the collection numbers within the range.
        /// </summary>
        /// <returns> A collection containing Fibonacci numbers within the range. </returns>
        public IEnumerable<int> GetSequence()
        {
            int a = 0;
            int b = 1;

            while (b <= this._limit)
            {
                int temp = b;
                b = a + b;
                a = temp;
                if (b >= this._start)
                {
                    yield return b;
                }
            }
        }

        /// <summary>
        /// Generates a string containing information about algorythm and range limits.
        /// </summary>
        /// <returns> Informative string. </returns>
        public override string ToString()
        {
            return $"Fibo sequence from {this._start} to {this._limit}:";
        }
    }
}
