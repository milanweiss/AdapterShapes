using AdapterPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapters
{
    class SquarePegAdapter : IRoundPeg
    {
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }

        public int GetRadius()
        {
            return (int)Math.Ceiling(peg.GetWidth() * Math.Sqrt(2) / 2);
        }
    }
}
