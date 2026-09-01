using System;
using System.Globalization;

namespace beecrownd
{
    class URI1145
    {
        public static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            int num = 0;

            for(int i = 1; i <= b; i += a)
            {
                num = i;
                for(int j = 0; j < a; j++)
                {
                    if (num > b) break;

                    if (j == 0)
                    {
                        Console.Write(num + j);
                    } else
                    {
                        Console.Write($" {num + j}");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}