using System;

namespace beecrownd
{
    class URI1142
    {
        public static void Main(string[] args)
        {
            int ent = int.Parse(Console.ReadLine());
            int num = 1;

            for(int i = 0; i < ent; i++)
            {
                Console.WriteLine($"{num} {num+1} {num+2} PUM");

                num+=4;
            }
        }
    }
}