using System;

namespace beecrownd
{
    class URI1134
    {
        public static void Main(string[] args)
        {
            int a = 0, g = 0, d = 0;
            bool continuar = true;
            while (continuar)
            {
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        a++;
                        break;

                    case 2:
                        g++;
                        break;

                    case 3:
                        d++;
                        break;

                    case 4:
                        Console.WriteLine($"MUITO OBRIGADO\nAlcool: {a}\nGasolina: {g}\nDiesel: {d}");
                        continuar = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }

}
