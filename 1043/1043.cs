using System;
using System.Globalization;

namespace beecrowd {
    class URI1040 {

        public static void Main (string[] args) {
         
            string[] ent = Console.ReadLine().Split(' ');

            double triangulo, trapezio;
            double A = double.Parse(ent[0], CultureInfo.InvariantCulture);
            double B = double.Parse(ent[1], CultureInfo.InvariantCulture);
            double C = double.Parse(ent[2], CultureInfo.InvariantCulture);

            if ((A + B) >= C) {
                Console.WriteLine($"triangulo");

            } else {
                Console.WriteLine($"trapezio");
            }

        }
    }
}
