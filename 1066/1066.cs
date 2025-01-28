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
            
            if (num > 0) {
                positivo++;

                if (num % 2 == 0){
                par++;
                 } else {
                impar++;
                 }

            } else if (num < 0) {
                negativo++;

                if (num % 2 == 0){
                par++;
                 } else {
                impar++;
                 }

            } else {
                if (num % 2 == 0){
                par++;
                 } else {
                impar++;
                 }
            }


        }

            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");
        }
    }
}