// <copyright file="Envelope.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 2 - ENVELOPES.
// </copyright>

namespace Envelopes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an Envelope with determined width and height.
    /// Implements IComparable interface
    /// Contains method for identification whether one instance
    /// can be placed inside another
    /// </summary>
    public class Envelope : IComparable<Envelope>
    {
        private float width;
        private float height;

        /// <summary>Initializes a new instance of the <see cref="Envelope"/> class. Initializes the new instance of Envelope.</summary>
        /// <param name="width"> Width of envelope (i.e. - one of the sides length </param>
        /// <param name="height"> Height of envelope (i.e. - another side's length </param>
        public Envelope(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Implementation of CompareTo method,
        /// customized to identify whether one of envelopes can be placed into another.
        /// </summary>
        /// <param name="other">An instance of envelope to compare to. </param>
        /// <returns>
        /// -1 if this instance can be placed inside another instance,
        /// 1 if another instance can be placed inside this instance
        /// 0 if neither this instance can be placed inside other nor other inside this.
        /// </returns>
        public int CompareTo(Envelope other)
        {
            if ((this.width < other.width && this.height < other.height) ||
                (this.height < other.width && this.width < other.height))
            {
                return -1;
            }
            else if ((this.width > other.width && this.height > other.height) ||
               (this.height > other.width && this.width > other.height))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary> Overrides ToString method. </summary>
        /// <returns> The string containing envelope instance width and height</returns>
        public override string ToString()
        {
            return $"width {this.width}, height {this.height}";
        }
    }
}
