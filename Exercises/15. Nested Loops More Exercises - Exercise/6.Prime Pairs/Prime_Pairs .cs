using System;


class Prime_Pairs
{
    static void Main()
    {
        int startOfFirstPair = int.Parse(Console.ReadLine());
        int startOfSecondPair = int.Parse(Console.ReadLine());
        int finishOfFirstPairPlusNum = int.Parse(Console.ReadLine());
        int finishOfSecondPairPlusNum = int.Parse(Console.ReadLine());

        for (int firstPair = startOfFirstPair; firstPair <= startOfFirstPair + finishOfFirstPairPlusNum; firstPair++)
        {
            for (int secondPair = startOfSecondPair; secondPair <= startOfSecondPair + finishOfSecondPairPlusNum; secondPair++)
            {
                bool firstCheck = true;
                for (int n = 2; n <= Math.Floor(Math.Sqrt(firstPair)); n++)
                {
                    if (firstPair % n == 0)
                    {
                        firstCheck = false;
                    }
                }

                bool secondCheck = true;
                for (int m = 2; m <= Math.Floor(Math.Sqrt(secondPair)); m++)
                {
                    if (secondPair % m == 0)
                    {
                        secondCheck = false;
                    }
                }

                if (firstCheck && secondCheck)
                {
                    Console.WriteLine($"{firstPair}{secondPair}");
                }
            }
        }
    }
}

