using System;

namespace beecrowd {
    class URI1094 {

        public static void Main (string[] args) {
            int coelhosN = 0, saposN = 0, ratosN = 0;
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++){
                string[] entrada = Console.ReadLine().Split(' ');

                int quant = int.Parse(entrada[0]);
                char tipo = char.Parse(entrada[1]);

                switch(tipo){

                    case 'C':
                        coelhosN += quant;
                        break;

                    case 'S':
                        saposN += quant;
                        break;
                    
                    case 'R':
                        ratosN += quant;
                        break;
                }
            }

            int total = coelhosN + saposN + ratosN;

            double coelhosP = ((double) coelhosN / total) * 100;
            double saposP = ((double) saposN / total) * 100;
            double ratosP = ((double) ratosN / total) * 100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de Coelhos: {coelhosN}");
            Console.WriteLine($"Total de ratos: {ratosN}");
            Console.WriteLine($"Total de sapos: {saposN}");
            Console.WriteLine($"Percentual de coelhos: {coelhosP:0.00} %");
            Console.WriteLine($"Percentual de ratos: {ratosP:0.00} %");
            Console.WriteLine($"Percentual de sapos: {saposP:0.00} %");
           
    }
}
}