using System;


class Oscars_Ceremony
{
    static void Main()
    {
        double rentForHall = double.Parse(Console.ReadLine());

        double priceForStatuettes = rentForHall * 0.70;
        double priceForCatering = priceForStatuettes * 0.85;
        double priceForSound = priceForCatering / 2;
        double totalSum = rentForHall + priceForStatuettes + priceForCatering + priceForSound;

        Console.WriteLine($"{totalSum:F2}");


    }
}

