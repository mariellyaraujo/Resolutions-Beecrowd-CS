using System;
using System.Globalization;

namespace beecrowd {
    class URI1040 {

        public static void Main (string[] args) {
         
            string[] ent = Console.ReadLine().Split(' ');

            double media, final;
            double N1 = double.Parse(ent[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(ent[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(ent[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(ent[3], CultureInfo.InvariantCulture);


            media = (((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10);

            media = Math.Truncate(media * 10) / 10;

            Console.WriteLine($"Media: {media:0.0}");

            if(media >= 7){
                Console.WriteLine("Aluno aprovado.");

            } else if(media <= 4.9) {

                Console.WriteLine("Aluno reprovado.");

            } else {

                Console.WriteLine("Aluno em exame.");

                final = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"Nota do exame: {final:0.0}");

                final = (final + media) / 2;

                final = Math.Truncate(final * 10) / 10;

                if (final >= 5) {
                    Console.WriteLine("Aluno aprovado.");
                } else {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine($"Media final: {final:0.0}");

            }
            
        }
    }
}
