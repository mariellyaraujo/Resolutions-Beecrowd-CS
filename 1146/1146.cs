using System;

namespace beecrownd
{
    class URI1146
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int ent = int.Parse(Console.ReadLine());

                if (ent == 0) break;

                for (int i = 1; i <= ent; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(i);
                    } else
                    {
                        Console.Write($" {i}");
                    }

                    if (i == ent) Console.WriteLine("");
                }
            }
        }
    }
}