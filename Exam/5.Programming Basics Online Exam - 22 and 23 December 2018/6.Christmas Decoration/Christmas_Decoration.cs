using System;


class Christmas_Decoration
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int sum = 0;
        int totalSum = 0;
        int diff = 0;

        while (command != "Stop")
        {
            int nameOfObject = command.Length;

            for (int i = 0; i < nameOfObject; i++)
            {
                sum += command[i];
            }

            if (totalSum + sum <= budget)
            {
                totalSum += sum;
                Console.WriteLine("Item successfully purchased!");
            }
            else if (totalSum + sum > budget)
            {
                Console.WriteLine("Not enough money!");
                return;
            }

            command = Console.ReadLine();
            sum = 0;
        }

        diff = budget - totalSum;
        Console.WriteLine($"Money left: {diff}");

    }
}

