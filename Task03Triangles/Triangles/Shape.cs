// <copyright file="Shape.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace Triangles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary> Representation an abstract shape </summary>
    public abstract class Shape : IComparable<Shape>
    {
        /// <summary> Gets or sets the name of the shape </summary>
        public string Name { get; set; }

        /// <summary> A prototype of implementation of IComparable interface </summary>
        /// <param name="other"> Another instance of Shape to compare with </param>
        /// <returns> Integer comparison result </returns>
        public abstract int CompareTo(Shape other);

        /// <summary> A prototype of the logic to calcilate an area of shape</summary>
        /// <returns> Value of area of Shape </returns>
        public abstract double GetArea();
    }
}
