using System;


class Journey
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string typeOfSeeson = Console.ReadLine();

        string destination = string.Empty;
        string typeOfHolidays = string.Empty;
        double amountSpent = 0.0;

        if (budget <= 100)
        {
            if (typeOfSeeson == "summer")
            {
                amountSpent = budget * 0.3;
                destination = "Bulgaria";
                typeOfHolidays = "Camp";
            }
            else if (typeOfSeeson == "winter")
            {
                amountSpent = budget * 0.7;
                destination = "Bulgaria";
                typeOfHolidays = "Hotel";
            }
        }
        else if (budget <= 1000)
        {
            if (typeOfSeeson == "summer")
            {
                amountSpent = budget * 0.4;
                destination = "Balkans";
                typeOfHolidays = "Camp";
            }
            else if (typeOfSeeson == "winter")
            {
                amountSpent = budget * 0.8;
                destination = "Balkans";
                typeOfHolidays = "Hotel";
            }
        }
        else
        {
            amountSpent = budget * 0.9;
            destination = "Europe";
            typeOfHolidays = "Hotel";
        }

        Console.WriteLine("Somewhere in {0}", destination);
        Console.WriteLine("{0} - {1:F2}", typeOfHolidays, amountSpent);

    }
}
