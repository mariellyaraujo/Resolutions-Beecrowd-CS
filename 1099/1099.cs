using System;

namespace beecrownd
{
    class URI1099{
        public static void Main (String[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                int a = int.Parse(entrada[0]);
                int b = int.Parse(entrada[1]);

                int x = 0, y = 0, result = 0;

                if (a < b)
                {
                    x = a;
                    y = b;
                } else
                {
                    x = b;
                    y = a;
                }

                for(int j = x+1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        result = result + j;

                    }
                }
                Console.WriteLine($"{result}");
            }
        }
    }
}