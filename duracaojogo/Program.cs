using System;
namespace duracaojogo
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Entrada: ");

            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);

            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine();
            Console.WriteLine("Saída: ");
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}