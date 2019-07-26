using System;


class Safe_Passwords_Generator
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int maxNumberPassword = int.Parse(Console.ReadLine());
        int x = 35;
        int y = 64;

        int counter = 0;

        for (int e = 1; e <= a; e++)
        {
            for (int d = 1; d <= b; d++)
            {
                Console.Write($"{(char)x}{(char)y}{e}{d}{(char)y++}{(char)x++}|");

                if (e == a && d == b)
                {
                    return;
                }

                counter++;

                if (counter == maxNumberPassword)
                {
                    return;
                }

                if (x > 55)
                {
                    x = 35;
                }
                if (y > 96)
                {
                    y = 64;
                }

            }

        }
    }
}

