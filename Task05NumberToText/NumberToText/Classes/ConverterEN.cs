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
    /// Implements logic of the application:
    /// Contains methods of convertion of number to text and set of data.
    /// </summary>
    public class ConverterEN : BaseConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConverterEN"/> class.
        /// Loads required resources.
        /// </summary>
        public ConverterEN()
        {
            this.LoadResources();
        }

        protected void LoadResources()
        {
            this._smallNumbersText = ResourcesEN.TEXT_NUMBERS;
            this._largeNumbersText = ResourcesEN.TEXT_LARGE_NUMBERS;
            this._negative = ResourcesEN.MINUS;
        }
    }
}
