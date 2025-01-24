using System;
using System.Collections.Generic;


namespace beecrowd {
    class URI1040 {

        public static void VerifTriangulo(double a, double b, double c) {
            if (a == b && a == c && b == c) {
                Console.WriteLine("TRIANGULO EQUILATERO");

            } else if (a == b || a == c || b == c) {
                Console.WriteLine("TRIANGULO ISOSCELES");

            }
        }

        public static void VerifAngulo(double a, double b, double c) {
            if ((a * a) == ((b * b) + (c * c))) {
                Console.WriteLine("TRIANGULO RETANGULO");
                VerifTriangulo(a, b, c);

            } else if ((a * a) > ((b * b) + (c * c))) {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                VerifTriangulo(a, b, c);

            } else if ((a * a) < ((b * b) + (c * c))) {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                VerifTriangulo(a, b, c);

            }
        }

        public static void Main(string[] args) {

            List<double> lista = new List<double>();
            double A, B, C;

            string[] numeros = Console.ReadLine().Split(' ');
            foreach (var numero in numeros) {
                lista.Add(double.Parse(numero));
            }
            lista.Sort((x, y) => y.CompareTo(x));

            A = lista[0];
            B = lista[1];
            C = lista[2];

            if ((B+C) <= A){
                Console.WriteLine("NAO FORMA TRIANGULO");

            } else {
                VerifAngulo(A, B, C);
            }

        }
    }
}
