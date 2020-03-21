using System;
using static System.Console;


class MainClass {
  public static void Main (string[] args) {
   WriteLine ("Witaj w grze RPS");
   System.Console.Clear();
   WriteLine ("Oczekiwanie na wybór gracza 1:\n(1) kamień\n(2) papier\n(3) nożyce");
   string WyborGracz1 = ReadLine();

int WyborGracz1Int;
//próbuje zmienić wartość wczytana na int
while(!Int32.TryParse(WyborGracz1, out
WyborGracz1Int)
&& WyborGracz1Int > 3
&& WyborGracz1Int <= 0){
  WriteLine("Podaj poprawną liczbe");
  WyborGracz1 = ReadLine();
}
 WriteLine ("Oczekiwanie na wybór gracza 2:\n(1) kamień\n(2) papier\n(3) nożyce");
   string WyborGracz2 = ReadLine();

int WyborGracz2Int;
//próbuje zmienić wartość wczytana na int
while(!Int32.TryParse(WyborGracz2Int, out
WyborGracz2Int)
&& WyborGracz2Int > 3
&& WyborGracz2Int <= 0){
  WriteLine("Podaj poprawną liczbe");
  WyborGracz2Int = ReadLine();

  if (WyborGracz1 == WyborGracz2){
    WriteLine ("Remis");
    }
    else if (WyborGracz1Int > WyborGracz2Int){
WriteLine ("wygrał gracz 1");
//Nie dokończone
  }
  }
}
