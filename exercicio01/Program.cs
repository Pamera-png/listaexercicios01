using System;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("digite a primeira nota");
String? textoNota01 = Console.ReadLine();
Console.WriteLine("digite a segunda nota");
String? textoNota02 = Console.ReadLine();
double nota01 = Convert.ToDouble(textoNota01);
double nota02 = Convert.ToDouble(textoNota02);
double media = (nota01 + nota02) / 2;
if (media == 10){
    Console.WriteLine("aprovado com distinção");
}
else if (media >= 7){
    Console.WriteLine("aprovado");
}
else{
    Console.WriteLine("reprovado");
}
        }
    }
}