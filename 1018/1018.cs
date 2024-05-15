using System;

namespace beecrowd
{
    public class URI1018
    {
        public static void Main (string[] args) {
            
           int valorDigitado, valorFinal, quant100, quant50, quant20, quant10, quant5, quant2, quant1;

           valorDigitado = int.Parse(Console.ReadLine());
            valorFinal = valorDigitado;
            Console.WriteLine(valorDigitado);
            
           ///cedulas 100
            quant100 = valorFinal / 100;
            valorFinal -= quant100 * 100;
            Console.WriteLine($"{quant100} nota(s) de R$ 100,00");

           ///cedulas 50
           quant50 = valorFinal / 50;
           valorFinal -= quant50 * 50;
           Console.WriteLine($"{quant50} nota(s) de R$ 50,00");

           ///cedulas 20
           quant20 = valorFinal / 20;
           valorFinal -= quant20 * 20;
           Console.WriteLine($"{quant20} nota(s) de R$ 20,00");

           ///cedulas 10
           quant10 = valorFinal / 10;
           valorFinal -= quant10 * 10;
           Console.WriteLine($"{quant10} nota(s) de R$ 10,00");

           ///cedulas 5
           quant5 = valorFinal / 5;
           valorFinal -= quant5 * 5;
           Console.WriteLine($"{quant5} nota(s) de R$ 5,00");

           ///cedulas 2
           quant2 = valorFinal / 2;
           valorFinal -= quant2 * 2;
           Console.WriteLine($"{quant2} nota(s) de R$ 2,00");

           ///cedulas 1
           quant1 = valorFinal / 1;
           valorFinal -= quant1 * 1;
           Console.WriteLine($"{quant1} nota(s) de R$ 1,00");

        }
    }
}