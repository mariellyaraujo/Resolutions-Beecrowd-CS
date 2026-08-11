using System;

namespace beecrownd
{
    class URI1114
    {
        public static void Main (String[] args)
        {
            while (true)
            {
                int entrada = int.Parse(Console.ReadLine());

                if (entrada != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                } else
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
            }
        }
    }
}