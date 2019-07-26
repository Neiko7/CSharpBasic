using System;

class Energy_Booster
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string size = Console.ReadLine();
        int orderNumber = int.Parse(Console.ReadLine());

        double sum = 0;

        if (size == "small")
        {
            if (fruit == "Watermelon")
            {
                sum = 2 * orderNumber * 56;
            }
            else if (fruit == "Mango")
            {
                sum = 2 * orderNumber * 36.66;
            }
            else if (fruit == "Pineapple")
            {
                sum = 2 * orderNumber * 42.10;
            }
            else if (fruit == "Raspberry")
            {
                sum = 2 * orderNumber * 20;
            }
        }
        else if (size == "big")
        {
            if (fruit == "Watermelon")
            {
                sum = 5 * orderNumber * 28.70;
            }
            else if (fruit == "Mango")
            {
                sum = 5 * orderNumber * 19.60;
            }
            else if (fruit == "Pineapple")
            {
                sum = 5 * orderNumber * 24.80;
            }
            else if (fruit == "Raspberry")
            {
                sum = 5 * orderNumber * 15.20;
            }
        }

        if (sum >= 400 && sum <= 1000)
        {
            sum *= 0.85;
        }
        else if (sum > 1000)
        {
            sum *= 0.50;
        }

        Console.WriteLine($"{sum:F2} lv.");
    }
}

