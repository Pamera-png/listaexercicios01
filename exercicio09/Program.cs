using System;

namespace Exercicio09{
    public class Program    {

        public static void Main(string[] args)        {
Console.WriteLine("digite uma data no formato dd/mm/aaaa");
Console.WriteLine("digite o dia");
short dia = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("digite o mês");
short mes = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("digite o ano");
short ano = Convert.ToInt16(Console.ReadLine());
if (mes==1 || mes==3 || mes==5 || mes==7 || mes==8 || mes==10 || mes==12){
 if (dia>=1 && dia<=31){
Console.WriteLine($"a data {dia}/{mes}/{ano} é válida");
 }   
 else{
     Console.WriteLine($"a data {dia}/{mes}/{ano} não é válida");
 }
}
else if (mes==2){
    if (dia>=1 && dia<=29){
Console.WriteLine($"a data {dia}/{mes}/{ano} é válida");
    }
    else{
        Console.WriteLine($"a data {dia}/{mes}/{ano} não é válida");
    }
}
else if (mes==4 || mes==6 || mes==9 || mes==11){
if (dia>=1 && dia<=30){
    Console.WriteLine($"a data {dia}/{mes}/{ano} é válida");
}
else{
    Console.WriteLine($"a data {dia}/{mes}/{ano} não é válida");
}
}
else{
    Console.WriteLine($"a data {dia}/{mes}/{ano} não é válida");
}
}
}
}