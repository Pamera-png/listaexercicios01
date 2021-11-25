using System;

namespace Exercicio05
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("digite quanto você ganha por horas trabalhadas");
            double valorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a quantidade de horas trabalhadas no mês");
            int quantHoras = Convert.ToInt32(Console.ReadLine());
            double salBruto = valorHora * quantHoras;
            double descontoSindicato = salBruto * 0.03;
            double descontoInss = salBruto * 0.11;
            double fgts = salBruto * 0.08;
            double descontoIR = 0;
            double percentualDescontoIr = 0;
            if (salBruto > 2000 && salBruto <= 5000)
                percentualDescontoIr = 0.05;
            else if (salBruto <= 7500)
                percentualDescontoIr = 0.1;
            else if (salBruto > 7500)
                percentualDescontoIr = 0.2;
            if (percentualDescontoIr != 0)
                descontoIR = salBruto * percentualDescontoIr;
            double salLi = salBruto - descontoSindicato - descontoInss - descontoIR;
            Console.WriteLine($"salário bruto: ({valorHora} * {quantHoras}) R$ {string.Format("{0:0.00}", salBruto)}\n" +
            $"(-CINDICATO (3%{string.Format("{0:0.00}", descontoSindicato)}))\n" +
            $"(- INSS (11%) : {string.Format("{0:0.00}", descontoInss)}))\n" +
                $"(-) descontoIR ({percentualDescontoIr * 100}%) : {string.Format("{0:0.00}", descontoIR)}\n" +
                $"fgts (8%) : {string.Format("{0:0.00}", fgts)}\n" +
            $"salLi {string.Format("{0:0.00}", salLi)}");   

        }
    }
}