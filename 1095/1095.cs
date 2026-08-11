using System;

namespace beecrownd
{
    class URI1095
    {
        public static void Main (String[] args)
        {
            int a = 1, b = 60;
            for (; b >= 0; b -= 5, a += 3)
            {
                Console.WriteLine($"I={a} J={b}");
            }
        }
    }
}