// <copyright file="PowSequence.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 7 and 8, Pow sequence and Fibo sequence.
// </copyright>

namespace NumberSequence.BusineessLogicClasses
{
    using System.Collections.Generic;
    using NumberSequence.Inetrfaces;

    /// <summary>
    /// Represents an object that generates a natural numbers sequence
    /// consisting of numbers which pow 2 is less than limit specified in the constructor.
    /// </summary>
    public class PowSequence : ISequence
    {
        private int _start = 0;
        private int _limit;

        /// <summary>
        /// Initializes a new instance of the <see cref="PowSequence"/> class.
        /// </summary>
        /// <param name="limit"> Top limit of range. </param>
        public PowSequence(int limit)
        {
            this._limit = limit;
        }

        /// <summary>
        /// Implements the logic:
        /// Goes throw the numbers from 0 to top limit
        /// and records into the collection numbers which pow 2 is less than top limit.
        /// </summary>
        /// <returns> A collection containing recorder numbers that specifies the condition. </returns>
        public IEnumerable<int> GetSequence()
        {
            for (int i = this._start; i < this._limit; i++)
            {
                if (i * i < this._limit)
                {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// Generates a string containing information about algorythm and range top limit.
        /// </summary>
        /// <returns> Informative string. </returns>
        public override string ToString()
        {
            return $"Pow sequence to {this._limit}:";
        }
    }
}
