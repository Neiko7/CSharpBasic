using System;


class Numbers_Ending_In_7
{
    static void Main()
    {
        for (int i = 1; i <= 1000; i++)
        {
            int num = i % 10; 

            if (num == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}
