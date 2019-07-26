using System;

class ConcatenateDate
{
    static void Main()
    {
        //Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        //Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        //Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());
        //Console.Write("Enter Town: ");
        string town = Console.ReadLine();
   
        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);
    }
}

