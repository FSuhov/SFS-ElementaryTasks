// <copyright file="ShapeList.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 3 - TRIANGLES
// </copyright>

namespace Triangles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a container for any IShapes
    /// </summary>
    public class ShapeList : List<IShape>
    {
        /// <summary> Generates a string describing every instance of Shape in the collection </summary>
        /// <returns> String representation of every instance in the collection </returns>
        public override string ToString()
        {
            this.Sort();
            StringBuilder allShapes = new StringBuilder();

            foreach (IShape item in this)
            {
                allShapes.Append(item.ToString());
                allShapes.Append(Environment.NewLine);
            }

            return allShapes.ToString();
        }
    }
}
