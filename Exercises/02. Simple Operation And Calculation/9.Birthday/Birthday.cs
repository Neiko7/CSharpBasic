using System;


class Birthday
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double wigth = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());
        double capaciiy = length * wigth * heigth;
        double liters = capaciiy * 0.001;
        double calculatedPercent = percent * 0.01;
        double litersNeeded = liters * (1 - calculatedPercent);
        Console.WriteLine("{0:F3}", litersNeeded);
    }
}

