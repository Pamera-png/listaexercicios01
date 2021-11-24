using System;

namespace Exercicio02
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número que corresponde ao dia da semana (1 a 7)");
            int diaSemana = Convert.ToInt32(Console.ReadLine());
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                    default:
                    Console.WriteLine("dia da semana inválido");
                    break;
            }

        }
    }
}