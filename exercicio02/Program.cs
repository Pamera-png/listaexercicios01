using System;

namespace Exercicio02{
    public class Program    {
        public static void Main(string[] args)        {
Console.WriteLine("digite o primeiro número");
String? textoNumero01 = Console.ReadLine();
Console.WriteLine("digite o segundo número");
String? textoNumero02 = Console.ReadLine();
Console.WriteLine("digite o terceiro número");
String? textoNumero03 = Console.ReadLine();
int numero1 = Convert.ToInt32(textoNumero01);
int numero2 = Convert.ToInt32(textoNumero02);
int numero3 = Convert.ToInt32(textoNumero03);
int max = 0;
if (numero1 > numero2 && numero1 > numero3){
max = numero1;
}
else if (numero2 > numero1 && numero2 > numero3){
    max = numero2;
}
else{
    max = numero3;
}
Console.WriteLine("o maior número é o" + max);

int min;
if (numero1 < numero2 && numero1 < numero3){
min = numero1;
}
else if (numero2 < numero1 && numero2 < numero3){
    min = numero2;
}
else{
    min = numero3;
}
Console.WriteLine("o menor número é o" + min);
        }
    }
}