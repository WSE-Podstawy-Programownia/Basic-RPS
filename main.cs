using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    WriteLine ("[Gracz 1] wybierz symbol:\n(1) kamien\n(2) papier\n(3) nozyce");
    string choiseOfThePlayerOne = ReadLine();
    int choiseOfThePlayerOneInt;
//
while(!Int32.TryParse(choiseOfThePlayerOne, out choiseOfThePlayerOneInt)
||choiseOfThePlayerOneInt > 3
||choiseOfThePlayerOneInt <= 0 ){
  WriteLine("Podaj poprawna liczbe");
  choiseOfThePlayerOne = ReadLine();
}

WriteLine("[Gracz 2] wybierz symbol:\n(1) kamien\n(2) papier\n(3) nozyce");
string choiseOfThePlayerTwo = ReadLine();
int choiseOfThePlayerTwoInt;

while(!Int32.TryParse(choiseOfThePlayerTwo, out choiseOfThePlayerTwoInt)
||choiseOfThePlayerTwoInt > 3
||choiseOfThePlayerTwoInt <= 0 ){
  WriteLine("Podaj poprawna liczbe");
  choiseOfThePlayerTwo = ReadLine();
}

if (choiseOfThePlayerOne == choiseOfThePlayerTwo){
  WriteLine ("Remis");
}

  }  
}