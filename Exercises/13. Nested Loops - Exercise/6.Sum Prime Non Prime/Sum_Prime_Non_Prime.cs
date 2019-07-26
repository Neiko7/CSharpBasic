using System;


class Sum_Prime_Non_Prime
{
    static void Main()
    {
        string command = string.Empty;
        
        int sumPrimeNumber = 0;
        int sumNonPrimeNumber = 0;

        while ((command = Console.ReadLine()) != "stop")
        {
            bool isPrime = true;
            int number = int.Parse(command);

            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
                continue;
            }
            else if (number < 2)
            {
                isPrime = false;
                
            }
            else
            {
                for (int i = number; i >= 2; i--)
                {
                    if (number % i == 0 && i != number)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                sumPrimeNumber += number;
            }
            else
            {
                sumNonPrimeNumber += number;
            }
        }

        Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumber}");
        Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumber}");
    }
}
