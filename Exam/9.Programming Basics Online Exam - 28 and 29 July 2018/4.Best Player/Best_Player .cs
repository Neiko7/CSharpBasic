using System;


class Best_Player 
{
    static void Main()
    {
        string nameOfPlayer = string.Empty;
        string bestPlayer = string.Empty;
        int maxGoals = int.MinValue;

        while ((nameOfPlayer = Console.ReadLine()) != "END")
        {
            int numberOfGoalsScored = int.Parse(Console.ReadLine());

            if (numberOfGoalsScored > maxGoals)
            {
                maxGoals = numberOfGoalsScored;
                bestPlayer = nameOfPlayer;
            }

            if (numberOfGoalsScored >= 10)
            {
                break;
            }
        }

        Console.WriteLine($"{bestPlayer} is the best player!");

        if (maxGoals < 3)
        {
            Console.WriteLine($"He has scored {maxGoals} goals.");
        }
        else
        {
            Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
        }
    }
}

