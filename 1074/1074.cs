using System;
using System.Globalization;

namespace beecrowd {
    class URI1074 {

        public static void Main (string[] args) {

            int x;
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y; i++) {
        
            x = int.Parse(Console.ReadLine());

            if (x == 0 ) {
                Console.WriteLine($"NULL");
            } else if (x % 2 == 0 && x > 0) {
                Console.WriteLine($"EVEN POSITIVE");
            } else if (x % 2 == 0 && x < 0) {
                Console.WriteLine($"EVEN NEGATIVE");
            } else if (x % 2 != 0 && x > 0) {
                Console.WriteLine($"ODD POSITIVE");
            } else if (x % 2 != 0 && x < 0) {
                Console.WriteLine($"ODD NEGATIVE");
            }

        }

        }
    }
}
