using System;


class Min_Number
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int min = int.MaxValue;
        int number = 0;

        while (counter < n)
        {
            number = int.Parse(Console.ReadLine());

            if (number <= min)
            {
                min = number;
            }
            counter++;
        }

        Console.WriteLine(min);
    }
}
