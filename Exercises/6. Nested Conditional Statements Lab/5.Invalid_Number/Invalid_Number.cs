using System;

class Invalid_Number
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 100 && number <= 200)
        {
        }
        else if (number == 0)
        {
            
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}

