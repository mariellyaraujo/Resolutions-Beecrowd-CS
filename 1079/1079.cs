using System;
using System.Globalization;

namespace beecrowd {
    class URI1078 {

        public static void Main (string[] args) {

            double calculo, num1, num2, num3;
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++) {
 
                string[] ent = Console.ReadLine().Split(' ');

                num1 = double.Parse(ent[0], CultureInfo.InvariantCulture);
                num2 = double.Parse(ent[1], CultureInfo.InvariantCulture);
                num3 = double.Parse(ent[2], CultureInfo.InvariantCulture);

                calculo = (num1 + num2 + num3) / 3;

                Console.WriteLine(calculo);

        }

        }
    }
}
