using System;


 namespace beecrowd {
    class URI1080 {
   
     public static void Main(string[] args)
     {
       int maiorNum = 0;
       int posicao = 0;
       
       for(int i = 1; i <= 100; i++) {
         
         int num = int.Parse(Console.ReadLine());
         
         if(num > maiorNum) {
           
           maiorNum = num;
           posicao = i;
           
         }
       }
       
       Console.WriteLine(maiorNum);
       Console.WriteLine(posicao);
       
       
     }
   }
 }