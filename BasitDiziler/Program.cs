// See https://aka.ms/new-console-template for more information

using System.Collections;

int[] sayilar = { 10, 20, 30, 15, 44 };
Console.WriteLine(sayilar[1]);                       // diziler 0 1 2 dize gittiği için, ikinci elaman yazdırılırken 1 yazıldı

string[] meyvalar = { "Elma", "Armut", "Portakal" };

//foreach (string item in meyvalar)                    // string yerine var da yazılabilir
//{
    
//    Console.WriteLine(item);

//}

ConsoleColor[] renkler = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue , ConsoleColor.Cyan , ConsoleColor.Magenta };

ArrayList sebzeler = new ArrayList();
sebzeler.Add("Pırasa");
sebzeler.Add("Ispanak");
sebzeler.Add("Marul");
//foreach (var item in sebzeler)
//{
//    Console.WriteLine(item);
//}

// sebzeler.Remove("Ispanak");   listeden çıkarır
sebzeler.RemoveAt(1);          //ıspanak ikinci sırada olduğu için listeden çıkar

//    foreach (var item in sebzeler)
//{
//   Console.WriteLine(item);
//}

Console.WriteLine(meyvalar.Length); //eleman sayısını bulur
Console.WriteLine( sebzeler.Count); //eleman sayısını bulur

Goster();
void Goster()
 {
    foreach (var item in sebzeler)
    {
        Console.WriteLine(item);
    }
}

while (true)
{
    Console.WriteLine("Eklemek istediğiniz sebze");
    string sebze = Console.ReadLine();
    sebzeler.Add(sebze);
    Goster();
}