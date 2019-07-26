using System;


class Fruit_Shop
{
    static void Main()
    {
        string fruit = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0.0;

        double bananaPriceInWorkingDay = 2.50;
        double applePriceInWorkingDay = 1.20;
        double orangePriceInworkingDay = 0.85;
        double grapefruitPriceInWorkingDay = 1.45;
        double kiwiPriceInWoringDay = 2.70;
        double pineapplePriceInWorkingDay = 5.50;
        double grapesPriceInWorkingDay = 3.85;

        double bananaPriceInDayOff = 2.70;
        double applePriceInDayOff = 1.25;
        double orangePriceInDayOff = 0.90;
        double grapefruitPriceInDayOff = 1.60;
        double kiwiPriceIngDayOff = 3.00;
        double pineapplePriceInDayOff = 5.60;
        double grapesPriceInDayOff = 4.20;




        if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
        {
            if (fruit == "banana")
            {
                price = quantity * bananaPriceInWorkingDay;
            }
            else if (fruit == "apple")
            {
                price = quantity * applePriceInWorkingDay;
            }
            else if (fruit == "orange")
            {
                price = quantity * orangePriceInworkingDay;
            }
            else if (fruit == "grapefruit")
            {
                price = quantity * grapefruitPriceInWorkingDay;
            }
            else if (fruit == "kiwi")
            {
                price = quantity * kiwiPriceInWoringDay;
            }
            else if (fruit == "pineapple")
            {
                price = quantity * pineapplePriceInWorkingDay;
            }
            else if (fruit == "grapes")
            {
                price = quantity * grapesPriceInWorkingDay;
            }
        }
        else if (day == "saturday" || day == "sunday")
        {
            if (fruit == "banana")
            {
                price = quantity * bananaPriceInDayOff;
            }
            else if (fruit == "apple")
            {
                price = quantity * applePriceInDayOff;
            }
            else if (fruit == "orange")
            {
                price = quantity * orangePriceInDayOff;
            }
            else if (fruit == "grapefruit")
            {
                price = quantity * grapefruitPriceInDayOff;
            }
            else if (fruit == "kiwi")
            {
                price = quantity * kiwiPriceIngDayOff;
            }
            else if (fruit == "pineapple")
            {
                price = quantity * pineapplePriceInDayOff;
            }
            else if (fruit == "grapes")
            {
                price = quantity * grapesPriceInDayOff;

            }
        }

        if (price > 0)
        {
            Console.WriteLine($"{price:F2}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

