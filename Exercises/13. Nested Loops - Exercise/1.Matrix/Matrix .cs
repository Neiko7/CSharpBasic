using System;


class Matrix
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThird = int.Parse(Console.ReadLine());
        int numberFourth = int.Parse(Console.ReadLine());

        for (int a = numberOne; a <= numberTwo; a++)
        {
            for (int b = numberOne; b <= numberTwo; b++)
            {
                for (int c = numberThird; c <= numberFourth; c++)
                {
                    for (int d = numberThird; d <= numberFourth; d++)
                    {
                        int sumOne = a + d;
                        int sumTwo = b + c;

                        if (sumOne == sumTwo && a != b && c != d)
                        {
                            Console.WriteLine($"{a}{b}");
                            Console.WriteLine($"{c}{d}");
                            Console.WriteLine();
                        }
                        
                    }
                }
            }
        }
    }
}

