// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
Console.WriteLine("Kim Milyoner Olmak İster");
int dogrusayisi = 0;
Console.WriteLine("1-Kızınca tüküren hayvan hangisi");
Console.WriteLine("a)Lama b)Deve");
string dogrucevap1 = "a";
string cevap1 = Console.ReadLine().ToLower();
if(cevap1 == dogrucevap1)
{

    Console.WriteLine("Tebrikler doğru cevap");
    dogrusayisi += 1; 
}
else
{
    Console.WriteLine("Yanlış cevap");
}
Console.WriteLine("2-Dünya'ya en yakın gezegen hangisidir");
Console.WriteLine("a)Venüs b)Mars");
string dogrucevap2 = "b";
string cevap2 = Console.ReadLine().ToLower();
if (cevap2 == dogrucevap2)
{

    Console.WriteLine("Tebrikler doğru cevap");
    dogrusayisi += 1;
}
else
{
    Console.WriteLine("Yanlış cevap");
}
if (dogrusayisi == 2) {
    Console.WriteLine("Tebrikler milyoner oldunuz:)");
}else if (dogrusayisi == 0)
{
    Console.WriteLine("Üzgünüz kaybettiniz:(");
}else
{
    Console.WriteLine("3-5*2+8/2-2 işleminin sonucu nedir?");
    Console.WriteLine("a)7 b)12");
    string dogrucevap3 = "b";
    string cevap3 = Console.ReadLine().ToLower();
    if (cevap3 == dogrucevap3)
    {

        Console.WriteLine("Tebrikler milyoner oldunuz:)");
    }
    else
    {
        Console.WriteLine("Üzgünüm kaybettiniz:(");
    }
}