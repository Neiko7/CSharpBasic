using System;


class Left_And_Right_Sum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumLeft = 0;
        int sumRight = 0;

        for (int i = 1; i <= n; i++)
        {
            int leftNumber = int.Parse(Console.ReadLine());
            sumLeft += leftNumber;
        }

        for (int i = 1; i <= n; i++)
        {
            int rightNumber = int.Parse(Console.ReadLine());
            sumRight += rightNumber;
        }

        if (sumLeft == sumRight)
        {
            Console.WriteLine("Yes, sum = {0}", sumLeft);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs (sumLeft - sumRight));
        }
        
    }
}

