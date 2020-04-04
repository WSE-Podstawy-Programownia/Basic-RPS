using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
  string[,] Tabelawynikow = new string[10,3];

    int TabelawynikowCurrentIndex = 0;

    do {

    Console.WriteLine ("Witaj w grze papier, kamień, nożyce ;)");
    Console.WriteLine ("Graczu nr. 1 proszę wybrać papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)");
    string wyborgracza1 = System.Console.ReadLine();
    System.Console.Clear();
    Console.WriteLine ("Graczu nr. 2 proszę wybrać papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)");
    string wyborgracza2 = Console.ReadLine();
 
    if (wyborgracza1 == wyborgracza2)
    {
      Console.WriteLine("Remis");
    }
    if (wyborgracza1 == "1" && wyborgracza2 == "2")
    {
      Console.WriteLine("Wygrał gracz nr 1");
    }
    if (wyborgracza1 == "2" && wyborgracza2 == "1")
    {
      Console.WriteLine("Wygrał gracz nr 2");
    }
    if (wyborgracza1 == "1" && wyborgracza2 == "3")
    {
      Console.WriteLine("Wygrał gracz nr 2");
    }
    if (wyborgracza1 == "3" && wyborgracza2 == "1")
    {
      Console.WriteLine("Wygrał gracz nr 1");
    }
  if (wyborgracza1 == "2" && wyborgracza2 == "3")
    {
      Console.WriteLine("Wygrał gracz nr 1");
    }
  if (wyborgracza1 == "3" && wyborgracza2 == "2")
    {
      Console.WriteLine("Wygrał gracz nr 2");
    }




  string wyborgracza1String = Console.ReadLine();
Tabelawynikow[TabelawynikowCurrentIndex, 0] = wyborgracza1String;
  string wyborgracza2String = Console.ReadLine();
Tabelawynikow[TabelawynikowCurrentIndex, 1] = wyborgracza2String;
Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Remis";
Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Pierwszy";
Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Drugi";
TabelawynikowCurrentIndex += 1;

Console.WriteLine ("Czy chcesz zakończyć rozgrywkę? (t)");
   } while (Console.ReadLine() != "t");


}
}