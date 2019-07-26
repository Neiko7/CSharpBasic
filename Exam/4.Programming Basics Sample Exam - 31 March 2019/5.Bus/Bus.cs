using System;


class Bus
{
    static void Main()
    {
        int numberOfPassengers = int.Parse(Console.ReadLine());
        int numberOfStops = int.Parse(Console.ReadLine());

        int down = 0;
        int up = 0;
        int passengers = 0;

        for (int i = 1; i <= numberOfStops; i++)
        {
            down = int.Parse(Console.ReadLine());
            up = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                passengers = numberOfPassengers - down + up + 2;
            }
            else if (i % 2 == 0)
            {
                passengers = passengers - down + up - 2;
            }
            else
            {
                passengers = passengers - down + up + 2;
            }

        }

        Console.WriteLine($"The final number of passengers is : {passengers}");
    }
}

