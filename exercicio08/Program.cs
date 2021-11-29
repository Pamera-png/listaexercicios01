using System;

namespace Exercicio08{
    public class Program    {

        public static void Main(string[] args)        {
Console.WriteLine("digite o primeiro lado");
int lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite o segundo lado");
int lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite o terceiro lado");
int lado3 = Convert.ToInt32(Console.ReadLine());
if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2){
                Console.WriteLine("é triângulo");
                if (lado1 == lado2 && lado2 == lado3){
                    Console.WriteLine("Equilátero");
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)                {
                    Console.WriteLine("Isósceles");
                }
                else                {
                    Console.WriteLine("Escaleno");
                }
            }
            else            {
                Console.WriteLine("Não é Triângulo");
            }

        }
    }
}