using System;


class Operations_Between_Numbers
{
    static void Main()
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());
        char sumbol = char.Parse(Console.ReadLine());

        double result = 0;

        if (sumbol == '+')
        {
            result = numberOne + numberTwo;

            if (result % 2 == 0)
            {
                Console.WriteLine($"{numberOne} + {numberTwo} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{numberOne} + {numberTwo} = {result} - odd");
            }
        }
        else if (sumbol == '-')
        {
            result = numberOne - numberTwo;

            if (result % 2 == 0)
            {
                Console.WriteLine($"{numberOne} - {numberTwo} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{numberOne} - {numberTwo} = {result} - odd");
            }
        }
        else if (sumbol == '*')
        {
            result = numberOne * numberTwo;

            if (result % 2 == 0)
            {
                Console.WriteLine($"{numberOne} * {numberTwo} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{numberOne} * {numberTwo} = {result} - odd");
            }
        }
        else if (sumbol == '/')
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", numberOne);
            }
            else
            {
                result = numberOne / numberTwo;
                Console.WriteLine($"{numberOne} / {numberTwo} = {result:F2}");
            }

        }
        else if (sumbol == '%')
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", numberOne);
            }
            else
            {
                result = numberOne % numberTwo;
                Console.WriteLine($"{numberOne} % {numberTwo} = {result}");
            }
        }

    }
}

