using System;

class CirleAreaAndPerimeter
{ 
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        //Console.WriteLine("Area is: {0:F2}", area);
        //Console.WriteLine("Perimeter is: {0:F2}", perimeter);
        Console.WriteLine("{0:F2}", area);
        Console.WriteLine("{0:F2}", perimeter);
    }
}
