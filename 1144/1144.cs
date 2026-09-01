using System;

namespace beecrownd {
    class URI1144 {
        public static void Main(string[] args) {
            int ent = int.Parse(Console.ReadLine());

            for(int i = 1; i <= ent; i++)
            {
                for(int j = 1; j <= 2; j++)
                {
                    if (j == 1)
                    {
                        Console.WriteLine($"{i} {i*i} {i*i*i}");
                    } else
                    {
                        Console.WriteLine($"{i} {(i*i)+1} {(i*i*i)+1}");
                    }
                    
                }
            }
        }
    }
}