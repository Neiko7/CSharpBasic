using System;

class Even_Powers_Of_2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i += 2)
        {
            Console.WriteLine(Math.Pow(2, i));
        }
    }
}

