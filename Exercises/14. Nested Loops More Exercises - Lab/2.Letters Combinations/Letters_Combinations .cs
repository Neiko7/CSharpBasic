using System;

class Letters_Combinations 
{
    static void Main()
    {
        char firstSymbol = char.Parse(Console.ReadLine());
        char secondSymbol = char.Parse(Console.ReadLine());
        char thirdSymbol = char.Parse(Console.ReadLine());

        int counter = 0;

        for (char i = firstSymbol; i <= secondSymbol; i++)
        {
            for (char j = firstSymbol; j <= secondSymbol; j++)
            {
                for (char k = firstSymbol; k <= secondSymbol; k++)
                {
                    if (i != thirdSymbol && j != thirdSymbol && k != thirdSymbol)
                    {
                        Console.Write($"{i}{j}{k} ");
                        counter++;
                    }
                }
            }
        }

        Console.Write(counter);
        Console.WriteLine();
    }
}

