using System;


class Ticket_Combination
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int counter = 0;
        int sumCombination = 0;

        for (int symbolOne = 'B'; symbolOne <= 'L'; symbolOne += 2)
        {
            for (int symbolTwo = 'f'; symbolTwo >= 'a'; symbolTwo--)
            {
                for (int symbolThird = 'A'; symbolThird <= 'C'; symbolThird++)
                {
                    for (int symbolFourt = 1; symbolFourt <= 10; symbolFourt++)
                    {
                        for (int symbolFifth = 10; symbolFifth >= 1; symbolFifth--)
                        {
                            counter++;

                            if (counter == number)
                            {
                                sumCombination = symbolOne + symbolTwo + symbolThird + symbolFourt + symbolFifth;
                                Console.WriteLine($"Ticket combination: {(char)symbolOne}{(char)symbolTwo}{(char)symbolThird}{symbolFourt}{symbolFifth}");
                                Console.WriteLine($"Prize: {sumCombination} lv.");
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}

