using System;

class Easter_Eggs_Battle
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());

        string winner = string.Empty;
                
        while ((winner = Console.ReadLine()) != "End of battle")
        {
            if (winner == "one")
            {
                secondPlayer--;

                if (secondPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayer} eggs left.");
                    return;
                }
            }
            else if (winner == "two")
            {
                firstPlayer--;

                if (firstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayer} eggs left.");
                    return;
                }
            }
        }

        Console.WriteLine($"Player one has {firstPlayer} eggs left.");
        Console.WriteLine($"Player two has {secondPlayer} eggs left.");
    }
}
