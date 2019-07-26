using System;


class Coding
{
    static void Main()
    {
        string number = Console.ReadLine();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            char symbol = number[i];
            int num = int.Parse(symbol.ToString());

            if (symbol == '0')
            {
                Console.WriteLine("ZERO");
            }
            else
            {
                for (int j = 1; j <= num; j++)
                {
                    int symbolPlus = num + 33;
                    Console.Write($"{(char)symbolPlus}");
                }
                Console.WriteLine();
            }
        }
    }
}

