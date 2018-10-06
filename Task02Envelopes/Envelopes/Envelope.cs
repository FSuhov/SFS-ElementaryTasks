using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopes
{
    public class Envelope : IComparable<Envelope>
    {
        public float width;
        public float height;

        public Envelope(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
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
            else return 0;
        }

        public override string ToString()
        {
            return $"width {this.width}, height {this.height}";
        }
    }
}
