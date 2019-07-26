using System;

class RetangleArea
{
    static void Main()
    {
        Console.Write("Size a: ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Size b: ");
        var b = double.Parse(Console.ReadLine());

        double area = a * b;
        Console.WriteLine("Area: " + area);
    }
}

