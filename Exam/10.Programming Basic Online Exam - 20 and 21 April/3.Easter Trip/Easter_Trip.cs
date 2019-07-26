using System;

class Easter_Trip
{
    static void Main()
    {
        string destination = Console.ReadLine();
        string date = Console.ReadLine();
        int numberOfNights = int.Parse(Console.ReadLine());

        double price = 0.0;
        double totalPrice = 0.0;

        if (destination == "France")
        {
            if (date == "21-23")
            {
                price = 30;
            }
            else if (date == "24-27")
            {
                price = 35;
            }
            else if (date == "28-31")
            {
                price = 40;
            }
        }
        else if (destination == "Italy")
        {
            if (date == "21-23")
            {
                price = 28;
            }
            else if (date == "24-27")
            {
                price = 32;
            }
            else if (date == "28-31")
            {
                price = 39;
            }
        }
        else if (destination == "Germany")
        {
            if (date == "21-23")
            {
                price = 32;
            }
            else if (date == "24-27")
            {
                price = 37;
            }
            else if (date == "28-31")
            {
                price = 43;
            }
        }

        totalPrice = numberOfNights * price;

        Console.WriteLine($"Easter trip to {destination} : {totalPrice:F2} leva.");
    }
}

