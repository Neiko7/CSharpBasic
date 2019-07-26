using System;


class Game_Statistics
{
    static void Main()
    {
        int minutes = int.Parse(Console.ReadLine());
        string nameOfPlayer = Console.ReadLine();

        if (minutes == 0)
        {
            Console.WriteLine("Match has just began!");
        }
        else if (minutes < 45)
        {
            Console.WriteLine("First half time.");
        }
        else if (minutes >= 45)
        {
            Console.WriteLine("Second half time.");
        }

        if (minutes > 1 && minutes <= 10)
        {
            Console.WriteLine($"{nameOfPlayer} missed a penalty.");

            if (minutes % 2 == 0)
            {
                Console.WriteLine($"{nameOfPlayer} was injured after the penalty.");
            }
        }
        else if (minutes > 10 && minutes <= 35)
        {
            Console.WriteLine($"{nameOfPlayer} received yellow card.");

            if (minutes % 2 != 0)
            {
                Console.WriteLine($"{nameOfPlayer} got another yellow card.");
            }
        }
        else if (minutes > 35 & minutes < 45)
        {
            Console.WriteLine($"{nameOfPlayer} SCORED A GOAL !!!");
        }
        else if (minutes > 45 && minutes <= 55)
        {
            Console.WriteLine($"{nameOfPlayer} got a freekick.");

            if (minutes % 2 == 0)
            {
                Console.WriteLine($"{nameOfPlayer} missed the freekick.");
            }
        }
        else if (minutes > 55 && minutes <= 80)
        {
            Console.WriteLine($"{nameOfPlayer} missed a shot from corner.");

            if (minutes % 2 != 0)
            {
                Console.WriteLine($"{nameOfPlayer} has been changed with another player.");
            }
        }
        else if (minutes > 80 && minutes <= 90)
        {
            Console.WriteLine($"{nameOfPlayer} SCORED A GOAL FROM PENALTY !!!");
        }


    }
}
