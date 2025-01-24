using System;

namespace beecrowd {
    class URI1047 {

        public static void Main(string[] args) {

            string[] ent = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(ent[0]);
            int minutoInicio = int.Parse(ent[1]);
            int horaFim = int.Parse(ent[2]);
            int minutoFim = int.Parse(ent[3]);

            int duracaoHora;
            int duracaoMinuto;

            // Calculando a diferença de minutos
            int minutosInicio = horaInicio * 60 + minutoInicio;
            int minutosFim = horaFim * 60 + minutoFim;

            if (minutosFim <= minutosInicio) {
                minutosFim += 24 * 60; // Caso o horário de fim seja no dia seguinte
            }

            int duracaoTotalMinutos = minutosFim - minutosInicio;

            // Dividindo a duração total em horas e minutos
            duracaoHora = duracaoTotalMinutos / 60;
            duracaoMinuto = duracaoTotalMinutos % 60;

            Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");
        }
    }
}
