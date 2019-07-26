using System;


class Number_Pyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = 1;
        for (int rows = 1; rows <= n; rows++)
        {
            for (int cols = 1; cols <= rows; cols++)
            {
                Console.Write($"{x} ");

                if (x == n)
                {
                    return;
                }
                x++;
            }
            Console.WriteLine();
        }
    }
}
