using System;


class Small_Shop
{
    static void Main()
    {
        string productName = Console.ReadLine();
        string city = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0.0;

        double coffeePriceInSofia = 0.50;
        double waterPriceInSofia = 0.80;
        double beerPriceInSofia = 1.20;
        double sweetsPriceInSofia = 1.45;
        double peanutsPriceInSofia = 1.60;

        double coffeePriceInPlovdiv = 0.40;
        double waterPriceInPlovdiv = 0.70;
        double beerPriceInPlovdiv = 1.15;
        double sweetsPriceInPlovdiv = 1.30;
        double peanutsPriceInPlovdiv = 1.50;

        double coffeePriceInVarna = 0.45;
        double waterPriceInVarna = 0.70;
        double beerPriceInVarna = 1.10;
        double sweetsPriceInVarna = 1.35;
        double peanutsPriceInVarna = 1.55;

        if (city == "Sofia")
        {
            if (productName == "coffee")
            {
                price = quantity * coffeePriceInSofia;
                Console.WriteLine(price);
            }
            else if (productName == "water")
            {
                price = quantity * waterPriceInSofia;
                Console.WriteLine(price);
            }
            else if (productName == "beer")
            {
                price = quantity * beerPriceInSofia;
                Console.WriteLine(price);
            }
            else if (productName == "sweets")
            {
                price = quantity * sweetsPriceInSofia;
                Console.WriteLine(price);
            }
            else if (productName == "peanuts")
            {
                price = quantity * peanutsPriceInSofia;
                Console.WriteLine(price);
            }
        }
        else if (city == "Plovdiv")
        {
            if (productName == "coffee")
            {
                price = quantity * coffeePriceInPlovdiv;
                Console.WriteLine(price);
            }
            else if (productName == "water")
            {
                price = quantity * waterPriceInPlovdiv;
                Console.WriteLine(price);
            }
            else if (productName == "beer")
            {
                price = quantity * beerPriceInPlovdiv;
                Console.WriteLine(price);
            }
            else if (productName == "sweets")
            {
                price = quantity * sweetsPriceInPlovdiv;
                Console.WriteLine(price);
            }
            else if (productName == "peanuts")
            {
                price = quantity * peanutsPriceInPlovdiv;
                Console.WriteLine(price);
            }
        }
        else if (city == "Varna")
        {
            if (productName == "coffee")
            {
                price = quantity * coffeePriceInVarna;
                Console.WriteLine(price);
            }
            else if (productName == "water")
            {
                price = quantity * waterPriceInVarna;
                Console.WriteLine(price);
            }
            else if (productName == "beer")
            {
                price = quantity * beerPriceInVarna;
                Console.WriteLine(price);
            }
            else if (productName == "sweets")
            {
                price = quantity * sweetsPriceInVarna;
                Console.WriteLine(price);
            }
            else if (productName == "peanuts")
            {
                price = quantity * peanutsPriceInVarna;
                Console.WriteLine(price);
            }
        }





    }
}

