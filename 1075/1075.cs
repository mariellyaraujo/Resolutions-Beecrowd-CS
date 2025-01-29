using System;
using System.Globalization;

namespace beecrowd {
    class URI1075 {

        public static void Main (string[] args) {

            int resto;
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) {
            resto = i / y;

            if (i % y == 2) {
                Console.WriteLine(i);
            }

        }

        }
    }
}
