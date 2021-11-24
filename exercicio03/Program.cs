using System;

namespace Exercicio03{
    public class Program    {

        public static void Main(string[] args)        {
Console.WriteLine("quanto custa o primeiro produto");
String? textoproduto1 =  Console.ReadLine();
Console.WriteLine("quanto custa o segundo produto");
String? textoproduto2 =  Console.ReadLine();
Console.WriteLine("quanto custa o terceiro produto");
String? textoproduto3 =  Console.ReadLine();
int produto1 = Convert.ToInt32(textoproduto1);
int produto2 = Convert.ToInt32(textoproduto2);
int produto3 = Convert.ToInt32(textoproduto3);
int min = 0;
if (produto1 < produto2 && produto1 < produto3){
min = produto1;
}
    else if (produto2 < produto3){
min = produto2;
    }
else{
    min = produto3;
}
Console.WriteLine("o    produto de menor preço é o que custa" + min + "reais");

}
}
}