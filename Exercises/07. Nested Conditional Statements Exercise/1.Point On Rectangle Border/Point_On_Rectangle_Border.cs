using System;

class Point_On_Rectangle_Border
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

       
        if (x == x1 || x == x2)
        {
            if (y >= y1 && y <= y2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
        else if (y == y1 || y == y2)
        {
            if (x >= x1 && x <= x2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }


    }
}

