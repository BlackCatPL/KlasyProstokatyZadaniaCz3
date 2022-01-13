// See https://aka.ms/new-console-template for more information
using Klasy_cz3_zadania;

Console.WriteLine("Klasy cz.3 - zadania !");

Console.Write("Podaj długość dla p1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Podaj szerokość dla p1: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("\n");

Console.Write("Podaj długość dla p2: ");
int c = int.Parse(Console.ReadLine());
Console.Write("Podaj szerokość dla p2: ");
int d = int.Parse(Console.ReadLine());

Console.WriteLine("\n Pierwszy prostokąt ma następujące wyniki: ");
Prostokat p1 = new Prostokat(a, b);
p1.Prezentuj();
Console.ReadKey();
Console.WriteLine("\n Drugi prostokąt ma następujące wyniki: ");
Prostokat p2 = new Prostokat(c, d);
p2.Prezentuj();
Console.ReadKey();

Prostokat[] prostokaty = new Prostokat[2];
prostokaty[0] = p1;
prostokaty[1] = p2;

Console.WriteLine("\n");


foreach (var prostokat in prostokaty)
{
    prostokat.Prezentuj();
}
Console.WriteLine("\n");
Console.WriteLine("Największa powierzchnia prostokąta: {0}", Prostokat.Najwieksze(prostokaty));
Console.ReadKey();






// 1. Uzupełnij wcześniej utworzoną klasę prostokąt o definicję tablicy obiektów dla prostokątów. 
// W metodzie Main() wyświetl powierzchnie oraz obwód wszystkich prostokątów w tablicy 
// używając (wewnątrz pętli foreach) metody publicznej Prezentuj(). 

// 2. Uzupełnij program z poprzedniego zadania o definicję metody statycznej,
// która podaje powierzchnię największego prostokąta. 
