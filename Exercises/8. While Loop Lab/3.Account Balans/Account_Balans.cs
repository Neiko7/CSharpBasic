using System;

class Account_Balans
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        double totalSum = 0.0;

        while (counter < n)
        {
            
            double sum = double.Parse(Console.ReadLine());
            
            if (sum < 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            Console.WriteLine($"Increase: {sum:F2}");
            counter++;
            totalSum += sum; 
        }

        Console.WriteLine($"Total: {totalSum:F2}");
    }
}

