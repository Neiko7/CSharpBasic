using System;

class InchesToCentimeters
{
    static void Main()
    {
        //Console.Write("Enter inches: ");
        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;

        Console.WriteLine("{0:F2}", centimeters);
    }
}

