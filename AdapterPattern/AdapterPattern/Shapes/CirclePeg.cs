using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Shapes
{
    class CirclePeg : IRoundPeg
    {
        private int radius;

        public CirclePeg(int radius)
        {
            this.radius = radius;
        }
        public int GetRadius()
        {
            return radius;
        }
    }
}
