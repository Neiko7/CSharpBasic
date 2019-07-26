using System;

class Sequence_2k_Plus_1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int k = 1;

        while (k <= n)
        {
            Console.WriteLine(k);
            k = k * 2 + 1;
        }
    }
}

