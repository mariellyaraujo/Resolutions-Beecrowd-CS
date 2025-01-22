using System;

    namespace beecrowd {
    class URI1019 {

    public static void Main (string[] args) {
         
         string[] ent = Console.ReadLine().Split(' ');

         int A = int.Parse(ent[0]);
         int B = int.Parse(ent[1]);
         int C = int.Parse(ent[2]);
         int D = int.Parse(ent[3]);
         int verifica = 0;

         if(B > C){
          verifica = verifica + 1;
         }

         if(D > A){
          verifica = verifica + 1;
         }

         if((C+D) > (A+B)){
          verifica = verifica + 1;
         }

         if(C >= 0 || D >= 0){
          verifica = verifica + 1;
         }

         if(A % 2 == 0){
          verifica = verifica + 1;
         }

         if(verifica == 5){
          Console.WriteLine("Valores aceitos");
         } else {
          Console.WriteLine("Valores nao aceitos");
         }
    }
  }
}