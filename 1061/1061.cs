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

            /*string[] ent = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(ent[0]);
            int minutoInicio = int.Parse(ent[1]);
            int horaFim = int.Parse(ent[2]);
            int minutoFim = int.Parse(ent[3]);

            int duracaoHora;
            int duracaoMinuto;

            int minutosInicio = horaInicio * 60 + minutoInicio;
            int minutosFim = horaFim * 60 + minutoFim;

            if (minutosFim <= minutosInicio) {
                minutosFim += 24 * 60; 
            }

            int duracaoTotalMinutos = minutosFim - minutosInicio;

          
            duracaoHora = duracaoTotalMinutos / 60;
            duracaoMinuto = duracaoTotalMinutos % 60;

            Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");*/
        }
    }
}
