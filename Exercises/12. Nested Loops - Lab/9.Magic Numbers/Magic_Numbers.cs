using System;


class Magic_Numbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int oneDigit = 1; oneDigit <= 9; oneDigit++)
        {
            for (int twoDigit = 1; twoDigit <= 9; twoDigit++)
            {
                for (int thirdDidgit = 1; thirdDidgit <= 9; thirdDidgit++)
                {
                    for (int fourthDigit = 1; fourthDigit <= 9; fourthDigit++)
                    {
                        for (int fifthDigit = 1; fifthDigit <= 9; fifthDigit++)
                        {
                            for (int sixthDigit = 1; sixthDigit <= 9; sixthDigit++)
                            {
                                int sum = oneDigit * twoDigit * thirdDidgit * fourthDigit * fifthDigit * sixthDigit;

                                if (number == sum)
                                {
                                    Console.Write($"{oneDigit}{twoDigit}{thirdDidgit}{fourthDigit}{fifthDigit}{sixthDigit} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}

