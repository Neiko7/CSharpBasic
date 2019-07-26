using System;


class Substitute
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int firstDigit = k; firstDigit <= 8; firstDigit++)
        {
            for (int secondDigit = 9; secondDigit >= l; secondDigit--)
            {
                for (int thirdDigit = m; thirdDigit <= 8; thirdDigit++)
                {
                    for (int fourthDigit = 9; fourthDigit >= n; fourthDigit--)
                    {
                        if (firstDigit % 2 == 0 && secondDigit % 2 != 0 && thirdDigit % 2 == 0 && fourthDigit % 2 != 0)
                        {
                            if (firstDigit == thirdDigit && secondDigit == fourthDigit)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else
                            {
                                counter++;
                                Console.WriteLine($"{firstDigit}{secondDigit} - {thirdDigit}{fourthDigit}");
                            }
                        }
                        

                        if (counter == 6)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}

