// <copyright file="ISequence.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 7 and 8, Pow sequence and Fibo sequence.
// </copyright>

namespace NumberSequence.Inetrfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Declares a method for implementing logic in speicifc classes.
    /// </summary>
    internal interface ISequence
    {
        /// <summary>
        /// Selects numbers that satisfies the logic into collection.
        /// </summary>
        /// <returns> The collection of numbers that satisfy the condition. </returns>
        IEnumerable<int> GetSequence();
    }
}
