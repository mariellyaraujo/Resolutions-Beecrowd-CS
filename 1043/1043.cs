using System;
using System.Globalization;

namespace beecrowd {
    class URI1043 {

        public static void Main (string[] args) {
         
            string[] ent = Console.ReadLine().Split(' ');

            double perimetro, area;
            double A = double.Parse(ent[0], CultureInfo.InvariantCulture);
            double B = double.Parse(ent[1], CultureInfo.InvariantCulture);
            double C = double.Parse(ent[2], CultureInfo.InvariantCulture);

            if ((A + B) > C && (A + C) > B && (B + C) > A) {

                perimetro = A + B + C;
                Console.WriteLine($"Perimetro = {perimetro:0.0}");

            } else {

                area = ((A + B) * C) / 2;
                Console.WriteLine($"Area = {area:0.0}");
            }

        }
    }
}
