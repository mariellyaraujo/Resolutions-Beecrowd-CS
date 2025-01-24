using System;

namespace beecrowd {
    class URI1040 {

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
                Console.WriteLine("nao eh tiangulo");

            } else {
                Console.WriteLine(" eh tiangulo");
            }

        }
    }
}
