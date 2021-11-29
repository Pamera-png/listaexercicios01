using System;

namespace Exercicio02{
    public class Program    {

        public static void Main(string[] args)        {
Console.WriteLine("digite a primeira nota");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite a segunda nota");
double nota2 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2) / 2;
Console.WriteLine("sua média é" + media);
if (media <= 10 && media > 9){
    Console.WriteLine("seu conceito é A. Você foi aprovado");
}
else if (media >= 7.5){
 Console.WriteLine("seu conceito é B. Você foi aprovado");
}
else if (media >= 6.0){
Console.WriteLine("seu conceito é C. Você foi aprovado");
}
else if (media >= 4.0){
    Console.WriteLine("Seu conceito é D. Você foi reprovado");
}
else if (media <  4.0 && media >= 0){
    Console.WriteLine("seu conceito é E. Você foi reprovado");
}
else{
    Console.WriteLine("nota inválida");
}

        }
}
}