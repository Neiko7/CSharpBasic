using System;


class AreaOfFigures
{
    static void Main()
    {
        string figureType = Console.ReadLine();
        double area = 0.0;

        switch (figureType)
        {
            case "square":
                {
                    double a = double.Parse(Console.ReadLine());
                    area = a * a;
                    break;
                }
            case "rectangle":
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = a * b;
                    break;
                }
            case "circle":
                {
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * r * r;
                    break;
                }
            case "triangle":
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = (a * b) / 2;
                    break;
                }
        }

        Console.WriteLine("{0:F3}", area);
    }
}
