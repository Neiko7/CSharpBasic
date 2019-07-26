using System;


class Password_Generator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int a = 1; a <= n; a++)
        {
            for (int b = 1; b <= n; b++)
            {
                for (int c = 'a'; c < 'a' + l; c++)
                {
                    for (int d = 'a'; d < 'a' + l; d++)
                    {
                        for (int e = 1; e <= n; e++)
                        {
                            if (a < e && b < e)
                            {
                                Console.Write($"{a}{b}{(char)c}{(char)d}{e} ");   
                            }
                        }
                    }
                }
            }
        }
    }
}

