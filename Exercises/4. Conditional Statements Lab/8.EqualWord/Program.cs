using System;

class Program
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWodr = Console.ReadLine();

        firstWord = firstWord.ToLower();
        secondWodr = secondWodr.ToLower();

        if (firstWord == secondWodr)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

