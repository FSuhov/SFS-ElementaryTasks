// <copyright file="Triangle.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 3 - TRIANGLES
// </copyright>
namespace Triangles
{
    using System;

    /// <summary> Represents a shape with three sides </summary>
    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        /// <summary> Initializes a new instance of the <see cref="Triangle"/> class.</summary>
        /// <param name="name">Name of instance</param>
        /// <param name="a"> length of side 1 </param>
        /// <param name="b"> length of side 2 </param>
        /// <param name="c"> length of side 3 </param>
        public Triangle(string name, double a, double b, double c)
        {
            this.Name = name;
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

        /// <summary> Gets or sets verbal name of shape given by user </summary>
        public string Name { get; set; }

        /// <summary>
        /// Compares current instance with another instance of Shape based on Area
        /// </summary>
        /// <param name="other"> An instance of shape to compare with </param>
        /// <returns> Comparison result: 1 if this smaller than other, -1 if larger, 0 if equal </returns>
        public int CompareTo(IShape other)
        {
            double thisArea = this.GetArea();
            double otherArea = other.GetArea();
            if (thisArea > otherArea)
            {
                return -1;
            }
            else if (thisArea < otherArea)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary> Calculates an area of Triangle by Heron formula </summary>
        /// <returns> An area of this instance of triangle </returns>
        public double GetArea()
        {
            double perimeter = this.sideA + this.sideB + this.sideC;
            return Math.Sqrt(
                             (perimeter / 2) *
                             (perimeter - this.sideA) *
                             (perimeter - this.sideB) *
                             (perimeter - this.sideC));
        }

        /// <summary> Generates a string containing info about this instance of Triangle</summary>
        /// <returns> String containing name and area </returns>
        public override string ToString()
        {
            return $"[Triangle {this.Name}]: {this.GetArea()} cm";
        }
    }
}
