// <copyright file="ConverterUA.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText.Classes
{
    /// <summary>
    /// Represents a class that can convert the value into Russian text representation.
    /// Overrides method for loading Dictionaries that are required for Ukrainian translation.
    /// Inherites methods from ConverterRU that common for all languages.
    /// </summary>
    public class ConverterUA : ConverterRU
    {
        /// <summary> Loads Ukrainian dictionaries. Called in inherited constructor. </summary>
        protected override void LoadResources()
        {
            this.SmallNumbersTextPlurals = ResourcesUA.TEXT_NUMBERS_SOME_PLURALS;
            this.SmallNumbersText = ResourcesUA.TEXT_NUMBERS;
            this.LargeNumbersText = ResourcesUA.TEXT_LARGE_NUMBERS;
            this.LargeNumbersTextLargePlurals = ResourcesUA.TEXT_LARGE_NUMBERS_LARGE_PLURALS;
            this.LargeNumbersTextSmallPlurals = ResourcesUA.TEXT_LARGE_NUMBERS_SMALL_PLURALS;
            this.Negative = ResourcesUA.MINUS;
            this.HundredsText = ResourcesUA.TEXT_HUNDREDS;
        }
    }
}
