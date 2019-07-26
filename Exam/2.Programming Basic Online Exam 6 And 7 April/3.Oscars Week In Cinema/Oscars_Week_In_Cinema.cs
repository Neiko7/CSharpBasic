using System;


class Oscars_Week_In_Cinema
{
    static void Main()
    {
        string nameOfMovie = Console.ReadLine();
        string typeOfHall = Console.ReadLine();
        int numberOfTicketsPurchased = int.Parse(Console.ReadLine());
        double totalSum = 0;

        if (nameOfMovie == "A Star Is Born")
        {
            if (typeOfHall == "normal")
            {
                totalSum = numberOfTicketsPurchased * 7.50;
            }
            else if (typeOfHall == "luxury")
            {
                totalSum = numberOfTicketsPurchased * 10.50;
            }
            else if (typeOfHall == "ultra luxury")
            {
                totalSum = numberOfTicketsPurchased * 13.50;
            }
        }
        else if (nameOfMovie == "Bohemian Rhapsody")
        {
            if (typeOfHall == "normal")
            {
                totalSum = numberOfTicketsPurchased * 7.35;
            }
            else if (typeOfHall == "luxury")
            {
                totalSum = numberOfTicketsPurchased * 9.45;
            }
            else if (typeOfHall == "ultra luxury")
            {
                totalSum = numberOfTicketsPurchased * 12.75;
            }
        }
        else if (nameOfMovie == "Green Book")
        {
            if (typeOfHall == "normal")
            {
                totalSum = numberOfTicketsPurchased * 8.15;
            }
            else if (typeOfHall == "luxury")
            {
                totalSum = numberOfTicketsPurchased * 10.25;
            }
            else if (typeOfHall == "ultra luxury")
            {
                totalSum = numberOfTicketsPurchased * 13.25;
            }
        }
        else if (nameOfMovie == "The Favourite")
        {
            if (typeOfHall == "normal")
            {
                totalSum = numberOfTicketsPurchased * 8.75;
            }
            else if (typeOfHall == "luxury")
            {
                totalSum = numberOfTicketsPurchased * 11.55;
            }
            else if (typeOfHall == "ultra luxury")
            {
                totalSum = numberOfTicketsPurchased * 13.95;
            }
        }

        Console.WriteLine($"{nameOfMovie} -> {totalSum:F2} lv.");
    }
}
