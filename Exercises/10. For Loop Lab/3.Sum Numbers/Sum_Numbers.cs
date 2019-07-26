using System;


class Sum_Numbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= num; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);

    }
}

