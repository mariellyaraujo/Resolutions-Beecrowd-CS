using System;
using static System.Math; 

    namespace beecrowd {
    class URI1036 {

    public static void Main (string[] args) {
         
         string[] ent = Console.ReadLine().Split(' ');

         double delta, R1, R2;
         double A = double.Parse(ent[0]);
         double B = double.Parse(ent[1]);
         double C = double.Parse(ent[2]);

         if(A == 0 || ((B * B) - (4 * A * C) < 0)){
            Console.WriteLine("Impossivel calcular");

         } else{
            delta = (B * B) - (4 * A * C);

            R1 = ((B * -1) + Math.Sqrt(delta)) / (2 * A);

            R2 = ((B * -1) - Math.Sqrt(delta)) / (2 * A);

            Console.WriteLine($"R1 = {R1:0.00000}");
            Console.WriteLine($"R2 = {R2:0.00000}");

         }
    }
  }
}