using System;


class Old_Book
{
    static void Main()
    {
        string findBook = Console.ReadLine();
        int numberOfBook = int.Parse(Console.ReadLine());

        int counter = 0;
        string book = string.Empty;

        while (counter < numberOfBook)
        {
            book = Console.ReadLine();
            

            if (book == findBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
                break;
            }
            counter++;
        }

        if (counter >= numberOfBook)
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");

        }

        
    }
}

