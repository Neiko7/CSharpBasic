using System;


class Fishing_Boat
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        double numberOfFishermen = double.Parse(Console.ReadLine());

        //double rentingTheShipInTheSpring = 3000.00;
        //double rentingTheShipInTheSummerAndAutumn = 4200.00;
        //double rentingTheShipInTheWinter = 2600.00;

        double price = 0.0;
        double totalPrice = 0.0;

        if (season == "Spring")
        {
            if (numberOfFishermen <= 6)
            {
                price = 3000 * 0.90;
            }
            else if (numberOfFishermen <= 11)
            {
                price = 3000 * 0.85;
            }
            else if (numberOfFishermen > 12)
            {
                price = 3000 * 0.75;
            }
        }
        else if (season == "Summer" || season == "Autumn")
        {
            if (numberOfFishermen <= 6)
            {
                price = 4200 * 0.90;
            }
            else if (numberOfFishermen <= 11)
            {
                price = 4200 * 0.85;
            }
            else if (numberOfFishermen > 12)
            {
                price = 4200 * 0.75;
            }
        }
        else if (season == "Winter")
        {
            if (numberOfFishermen <= 6)
            {
                price = 2600 * 0.90;
            }
            else if (numberOfFishermen <= 11)
            {
                price = 2600 * 0.85;
            }
            else if (numberOfFishermen > 12)
            {
                price = 2600 * 0.75;
            }

        }

        if (numberOfFishermen % 2 == 0 && season != "Autumn")
        {
            totalPrice = price - (price * 0.05);
        }
        else
        {
            totalPrice = price;
        }

        if (budget >= totalPrice)
        {
            Console.WriteLine("Yes! You have {0:F2} leva left.", budget - totalPrice);
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:F2} leva.", totalPrice - budget);
        }
    }
}

