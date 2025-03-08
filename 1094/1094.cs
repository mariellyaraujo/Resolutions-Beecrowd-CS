using System;

namespace beecrowd {
    class URI1094 {

        public static void Main (string[] args) {
            int coelhosN, saposN, ratosN;
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++){
                string[] entrada = Console.ReadLine().Split(' ');

                int quant = int.Parse(entrada[0]);
                char tipo = char.Parse(entrada[1]);

                switch(tipo){

                    case 'C':
                        coelhosN =+ quant;
                        break;

                    case 'S':
                        saposN =+ quant;
                        break;
                    
                    case 'R':
                        ratosN =+ quant;
                        break;
                }

            }
        }
    }
}