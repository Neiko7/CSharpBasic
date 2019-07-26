using System;

namespace Retangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine();
            double y1 = double.Parse(Console.ReadLine();
            double x2 = double.Parse(Console.ReadLine();
            double y2 = double.Parse(Console.ReadLine();

            double sizeA = x1 - x2;
            double sizeB = y1 - y2;

            double area = sizeA * sizeB;
            double perimeter = 2 * (sizeA + sizeB);

            Console.WriteLine("{area:2}");
        }
    }
}
