using System;

class SquareArea
{
    static void Main()
    {
        //Console.Write("Enter side: ");
        int side = int.Parse(Console.ReadLine());
        int area = side * side;

        //Console.WriteLine("Area is: {0}", area);
        Console.WriteLine(area);
    }
}
