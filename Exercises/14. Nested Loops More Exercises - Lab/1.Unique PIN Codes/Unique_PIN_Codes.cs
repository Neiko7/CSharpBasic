using System;


class Unique_PIN_Codes
{
    static void Main()
    {
        int numA = int.Parse(Console.ReadLine());
        int numB = int.Parse(Console.ReadLine());
        int numC = int.Parse(Console.ReadLine());

        for (int a = 2; a <= numA; a += 2)
        {
            for (int b = 2; b <= numB; b++)
            {
                for (int c = 2; c <= numC; c += 2)
                {
                    if (b == 2 || b == 3 || b == 5 || b == 7)
                    {
                        Console.WriteLine($"{a} {b} {c}");
                    }
                }
            }
        }
    }
}

