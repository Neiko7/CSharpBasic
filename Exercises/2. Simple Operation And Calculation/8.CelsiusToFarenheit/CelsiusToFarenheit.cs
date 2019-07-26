using System;

class CelsiusToFarenheit
{
    static void Main()
    {
        double celsius = double.Parse(Console.ReadLine());
        double farenheit = celsius * 1.8 + 32; 
        Console.WriteLine("{0:F2}", farenheit);
    }
}

