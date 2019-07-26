using System;


class Happy_Cat_Parking
{
    static void Main()
    {
        int numbersOfDays = int.Parse(Console.ReadLine());
        int numbersOfHours = int.Parse(Console.ReadLine());

        double onHour = 0;
        double totalSum = 0;

        for (int day = 1; day <= numbersOfDays; day++)
        {
            for (int hour = 1; hour <= numbersOfHours; hour++)
            {
                if (day % 2 == 0 && hour % 2 != 0)
                {
                    onHour += 2.50;
                }
                else if (day % 2 != 0 && hour % 2 == 0)
                {
                    onHour += 1.25;
                }
                else
                {
                    onHour += 1;
                }
            }
            totalSum += onHour;
            Console.WriteLine($"Day: {day} - {onHour:F2} leva");
            onHour = 0;
        }

        Console.WriteLine($"Total: {totalSum:F2} leva");
    }
}

