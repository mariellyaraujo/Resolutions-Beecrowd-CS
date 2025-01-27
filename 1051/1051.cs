using System;
using System.Globalization;

namespace beecrowd {
    class URI1051 {

        public static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if (salario >= 0 && salario <= 2000.00) {
                Console.WriteLine("Isento");

            } else if (salario >= 2000.01 && salario <= 3000.00) {
                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine($"R$ {imposto:0.00}");

            } else if (salario >= 3000.01 && salario <= 4500.00) {
                imposto = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);
                Console.WriteLine($"R$ {imposto:0.00}");
                
            } else {
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
                Console.WriteLine($"R$ {imposto:0.00}");
            }
        }
    }
}
