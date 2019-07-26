using System;


class TailoringWorkshop
{
    static void Main()
    {
        int numberOfTable = int.Parse(Console.ReadLine());
        double lengthOfTable = double.Parse(Console.ReadLine());
        double widthOfTable = double.Parse(Console.ReadLine());

        double tableclothsInGeneral = numberOfTable * (lengthOfTable + 2 * 0.30) * (widthOfTable + 2 * 0.30);
        double carriagesInGeneral = numberOfTable * (lengthOfTable / 2) * (lengthOfTable / 2);

        double priceUsd = tableclothsInGeneral * 7 + carriagesInGeneral * 9;
        double priceBgn = priceUsd * 1.85;

        Console.WriteLine($"{priceUsd:F2} USD");
        Console.WriteLine($"{priceBgn:F2} BGN");
            
    }
}

