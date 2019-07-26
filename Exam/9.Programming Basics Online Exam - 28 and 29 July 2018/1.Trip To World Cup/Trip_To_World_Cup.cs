using System;


class Trip_To_World_Cup
{
    static void Main()
    {
        double priceOfTicketToGo = double.Parse(Console.ReadLine());
        double priceOfTichetReturn = double.Parse(Console.ReadLine());
        double ticketPricePerMatch = double.Parse(Console.ReadLine());
        int numberOfMatch = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double amountOfAircraftTickets = 6 * (priceOfTicketToGo + priceOfTichetReturn);
        double airlineTicketAfterDiscount = amountOfAircraftTickets - ((amountOfAircraftTickets * discount) / 100);
        double totalSumForTickets = 6 * numberOfMatch * ticketPricePerMatch;
        double totalSum = airlineTicketAfterDiscount + totalSumForTickets;
        double sumForOneFriends = totalSum / 6;

        Console.WriteLine($"Total sum: {totalSum:F2} lv.");
        Console.WriteLine($"Each friend has to pay {sumForOneFriends:F2} lv.");
    }
}

