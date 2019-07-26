using System;


class Sushi_Time
{
    static void Main()
    {
        string typeSushi = Console.ReadLine();
        string nameOfRestaurant = Console.ReadLine();
        int numberOfPortions = int.Parse(Console.ReadLine());
        char order = char.Parse(Console.ReadLine());

        double sumForOrder = 0;

        if (nameOfRestaurant == "Sushi Zone")
        {
            if (typeSushi == "sashimi")
            {
                sumForOrder = numberOfPortions * 4.99;
            }
            else if (typeSushi == "maki")
            {
                sumForOrder = numberOfPortions * 5.29;
            }
            else if (typeSushi == "uramaki")
            {
                sumForOrder = numberOfPortions * 5.99;
            }
            else if (typeSushi == "temaki")
            {
                sumForOrder = numberOfPortions * 4.29;
            }
        }
        else if (nameOfRestaurant == "Sushi Time")
        {
            if (typeSushi == "sashimi")
            {
                sumForOrder = numberOfPortions * 5.49;
            }
            else if (typeSushi == "maki")
            {
                sumForOrder = numberOfPortions * 4.69;
            }
            else if (typeSushi == "uramaki")
            {
                sumForOrder = numberOfPortions * 4.49;
            }
            else if (typeSushi == "temaki")
            {
                sumForOrder = numberOfPortions * 5.19;
            }
        }
        else if (nameOfRestaurant == "Sushi Bar")
        {
            if (typeSushi == "sashimi")
            {
                sumForOrder = numberOfPortions * 5.25;
            }
            else if (typeSushi == "maki")
            {
                sumForOrder = numberOfPortions * 5.55;
            }
            else if (typeSushi == "uramaki")
            {
                sumForOrder = numberOfPortions * 6.25;
            }
            else if (typeSushi == "temaki")
            {
                sumForOrder = numberOfPortions * 4.75;
            }
        }
        else if (nameOfRestaurant == "Asian Pub")
        {
            if (typeSushi == "sashimi")
            {
                sumForOrder = numberOfPortions * 4.50;
            }
            else if (typeSushi == "maki")
            {
                sumForOrder = numberOfPortions * 4.80;
            }
            else if (typeSushi == "uramaki")
            {
                sumForOrder = numberOfPortions * 5.50;
            }
            else if (typeSushi == "temaki")
            {
                sumForOrder = numberOfPortions * 5.50;
            }
        }
        else
        {
            Console.WriteLine($"{nameOfRestaurant} is invalid restaurant!");
            return;
        }


        if (order == 'Y')
        {
            sumForOrder *= 1.20;
        }

        sumForOrder = Math.Ceiling(sumForOrder);
        Console.WriteLine($"Total price: {sumForOrder} lv.");
    }
}

