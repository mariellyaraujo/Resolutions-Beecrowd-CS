using System;
using System.Text;

namespace beecrowd
{
    class URI1146
    {
        public static void Main(string[] args)
        {
            string input;
            
            while ((input = Console.ReadLine()) != null)
            {
                int ent = int.Parse(input);
                if (ent == 0) break;

                StringBuilder sb = new StringBuilder();

                for (int i = 1; i <= ent; i++)
                {
                    if (i == 1)
                    {
                        sb.Append(i);
                    }
                    else
                    {
                        sb.Append(' ').Append(i);
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}