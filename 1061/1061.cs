using System;

namespace beecrowd {
    class URI1061 {

        public static void Main(string[] args) {

            int diaI, horaI, minutoI, segundoI, diaF, horaF, minutoF, segundoF;
            string[] ent = Console.ReadLine().Split(' ');
            string[] ent1 = Console.ReadLine().Split(' ');
            
            diaI = int.Parse(ent[1]);
            horaI = int.Parse(ent1[0]);
            minutoI = int.Parse(ent1[2]);
            segundoI = int.Parse(ent1[4]);

            string[] ent2 = Console.ReadLine().Split(' ');
            string[] ent3 = Console.ReadLine().Split(' ');
            
            diaF = int.Parse(ent2[1]);
            horaF = int.Parse(ent3[0]);
            minutoF = int.Parse(ent3[2]);
            segundoF = int.Parse(ent3[4]);

            int totalI = (diaI * 86400) + (horaI * 3600) + (minutoI * 60) + segundoI;
            int totalF = (diaF * 86400) + (horaF * 3600) + (minutoF * 60) + segundoF;

            int totalDif = totalF - totalI;

            int dias = totalDif / 86400;
            totalDif %= 86400;

            int horas = totalDif / 3600;
            totalDif %= 3600;

            int minutos = totalDif / 60;
            totalDif %= 60;

            int segundos = totalDif;

            Console.WriteLine($"{dias} dia(s)");
            Console.WriteLine($"{horas} hora(s)");
            Console.WriteLine($"{minutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");
        }
    }
}
