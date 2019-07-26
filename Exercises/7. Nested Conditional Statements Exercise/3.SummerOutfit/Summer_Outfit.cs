using System;


class Summer_Outfit
{
    static void Main()
    {
        int degreeCelsius = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        string outfit = string.Empty;
        string shoes = string.Empty;

        if (degreeCelsius >= 10 && degreeCelsius <= 18)
        {
            if (timeOfDay == "Morning")
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
        else if (degreeCelsius > 18 && degreeCelsius <= 24)
        {
            if (timeOfDay == "Morning" || timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (timeOfDay == "Afternoon")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
        }
        else if (degreeCelsius >= 25)
        {
            if (timeOfDay == "Morning")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (timeOfDay == "Afternoon")
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
            else if (timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }

        Console.WriteLine($"It's {degreeCelsius} degrees, get your {outfit} and {shoes}.");
    }
}

