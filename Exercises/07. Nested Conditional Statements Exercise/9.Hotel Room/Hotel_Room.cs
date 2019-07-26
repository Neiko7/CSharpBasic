using System;


class Hotel_Room
{
    static void Main()
    {
        string month = Console.ReadLine();
        int numberOfDay = int.Parse(Console.ReadLine());

        double priceOfApartment = 0.0;
        double priceOfStudio = 0.0;

        if (month == "May" || month == "October")
        {
            priceOfApartment = numberOfDay * 65;
            priceOfStudio = numberOfDay * 50;

            if (numberOfDay > 14)
            {
                priceOfApartment *= 0.90;
                priceOfStudio *= 0.70;
            }
            else if (numberOfDay > 7)
            {
                priceOfStudio *= 0.95;
            }
        }
        else if (month == "June" || month == "September")
        {
            priceOfApartment = numberOfDay * 68.70;
            priceOfStudio = numberOfDay * 75.20;

            if (numberOfDay > 14)
            {
                priceOfApartment *= 0.90;
                priceOfStudio *= 0.80;
            }
        }
        else if (month == "July" || month == "August")
        {
            priceOfApartment = numberOfDay * 77;
            priceOfStudio = numberOfDay * 76;

            if (numberOfDay > 14)
            {
                priceOfApartment *= 0.90;
            }
        }

        Console.WriteLine($"Apartment: {priceOfApartment:F2} lv.");
        Console.WriteLine($"Studio: {priceOfStudio:F2} lv.");
    }
}

