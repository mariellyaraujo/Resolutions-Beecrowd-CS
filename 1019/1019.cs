using System;

    namespace beecrowd {
    class URI1019 {

    public static void Main (string[] args) {
         
         int valor, valorFinal, horas, minutos, segundos;

         valor = int.Parse(Console.ReadLine());
        valorFinal = valor;

           horas = valorFinal / 3600;
           valorFinal -= horas * 3600;

           minutos = valorFinal / 60;
           valorFinal -= minutos * 60;

           segundos = valorFinal;


     Console.WriteLine($"{horas}:{minutos}:{segundos}");

    }
  }
}