using System;
using System.Globalization;

namespace beecrowd {
    class URI1048 {

        public static void CalcPorcent(double s, double p) {

            p = (s * p) / 100;
            s = s + p;

            Console.WriteLine($"Novo salario: {s:0.00}");
            Console.WriteLine($"Reajuste ganho: {p:0.00}");
        }
        public static void Main (string[] args) {

            double porcent;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario >= 0 && salario <= 400.00) {
                porcent = 15;
                CalcPorcent(salario, porcent);
                Console.WriteLine($"Em percentual: {porcent} %");

            } else if(salario >= 400.01 && salario <= 800.00) {
                porcent = 12;
                CalcPorcent(salario, porcent);
                Console.WriteLine($"Em percentual: {porcent} %");

            } else if(salario >= 800.01 && salario <= 1200.00) {
                porcent = 10;
                CalcPorcent(salario, porcent);
                Console.WriteLine($"Em percentual: {porcent} %");

            } else if(salario >= 1200.01 && salario <= 2000.00) {
                porcent = 7;
                CalcPorcent(salario, porcent);
                Console.WriteLine($"Em percentual: {porcent} %");

            } else if(salario > 2000.00) {
                porcent = 4;
                CalcPorcent(salario, porcent);
                Console.WriteLine($"Em percentual: {porcent} %");

            }


        }
    }
}