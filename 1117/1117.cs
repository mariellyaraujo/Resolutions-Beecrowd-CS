using System; 
using System.Globalization;

namespace beecrownd {
    class URI1117 {

        public static void calcNotas()
        {
            int i = 0;
            double media = 0.0;
            
            while(i < 2)
            {
                string input = Console.ReadLine(); 
                double entrada = double.Parse(input, CultureInfo.InvariantCulture);

                if (entrada <= 0 || entrada > 10)
                {
                    Console.WriteLine("nota invalida");
                } else
                {
                    media = media + entrada;
                    i++;
                }
            }
            media = media / 2;
            Console.WriteLine($"media = {(media.ToString("F2", CultureInfo.InvariantCulture))}");
        }
        static void Main(string[] args) { 

           

           calcNotas();

        }

    }
}