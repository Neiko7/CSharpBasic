using System;

class USDToBGN
{
    static void Main()
    {
        double usd = double.Parse(Console.ReadLine());
        double bgn = usd * 1.79549;
        Math.Round(bgn, 2);

        Console.WriteLine(Math.Round(bgn, 0));
    }
}

