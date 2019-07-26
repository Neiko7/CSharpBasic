using System;


class The_Song_Of_The_Wheels
{
    static void Main()
    {
        int controlNumber = int.Parse(Console.ReadLine());

        bool isTrue = false;
        int counter = 0;
        int firstDigit = 0;
        int secondDigit = 0;
        int thirdDigit = 0;
        int fourtDigit = 0;

        for (int a = 1; a <= 9; a++)
        {
            for (int b = 1; b <= 9; b++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    for (int d = 1; d <= 9; d++)
                    {
                        if (a < b && c > d)
                        {
                            if (((a * b) + (c * d)) == controlNumber)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                counter++;

                                if (counter == 4)
                                {
                                    isTrue = true;
                                    firstDigit = a;
                                    secondDigit = b;
                                    thirdDigit = c;
                                    fourtDigit = d;
                                }
                            }
                        }

                    }
                }
            }
        }
        Console.WriteLine();

        if (isTrue)
        {
            Console.WriteLine($"Password: {firstDigit}{secondDigit}{thirdDigit}{fourtDigit}");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}

