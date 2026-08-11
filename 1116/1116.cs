using System;
using System.Globalization;

namespace beecrownd
{
    class URI1116
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();

            int ent = int.Parse(linha);

            for (int i = 0; i < ent; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                int a = int.Parse(entrada[0]);
                int b = int.Parse(entrada[1]);

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double result = (double)a / b;
                    Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}