using System;
using System.Globalization;

namespace beecrowd {
    class URI1070 {

        public static void Main (string[] args) {

            int y = int.Parse(Console.ReadLine());
            
            if (y % 2 == 0) {
                y++;
            } else {
                y = y;
            }


            for (int i = 0; i < 6; i++) {
        
            Console.WriteLine(y);
            y += 2;

        }

        }
    }
}
