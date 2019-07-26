using System;


class Half_Sum_Element
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxNumber = int.MinValue;
        int sumNumber = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > maxNumber)
            {
                maxNumber = num;
            }

            sumNumber += num;
        }

        sumNumber -= maxNumber;

        if (sumNumber == maxNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", sumNumber);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs (maxNumber - sumNumber));
        }
    }
}
