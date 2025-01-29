using System;
using System.Globalization;

namespace beecrowd {
    class URI1073 {

        public static void Main (string[] args) {

            int y = int.Parse(Console.ReadLine());

            

            for (int i = 0; i <= y; i++) {
        
            if (i % 2 == 0) {
                Console.WriteLine($"{i}^{i} = {i * i}");
            }

        }

        }
    }
}
