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
else if ((choiseOfThePlayerOne == "1" && choiseOfThePlayerTwo == "3")
||(choiseOfThePlayerOne == "2" && choiseOfThePlayerTwo == "1")
||(choiseOfThePlayerOne == "3" && choiseOfThePlayerTwo == "2")){
  WriteLine("Wygrywa pierwszy gracz");
}
else if((choiseOfThePlayerOne == "3" && choiseOfThePlayerTwo == "1")
|| (choiseOfThePlayerOne == "1" && choiseOfThePlayerTwo == "2")
||(choiseOfThePlayerOne == "2" && choiseOfThePlayerTwo == "3")){
  WriteLine("Wygrywa drugi gracz");
}
  }  
}