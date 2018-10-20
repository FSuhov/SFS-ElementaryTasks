// <copyright file="IShape.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 3 - TRIANGLES
// </copyright>

namespace Triangles
{
    using System;

    /// <summary> Representation an abstract shape </summary>
    public interface IShape : IComparable<IShape>
    {
        /// <summary> Gets or sets the name of the shape </summary>
        string Name { get; set; }

        /// <summary> A prototype of the logic to calcilate an area of shape</summary>
        /// <returns> Value of area of Shape </returns>
        double GetArea();
    }
}
