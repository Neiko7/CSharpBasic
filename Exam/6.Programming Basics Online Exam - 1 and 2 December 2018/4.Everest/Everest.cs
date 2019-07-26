using System;

class Everest
{
    static void Main()
    {
        string command = Console.ReadLine();

        int sum = 5364;
        int counter = 1;

        while (command != "END")
        {
            int climbedMeters = int.Parse(Console.ReadLine());

            if (command == "Yes")
            {
                counter++;
            }
            

            if (counter > 5)
            {
                break;
            }
            else
            {
                sum += climbedMeters;
            }

            if (sum >= 8848)
            {
                break;
            }

            command = Console.ReadLine();
        }

        if (sum >= 8848)
        {
            Console.WriteLine($"Goal reached for {counter} days!");
        }
        else
        {
            Console.WriteLine("Failed!");
            Console.WriteLine($"{sum}");
        }

    }
}
