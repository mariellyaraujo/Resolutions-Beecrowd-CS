using System;
using System.Globalization;

namespace beecrowd {
    class URI1060 {

        public static void Main(string[] args) {

        double num;
        double calculo = 0;
        int positivos = 0;

        for (int i = 0; i < 6; i++) {
        
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (num >= 0) {
                calculo += num;
                positivos++;
            }

        }

        calculo = calculo / positivos;

        Console.WriteLine($"{positivos} valores positivos");
        Console.WriteLine($"{calculo:0.0}");
        }
    }
}
