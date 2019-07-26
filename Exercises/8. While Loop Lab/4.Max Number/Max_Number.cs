using System;


class Max_Number
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int max = int.MinValue;
        int number = 0;

        while (counter < n)
        {
            number = int.Parse(Console.ReadLine());

            if (number >= max)
            {
                max = number;
            }
            

            counter++;
        }

        Console.WriteLine(max);
    }
}

