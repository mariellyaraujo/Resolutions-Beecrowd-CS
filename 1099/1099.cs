using System;
using System.Threading.Tasks.Dataflow;

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

                for(int j = x; j < y; j++)
                {
                    Console.Write($"{j }");
                    result = result + j;
                }
                Console.WriteLine($"{result}");
            }
        }
    }
}