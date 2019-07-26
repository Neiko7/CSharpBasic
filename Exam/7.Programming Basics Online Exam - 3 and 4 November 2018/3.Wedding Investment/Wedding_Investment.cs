using System;


class Wedding_Investment
{
    static void Main()
    {
        string durationOfContract = Console.ReadLine();
        string typeOfContract = Console.ReadLine();
        string dessert = Console.ReadLine();
        double numberOfMonths = double.Parse(Console.ReadLine());

        double sum = 0;
        double totalSum = 0;

        if (durationOfContract == "one")
        {
            if (typeOfContract == "Small")
            {
                sum = 9.98;
            }
            else if (typeOfContract == "Middle")
            {
                sum = 18.99;
            }
            else if (typeOfContract == "Large")
            {
                sum = 25.98;
            }
            else if (typeOfContract == "ExtraLarge")
            {
                sum = 35.99;
            }
        }
        else if (durationOfContract == "two")
        {

            if (typeOfContract == "Small")
            {
                sum = 8.58;
            }
            else if (typeOfContract == "Middle")
            {
                sum = 17.09;
            }
            else if (typeOfContract == "Large")
            {
                sum = 23.59;
            }
            else if (typeOfContract == "ExtraLarge")
            {
                sum = 31.79;
            }
        }

        if (dessert == "yes")
        {
            if (sum <= 10)
            {
                sum += 5.50;
            }
            else if (sum <= 30)
            {
                sum += 4.35;
            }
            else if (sum > 30)
            {
                sum += 3.85;
            }
        }

        totalSum = numberOfMonths * sum;

        if (durationOfContract == "two")
        {
            totalSum = totalSum - ((totalSum * 3.75) / 100);
        }

        Console.WriteLine($"{totalSum:F2} lv.");
    }
}

