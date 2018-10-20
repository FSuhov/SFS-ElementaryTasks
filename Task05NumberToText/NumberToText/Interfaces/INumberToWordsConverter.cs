// <copyright file="INumberToWordsConverter.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText.Interfaces
{
    /// <summary>
    /// Interface containing the prototype of method ConvertToWords.
    /// Supposed to be implemented with the specific logic in the implementing classes.
    /// </summary>
    public interface INumberToWordsConverter
    {
        /// <summary>
        /// Major method containing the logic of number to text convertion.
        /// </summary>
        /// <param name="num"> Numeric value to be converted. </param>
        /// <returns> Written in words representation of value. </returns>
        string ConvertToWords(long num);
    }
}
