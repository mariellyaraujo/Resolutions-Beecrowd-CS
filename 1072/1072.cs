using System;
using System.Globalization;

namespace beecrowd {
    class URI1072 {

        public static void Main (string[] args) {

            int iin = 0;
            int oout = 0;
            int y = int.Parse(Console.ReadLine());

            
            

            for (int i = 0; i < y; i++) {
        
            int x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20) {
                iin++;
            } else {
                oout++;
            }

        }
            Console.WriteLine($"{iin} in");
            Console.WriteLine($"{oout} out");

        }
    }
}
