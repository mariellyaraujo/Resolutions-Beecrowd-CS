using System; 

namespace Beecrownd {
    class URI1131 {

        public static void print (int gremio, int inter, int empate, int quant){
            Console.WriteLine($"{quant} grenais");
            Console.WriteLine($"Inter:{inter}");
            Console.WriteLine($"Gremio:{gremio}");
            Console.WriteLine($"Empates:{empate}");
            
            if (inter > gremio){
                Console.WriteLine("Inter venceu mais");
            } else if (gremio < inter) {
                Console.WriteLine("Gremio venceu mais");
            } else if (inter == gremio) {
                Console.WriteLine("Nao houve vencedor");
            }
        }

        public static void Main(string[] args){
            int gremio = 0, inter = 0, empate = 0, quant = 1;

            string[] entrada = Console.ReadLine().Split(' ');

            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            if (a > b){
                inter++;
            } else if (a < b) {
                gremio++;
            } else if (a == b) {
                empate++;
            }

            while(true){
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int ent = int.Parse(Console.ReadLine());

                if (ent == 1 ){
                    string[] entrada2 = Console.ReadLine().Split(' ');

                    int a2 = int.Parse(entrada2[0]);
                    int b2 = int.Parse(entrada2[1]);

                    if (a2 > b2){
                        inter++;
                    } else if (a2 < b2) {
                        gremio++;
                    } else if (a2 == b2) {
                        empate++;
                    }

                    quant++;
                } else if (ent == 2){
                    print(gremio, inter, empate, quant);
                    break;
                }
            }
            }



            
        }
    }
