using System;


class Equal_Pairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int sum = a + b;
        int currentSum = 0;
        int maxDiff = 0;

        for (int i = 2; i <= n; i++)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            currentSum = a + b;
            if (currentSum != sum)
            {
                maxDiff = Math.Abs(currentSum - sum);
                sum = currentSum;
            }

        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }

    }
}

