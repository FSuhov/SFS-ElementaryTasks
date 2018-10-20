// <copyright file="ConverterEN.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents a class that can convert the value into English text representation.
    /// Contains method for loading English language resources.
    /// </summary>
    public class ConverterEN : ConverterEurope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConverterEN"/> class.
        /// Loads required resources.
        /// </summary>
        public ConverterEN()
        {
            this.LoadResources();
        }

        /// <summary> Loads English dictionaries. </summary>
        protected void LoadResources()
        {
            this.SmallNumbersText = ResourcesEN.TEXT_NUMBERS;
            this.LargeNumbersText = ResourcesEN.TEXT_LARGE_NUMBERS;
            this.Negative = ResourcesEN.MINUS;
        }
    }
}
