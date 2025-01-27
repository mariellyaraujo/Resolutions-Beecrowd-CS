using System;
using System.Globalization;

namespace beecrowd {
    class URI1051 {

        public static void Main (string[] args) {

            double resto, porcento;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 2000.00) {
                Console.WriteLine("Isento");

            } else if (salario >= 2000.01 && salario <= 3000.00) {
                resto = salario - 2000.00;
                porcento = (resto * 8) / 100;
                Console.WriteLine($"R$ {porcento:0.00}");

            } else if (salario >= 3000.01 && salario <= 4500.00) {
                
                resto = 1000.00;
                porcento = (resto * 8) / 100;
                
                salario += -3000.00;

                porcento += (salario*18) / 100;
                Console.WriteLine($"R$ {porcento:0.00}");

            } else {
                
                resto = 1000.00;
                porcento = (resto * 8) / 100;

                resto = 1500.00;
     
                porcento += (resto*18) / 100;

                salario += -4.500;

                porcento += (salario*28) / 100;

                Console.WriteLine($"R$ {porcento:0.00}");
            }
        }
    }
}