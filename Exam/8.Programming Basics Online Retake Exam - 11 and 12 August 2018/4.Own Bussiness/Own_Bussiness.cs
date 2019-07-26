using System;


class Own_Bussiness
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int heigth = int.Parse(Console.ReadLine());

        int numOfComputers = 0;
        int sumOfSpaceForComputers = 0;
        int diff = 0;

        int freeSpace = width * length * heigth;

        string command = Console.ReadLine();

        while (command != "Done")
        {
            numOfComputers = int.Parse(command);
            sumOfSpaceForComputers += numOfComputers;

            if (sumOfSpaceForComputers > freeSpace)
            {
                break;
            }

            command = Console.ReadLine();
        }

        diff = Math.Abs(freeSpace - sumOfSpaceForComputers);

        if (command == "Done")
        {
            Console.WriteLine($"{diff} Cubic meters left.");
        }
        else
        {
            Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
        }
    }
}

