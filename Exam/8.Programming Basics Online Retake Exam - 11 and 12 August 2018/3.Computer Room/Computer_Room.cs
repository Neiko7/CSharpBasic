using System;

class Computer_Room
{
    static void Main()
    {
        string month = Console.ReadLine();
        int numberOfHoursSpent = int.Parse(Console.ReadLine());
        int numberOfPeopleInGroup = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        double sum = 0;
        double totalSum = 0;

        if (timeOfDay == "day")
        {
            if (month == "march" || month == "april" || month == "may")
            {
                sum = 10.50;
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                sum = 12.60;
            }
        }
        else if (timeOfDay == "night")
        {
            if (month == "march" || month == "april" || month == "may")
            {
                sum = 8.40;
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                sum = 10.20;
            }
        }

        if (numberOfPeopleInGroup >= 4)
        {
            sum *= 0.90;
        }

        if (numberOfHoursSpent >= 5)
        {
            sum *= 0.50;
        }

        totalSum = (sum * numberOfPeopleInGroup) * numberOfHoursSpent;

        Console.WriteLine($"Price per person for one hour: {sum:F2}");
        Console.WriteLine($"Total cost of the visit: {totalSum:F2}");
    }
}

