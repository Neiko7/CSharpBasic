using System;


class Building
{
    static void Main()
    {
        int floor = int.Parse(Console.ReadLine());
        int office = int.Parse(Console.ReadLine());


        for (int x = floor; x >= 1; x--)
        {
            for (int y = 0; y < office; y++)
            {
                if (x == floor)
                {
                    Console.Write($"L{x}{y} ");
                }
                else if (x % 2 == 0)
                {
                    Console.Write($"O{x}{y} ");
                }
                else
                {
                    Console.Write($"A{x}{y} ");
                }
            }
            Console.WriteLine();
        }
    }
}

