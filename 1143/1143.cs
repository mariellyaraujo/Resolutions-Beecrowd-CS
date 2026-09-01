using System;

namespace beecrownd
{
    class URI1143
    {
        public static void Main(string[] args)
        {
            int ent = int.Parse(Console.ReadLine());

            for(int i = 1; i <= ent; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}