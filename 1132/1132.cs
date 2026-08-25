using System;

namespace beecrownd {
    class URI1132 {
        public static void Main(string[] args){
            int soma = 0, a = 0, b = 0;
            int e1 = int.Parse(Console.ReadLine());
            int e2 = int.Parse(Console.ReadLine());

            if (e1 < e2)
            {
                a = e1;
                b = e2;
            } else
            {
                b = e1;
                a = e2;
            }

            for(int i = a; i <= b; i++){
                if (i % 13 != 0){
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}