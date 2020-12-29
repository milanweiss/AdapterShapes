using AdapterPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapters
{
    class TrianglePegAdapter : IRoundPeg
    {
        private TrianglePeg peg;

        public TrianglePegAdapter(TrianglePeg peg)
        {
            this.peg = peg;
        }
        public int GetRadius()
        {
            int a = peg.GetSideA();
            int b = peg.GetSideB();
            int c = peg.GetSideC();

            // semiperimeter of the circle
            double p = (a + b + c) / 2;

            // area of triangle
            double At = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // radius circle
            double radius = (a * b * c) / (4 * At);
            return (int)Math.Ceiling(radius);

        }
    }
}
