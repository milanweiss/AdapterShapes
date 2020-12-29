using System;
using AdapterPattern.Adapters;
using AdapterPattern.Shapes;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hole radius");
            int radius = int.Parse(Console.ReadLine());
            RoundHole hole = new RoundHole(radius);
            Console.WriteLine("Radius of hole is " + radius);
            Console.WriteLine();

            Console.WriteLine("Enter circle radius:");

            CirclePeg rPeg = new CirclePeg(int.Parse(Console.ReadLine()));

            if (hole.IsFitting(rPeg))
                Console.WriteLine("Circle with your entered width fits");
            else
                Console.WriteLine("Circle with your entered width doesn't fit");
            Console.WriteLine();

            Console.WriteLine("Enter circle width");

            SquarePeg smallSqPeg = new SquarePeg(int.Parse(Console.ReadLine()));
            /*hole.IsFitting(smallSqPeg)*/      //This won't compile
            SquarePegAdapter smallSqPegAdapter = new SquarePegAdapter(smallSqPeg);

            if (hole.IsFitting(smallSqPegAdapter))
                Console.WriteLine("Square with your entered width fits");
            else
                Console.WriteLine("Square with your entered width doesn't fit");
            Console.WriteLine();

            Console.WriteLine("Enter triangle side lengths");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            TrianglePeg smallTrPeg = new TrianglePeg(a, b, c);
            /*hole.IsFitting(smallTrPeg)*/      //This won't compile
            TrianglePegAdapter smallTrPegAdapter = new TrianglePegAdapter(smallTrPeg);

            if (hole.IsFitting(smallTrPegAdapter))
                Console.WriteLine("Triangle with your entered engths fits");
            else
                Console.WriteLine("Triangle with your entered lengths doesn't fit");


        }
    }
}
