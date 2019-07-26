using System;

class Christmas_Gifts
{
    static void Main()
    {
        string command = Console.ReadLine();

        int age = 0;
        int toy = 5;
        int sweaters = 15;

        int counterKids = 0;
        int counterAdults = 0;
        int sumToy = 0;
        int sumSweaters = 0;

        while (command != "Christmas")
        {
            age = int.Parse(command);

            if (age <= 16)
            {
                counterKids++;
                sumToy += toy;
            }
            else if (age > 16)
            {
                counterAdults++;
                sumSweaters += sweaters;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Number of adults: {counterAdults}");
        Console.WriteLine($"Number of kids: {counterKids}");
        Console.WriteLine($"Money for toys: {sumToy}");
        Console.WriteLine($"Money for sweaters: {sumSweaters}");
    }
}

