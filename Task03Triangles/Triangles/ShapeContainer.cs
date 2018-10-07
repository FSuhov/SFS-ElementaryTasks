// <copyright file="ShapeContainer.cs" company="Alex Brylov">
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

    /// <summary> Represents a collection of Shapes </summary>
    public class ShapeContainer
    {
        private List<Shape> listOfShapes = new List<Shape>();

        /// <summary> Adds instance of Shape into collection </summary>
        /// <param name="shape"> An instance of Shape </param>
        public void AddShape(Shape shape)
        {
            this.listOfShapes.Add(shape);
            this.listOfShapes.Sort();
        }

        /// <summary> Generates a string describing every instance of Shape in the collection </summary>
        /// <returns> String representation of every instance in the collection </returns>
        public override string ToString()
        {
            StringBuilder allShapes = new StringBuilder();

            foreach (Shape item in this.listOfShapes)
            {
                allShapes.Append(item.ToString());
                allShapes.Append(Environment.NewLine);
            }

            return allShapes.ToString();
        }
    }
}
