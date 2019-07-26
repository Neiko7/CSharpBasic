using System;


class Wedding_Hall 
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double weigth = double.Parse(Console.ReadLine());
        double sizeOfBar = double.Parse(Console.ReadLine());

        double hall = length * weigth;
        double bar = sizeOfBar * sizeOfBar;
        double dancing = hall * 0.19;
        double freeSpace = hall - (bar + dancing);
        double people = freeSpace / 3.2;

        Console.WriteLine(Math.Ceiling(people));
       
    }
}

