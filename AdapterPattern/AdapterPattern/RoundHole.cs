using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class RoundHole
    {
        private int radius;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }

        public bool IsFitting(IRoundPeg peg)
        {
            if (peg.GetRadius() <= radius) return true;
            return false;
        }
    }
}
