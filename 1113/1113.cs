using System;

namespace beecrownd
{
    class URI1113
    {
        public static void Main (String[] args)
        {
            while (true)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                int a = int.Parse(entrada[0]);
                int b = int.Parse(entrada[1]);

                if (a == b) {
                    break;
                } else if (a < b) {
                    Console.WriteLine("Crescente");
                } else if (b < a) {
                    Console.WriteLine("Decrescente");
                }
            }
        }
    }
}