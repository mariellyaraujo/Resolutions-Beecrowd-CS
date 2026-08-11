using System;
using System.Globalization;

namespace beecrownd
{
    class URI1098
    {
        public static void Main (String[] args)
        {
            double a = 0;

            for(int i = 0; i < 11; i++)
            {
                double b = 1;

                for(int j = 0; j < 3; j++)
                {
                    int aInteiro = (int)(Math.Round(a, 1) * 10);

                    if (aInteiro % 10 == 0)
                    {
                       Console.WriteLine($"I={a.ToString("F0", CultureInfo.InvariantCulture)} J={(a+b).ToString("F0", CultureInfo.InvariantCulture)}"); 
                    } else {
                        Console.WriteLine($"I={a.ToString("F1", CultureInfo.InvariantCulture)} J={(a+b).ToString("F1", CultureInfo.InvariantCulture)}");
                    }
                    b = b + 1;
                    
                }

                a = a + 0.2;
            }
        }
    }
}