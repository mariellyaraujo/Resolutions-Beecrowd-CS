using System;
using System.Globalization;

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

            double coelhosP = total > 0 ? ((double) coelhosN / total) * 100 : 0;
            double saposP = total > 0 ? ((double) saposN / total) * 100 : 0;
            double ratosP = total > 0 ? ((double) ratosN / total) * 100 : 0;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhosN}");
            Console.WriteLine($"Total de ratos: {ratosN}");
            Console.WriteLine($"Total de sapos: {saposN}");
            Console.WriteLine($"Percentual de coelhos: {coelhosP.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {ratosP.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {saposP.ToString("F2", CultureInfo.InvariantCulture)} %");
           
    }
}
}