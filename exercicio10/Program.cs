using System;

namespace Exercicio02{
    public class Program    {

        public static void Main(string[] args)        {
Console.WriteLine("digite um número inteiro positivo e eu te direi se ele é par ou ímpar");
int numero = Convert.ToInt32(Console.ReadLine());
double resultado = numero % 2;
if (resultado == 0){
    Console.WriteLine("o número" + numero + "é par");
}
else{
Console.WriteLine($"o número {numero} é ímpar");
}

}
}
}