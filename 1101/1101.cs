using System;

namespace beecrownd
{
    class URI1101
    {
        public static void Main (String[] args)
        {
            while (true)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                int a = int.Parse(entrada[0]);
                int b = int.Parse(entrada[1]);

                if (a <= 0 || b <= 0)
                {
                    break;
                }

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

                for(int j = x; j <= y; j++)
                    {
                        Console.Write($"{j} ");
                        result = result + j;
                    }
                Console.Write($"Sum={result}");
                Console.WriteLine();
            }
        }
    }
}
