using System;
using System.Globalization;

namespace beecrowd {
    class URI1066 {

        public static void Main (string[] args) {

            int num;
            int positivo = 0;
            int negativo = 0;
            int par = 0;
            int impar = 0;

            for (int i = 1; i < 6; i++) {
        
            num = int.Parse(Console.ReadLine());
            
            if (num >= 0) {
                positivo = positivo + 1;

                if (n% 2 == 0){
                par++;
                 } else {
                impar++;
                 }

            } else {
                negativo = negativo + 1;

                if (y % 2 == 0){
                par++;
                 } else {
                impar++;
                 }

            }


        }

            Console.WriteLine($"{par}");
            Console.WriteLine($"{impar}");
            Console.WriteLine($"{positivo}");
            Console.WriteLine($"{negativo}");
        }
    }
}