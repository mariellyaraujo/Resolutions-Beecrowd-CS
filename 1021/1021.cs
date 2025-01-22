using System;

    namespace beecrowd {
    class URI1021 {

    public static void Main (string[] args) {
         
         int quociente, resto, notas, moedas;

        double valorUsuario = double.Parse(Console.ReadLine());

        resto = (int)(valorUsuario * 100 + 0.5);

        /////NOTAS
        
        Console.WriteLine("NOTAS:");
        ////100
        notas = 100;
        quociente = resto / (notas * 100);
        Console.WriteLine($"{quociente} nota(s) de R$ 100.00");
        resto = resto % (notas * 100);

        ////50
        notas = 50;
        quociente = resto / (notas * 100);
        Console.WriteLine($"{quociente} nota(s) de R$ 50.00");
        resto = resto % (notas * 100);

        ////20
        notas = 20;
        quociente = resto / (notas * 100);
        Console.WriteLine($"{quociente} nota(s) de R$ 20.00");
        resto = resto % (notas * 100);

        ////10
        notas = 10;
        quociente = resto / (notas * 100);
        Console.WriteLine($"{quociente} nota(s) de R$ 10.00");
        resto = resto % (notas * 100);

        ////5
        notas = 5;
        quociente = resto / (notas * 100);
        Console.WriteLine($"{quociente} nota(s) de R$ 5.00");
        resto = resto % (notas * 100);

        ////2
        notas = 2;
        quociente = resto / (notas * 100);
        Console.WriteLine($"{quociente} nota(s) de R$ 2.00");
        resto = resto % (notas * 100);

        /////////////MOEDAS
        
        Console.WriteLine("MOEDAS:");

        ////1
        moedas = 100;
        quociente = resto / moedas;
        Console.WriteLine($"{quociente} moeda(s) de R$ 1.00");
        resto = resto % moedas;

        ////0.50
        moedas = 50;
        quociente = resto / moedas;
        Console.WriteLine($"{quociente} moeda(s) de R$ 0.50");
        resto = resto % moedas;

        ////0.25
        moedas = 25;
        quociente = resto / moedas;
        Console.WriteLine($"{quociente} moeda(s) de R$ 0.25");
        resto = resto % moedas;

        ////0.10
        moedas = 10;
        quociente = resto / moedas;
        Console.WriteLine($"{quociente} moeda(s) de R$ 0.10");
        resto = resto % moedas;

        ////0.05
        moedas = 5;
        quociente = resto / moedas;
        Console.WriteLine($"{quociente} moeda(s) de R$ 0.05");
        resto = resto % moedas;

        ////0.01
        moedas = 1;
        quociente = resto / moedas;
        Console.WriteLine($"{quociente} moeda(s) de R$ 0.01");
        
    }
  }
}