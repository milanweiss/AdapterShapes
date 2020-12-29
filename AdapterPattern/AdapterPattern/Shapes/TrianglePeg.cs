using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Shapes
{
    class TrianglePeg
    {
        private int a;
        private int b;
        private int c;
        public TrianglePeg(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int GetSideA()
        {
            return a;
        }
        public int GetSideB()
        {
            return b;
        }
        public int GetSideC()
        {
            return c;
        }
    }
}
