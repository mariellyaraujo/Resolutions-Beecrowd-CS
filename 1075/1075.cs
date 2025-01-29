using System;
using System.Globalization;

namespace beecrowd {
    class URI1075 {

        public static void Main (string[] args) {

            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) {
 
            if (i % y == 2) {
                Console.WriteLine(i);
            }

        }

        }
    }
}
