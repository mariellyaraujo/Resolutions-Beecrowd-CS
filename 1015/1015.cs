using System;
using static System.Math;

namespace beecrowd {
 class URI1015 {
  public static void Main (string[] args) {
    
    string[] ent1 = Console.ReadLine().Split(' ');
    string[] ent2 = Console.ReadLine().Split(' ');

    double x1 = double.Parse(ent1[0]);
    double y1 = double.Parse(ent1[1]);
    double x2 = double.Parse(ent2[0]);
    double y2 = double.Parse(ent2[1]);

    double s1 = Math.Pow((x2-x1),2);
    double s2 = Math.Pow((y2-y1),2);

      double z = s1+s2;

    
    double result = (Math.Sqrt(z));

    Console.WriteLine($"{result:0.0000}");
  }
}
}