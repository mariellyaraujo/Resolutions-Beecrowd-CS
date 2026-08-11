using System;

namespace beecrowd {
    class URI1094 {
        public static void Main(String[] args){
            int a = 1;
            
            for(int i = 0; i < 5; i++)
            {
                int b = 7;
          
                for(int j = 0; j < 3; j++)
                {
                    
                    Console.WriteLine($"I={a} J={b}");
                    b = b - 1;
                }
                a = a+2;
              }

        }
    }
}