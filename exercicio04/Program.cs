using System;

namespace Exercicio02
{
    public class Program
    {

        public static void Main(string[] args)
        {
            double sal = 0;
            bool digitacaoinvalida = true;
            while (digitacaoinvalida)
            {
                try
                {
                    Console.WriteLine("digite o salário que será reajustado");
                    sal = Convert.ToDouble(Console.ReadLine());
                    if (sal > 0)
                        digitacaoinvalida = false;
                    else
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine("salário inválido. Digite novamente");
                }
            }
            double percentual = 0;
            double valorAumento = 0;
            double novoSal = 0;
            if (sal < 2800)
            {
                percentual = 0.2;
            }
            else if (sal >= 2800 && sal < 7000)
            {
                percentual = 0.15;
            }
            else if (sal >= 7000 && sal < 15000)
            {
                percentual = 0.1;
            }
            else
            {
                percentual = 0.05;
            }
            valorAumento = percentual * sal;
            novoSal = valorAumento + sal;

            Console.WriteLine($"o salário original é {sal}.\n o percentual de reajuste foi de {percentual * 100}.\n o valor real do aumento foi de {valorAumento}.\n o novo salário é {novoSal}");




        }
    }
}