using System;

namespace beecrownd
{
    class URI1133
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            int e1 = int.Parse(Console.ReadLine());
            int e2 = int.Parse(Console.ReadLine());

            if (e1 < e2)
            {
                a = e1;
                b = e2;
            } else
            {
                b = e1;
                a = e2;
            }

            for(int i = a+1; i < b; i++)
            {
                if (i % 5 == 2 || i % 5 == 3) Console.WriteLine(i);
            }
        }
    }
}