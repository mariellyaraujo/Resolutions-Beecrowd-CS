using System;
using System.Globalization;

namespace beecrowd {
    class URI1067 {

        public static void Main (string[] args) {

            int soma = 0;
            int y = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            

            for (int i = x; i < y; i++) {
        
            if (i % 2 != 0 && i != x) {
                soma += i;
                Console.WriteLine(i);
            }



        }
            Console.WriteLine(soma);

        }
    }
}
