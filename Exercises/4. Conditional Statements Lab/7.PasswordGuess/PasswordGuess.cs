using System;


class PasswordGuess
{
    static void Main()
    {
        string password = Console.ReadLine();
        string constantPass = "s3cr3t!P@ssw0rd";

        if (password == constantPass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }

        
    }
}

