using System;

class Program
{
    static void Main()
    {
        double tennisRacket = double.Parse(Console.ReadLine());
        int numberOfTennisRacket = int.Parse(Console.ReadLine());
        int numberOfPairsOfSneakers = int.Parse(Console.ReadLine());

        double priceOfTennisRacket = numberOfTennisRacket * tennisRacket;
        double priceOfPairsOfSneakers = tennisRacket / 6;
        double totalPriceOfSneaker = numberOfPairsOfSneakers * priceOfPairsOfSneakers;
        double priceForOtherEquipment = (priceOfTennisRacket + totalPriceOfSneaker) * 0.2;
        double totalPrice = priceOfTennisRacket + totalPriceOfSneaker + priceForOtherEquipment;
        double priceForDjokovich = totalPrice / 8;
        double priceForSponsors = totalPrice * 7 / 8;

        Console.WriteLine("Price to be paid by Djokovic {0}", Math.Floor(priceForDjokovich));
        Console.WriteLine("Price to be paid by sponsors {0}", Math.Ceiling(priceForSponsors));
    }
}

