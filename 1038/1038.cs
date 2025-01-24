using System;

namespace beecrowd {
    class URI1038 {

        public static void Main (string[] args) {
         
            string[] ent = Console.ReadLine().Split(' ');

            double A = double.Parse(ent[0]);
            int B = int.Parse(ent[1]);

            if(A == 1){
                A = 4.00 * B;
                Console.WriteLine($"Total: R$ {A:0.00}");

            } else if(A == 2){
                A = 4.50 * B;
                Console.WriteLine($"Total: R$ {A:0.00}");

            } else if(A == 3){
                A = 5.00 * B;
                Console.WriteLine($"Total: R$ {A:0.00}");
                
            } else if(A == 4){
                A = 2.00 * B;
                Console.WriteLine($"Total: R$ {A:0.00}");
                
            } else if(A == 5){
                A = 1.50 * B;
                Console.WriteLine($"Total: R$ {A:0.00}");
                
            }
        }
    }
}
