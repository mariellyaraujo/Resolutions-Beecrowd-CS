using System;

namespace beecrowd {
    class URI1040 {

        public static void VerifMultiplos(int Y) {
            if (Y == 0){
                Console.WriteLine("São Multiplos");
            } else {
                Console.WriteLine("Não são Multiplos");
            }
        }

        public static void Main(string[] args) {
            int resto;
            string[] ent = Console.ReadLine().Split(' ');

            int A = int.Parse(ent[0]);
            int B = int.Parse(ent[1]);

            if (B >= A) {
                resto = B % A;
                VerifMultiplos(resto);
            } else {
                resto = A % B;
                VerifMultiplos(resto);
            }
        }
    }
}
