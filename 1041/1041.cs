using System;
using System.Globalization;

namespace beecrowd {
    class URI1041 {

        public static void Main (string[] args) {
         
            string[] ent = Console.ReadLine().Split(' ');

            double X = double.Parse(ent[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(ent[1], CultureInfo.InvariantCulture);

            if (X == 0.0 && Y == 0.0){
                Console.WriteLine("Origem");

            } else if (X == 0){
                Console.WriteLine("Eixo X");

            } else if (Y == 0){
                Console.WriteLine("Eixo Y");

            } else if (X > 0 && Y > 0){
                Console.WriteLine("Q1");
                
            } else if (X < 0 && Y > 0){
                Console.WriteLine("Q2");
                
            } else if (X < 0 && Y < 0){
                Console.WriteLine("Q3");
                
            } else if (X > 0 && Y < 0){
                Console.WriteLine("Q4");
                
            }

            
        }
    }
}
