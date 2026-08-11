using System;

namespace beecrownd
{
    class URI1115
    {
        public static void Main (String[] args){
            string result = "";
            while (true)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                int a = int.Parse(entrada[0]);
                int b = int.Parse(entrada[1]);

                if (a == 0 || b == 0) break;

                if(a > 0 && b > 0) result = "primeiro";
                else if(a < 0 && b > 0) result = "segundo";
                else if(a < 0 && b < 0) result = "terceiro";
                else if(a > 0 && b < 0) result = "quarto";

                Console.WriteLine(result);
            }
        }
    }
}