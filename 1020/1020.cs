using System;

    namespace beecrowd {
    class URI1019 {

    public static void Main (string[] args) {
         
         int valor, valorFinal, anos, meses, dias;

         valor = int.Parse(Console.ReadLine());
        valorFinal = valor;

           anos = valorFinal / 365;
           valorFinal -= anos * 365;
            Console.WriteLine($"{anos} ano(s)");

           meses = valorFinal / 30;
           valorFinal -= meses * 30;
            Console.WriteLine($"{meses} mes(es)");

           dias = valorFinal;
            Console.WriteLine($"{dias} dia(s)");


     

    }
  }
}