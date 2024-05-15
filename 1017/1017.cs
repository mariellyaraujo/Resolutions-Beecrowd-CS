using System;

    namespace beecrowd {
    class URI1017 {

    public static void Main (string[] args) {

      double t = double.Parse(Console.ReadLine());
      double v = double.Parse(Console.ReadLine());

      double d = (t * v) / 12;

      Console.WriteLine($"{d:0.000}");
    }
  }
}