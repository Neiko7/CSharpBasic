using System;


class Program
{
    static void Main()
    {
        string stageOfChampionship = Console.ReadLine();
        string typeOfTicket = Console.ReadLine();
        int numberOfTicket = int.Parse(Console.ReadLine());
        char photoWithTheTrophy = char.Parse(Console.ReadLine());

        double priceOfTicket = 0;
        double totalPriceOfPhotoWithTheTrophy = 0;
        double totalPriceOfTickets = 0;

        if (stageOfChampionship == "Quarter final")
        {
            if (typeOfTicket == "Standard")
            {
                priceOfTicket = 55.50;
            }
            else if (typeOfTicket == "Premium")
            {
                priceOfTicket = 105.20;
            }
            else if (typeOfTicket == "VIP")
            {
                priceOfTicket = 118.90;
            }
        }
        else if (stageOfChampionship == "Semi final")
        {
            if (typeOfTicket == "Standard")
            {
                priceOfTicket = 75.88;
            }
            else if (typeOfTicket == "Premium")
            {
                priceOfTicket = 125.22;
            }
            else if (typeOfTicket == "VIP")
            {
                priceOfTicket = 300.40;
            }
        }
        else if (stageOfChampionship == "Final")
        {
            if (typeOfTicket == "Standard")
            {
                priceOfTicket = 110.10;
            }
            else if (typeOfTicket == "Premium")
            {
                priceOfTicket = 160.66;
            }
            else if (typeOfTicket == "VIP")
            {
                priceOfTicket = 400.00;
            }
        }

        totalPriceOfTickets = numberOfTicket * priceOfTicket;

        if (totalPriceOfTickets > 4000)
        {
            totalPriceOfTickets *= 0.75;
        }
        else if (totalPriceOfTickets > 2500)
        {
            totalPriceOfTickets *= 0.90;

            if (photoWithTheTrophy == 'Y')
            {
                totalPriceOfPhotoWithTheTrophy = numberOfTicket * 40;
                totalPriceOfTickets = totalPriceOfTickets + totalPriceOfPhotoWithTheTrophy;
            }

        }
        else if (photoWithTheTrophy == 'Y')
        {
            totalPriceOfPhotoWithTheTrophy = numberOfTicket * 40;
            totalPriceOfTickets = totalPriceOfTickets + totalPriceOfPhotoWithTheTrophy;
        }
        


        Console.WriteLine($"{totalPriceOfTickets:F2}");
    }
}
