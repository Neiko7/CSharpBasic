using System;


class RadiantToDegrees
{
    static void Main()
    {
        double radiant = double.Parse(Console.ReadLine());
        double degrees = radiant * 180 / Math.PI;

        Console.WriteLine(Math.Round(degrees, 0));
    }
}

