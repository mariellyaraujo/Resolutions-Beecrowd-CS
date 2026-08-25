using System;

namespace beecrownd {
    class URI1132 {
        public static void Main(string[] args){
            int soma = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for(int i = a; i < b; i++){
                if (i % 13 != 0){
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}