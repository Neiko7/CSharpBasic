using System;


class Stadium_Income
{
    static void Main()
    {
        int numberOfSectors = int.Parse(Console.ReadLine());
        int capacityOfStadion = int.Parse(Console.ReadLine());
        double priceOfOneTicket = double.Parse(Console.ReadLine());

        double revenueForOneSector = (capacityOfStadion * priceOfOneTicket) / numberOfSectors;
        double totalSum = revenueForOneSector * numberOfSectors;
        double charity = (totalSum - revenueForOneSector * 0.75) / 8;

        Console.WriteLine($"Total income - {totalSum:F2} BGN");
        Console.WriteLine($"Money for charity - {charity:F2} BGN");
    }
}

