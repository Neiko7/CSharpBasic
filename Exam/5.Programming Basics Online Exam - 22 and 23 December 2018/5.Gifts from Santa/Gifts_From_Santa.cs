using System;


class Gifts_From_Santa
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numM = int.Parse(Console.ReadLine());
        int numS = int.Parse(Console.ReadLine());
               
        for (int i = numM; i >= numN; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == numS)
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        return;
                    }
                }

                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();

    }
}

