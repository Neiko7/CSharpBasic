using System;


class Math_Puzzle
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        bool logicOne = true;
        bool logicTwo = true;


        for (int a = 1; a <= 30; a++)
        {
            for (int b = 1; b <= 30; b++)
            {
                for (int c = 1; c <= 30; c++)
                {
                    int sum = a + b + c;
                    int multiplier = a * b * c;

                    if (num == sum)
                    {
                        if (a < b && b < c)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {num}");
                            logicOne = false;
                        }
                    }

                    if(num == multiplier)
                    { 
                        if (a > b && b > c)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {multiplier}");
                            logicTwo = false;
                        }

                    }
                }

            }

        }
                
        if (logicOne && logicTwo)
            Console.WriteLine("No!");

    }
}
