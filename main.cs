using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    string[,] tablicawynikow = new string[10,3];
    int numergry = 0;
    while(true){
    string wiadomoscPowitalna = "Wybór P1:\nk =Kamień\np = Papier\nn = Nożyce ";
    WriteLine(wiadomoscPowitalna);
    string inputPlayerOne;
    inputPlayerOne = ReadLine();

   if(inputPlayerOne == "k"){
     tablicawynikow [numergry, 0] = "Kamień";
     WriteLine("Gracz pierwszy wybrał kamień");
   }
   else if (inputPlayerOne == "p"){
     tablicawynikow [numergry, 0] = "Papier";
     WriteLine("Gracz pierwszy wybrał papier");
     }
  else if (inputPlayerOne == "n"){
    tablicawynikow [numergry, 0] = "Nożyce";
    WriteLine("Gracz pierwszy wybrał nożyce");
    }
   else{
     tablicawynikow [numergry, 0] = "Błędny wybór";
     WriteLine("Błędny wybór");
   }
  WriteLine("Naciśnij dowolny klawisz, żeby przejść do P2");
  ReadKey();
  Clear();

   WriteLine("Wybór P2:\nk = Kamień\np = Papier\nn = Nożyce ");
    string inputPlayerTwo;
    inputPlayerTwo = ReadLine();

  if(inputPlayerTwo == "k"){
      tablicawynikow [numergry, 1] = "Kamień";
      WriteLine("Gracz drugi wybrał kamień");
   }
   else if (inputPlayerTwo == "p"){
     tablicawynikow [numergry, 1] = "Papier";
     WriteLine("Gracz drugi wybrał papier");
     }
  else if (inputPlayerTwo == "n"){
    tablicawynikow [numergry, 1] = "Nożyce";
    WriteLine("Gracz drugi wybrał nożyce");
    }
   else{
    tablicawynikow [numergry, 1] = "Błędny wybór";
     WriteLine("Błędny wybór");
  }

  if(inputPlayerOne == inputPlayerTwo){
    WriteLine("Remis");
    tablicawynikow[numergry, 2] = "Remis";
  }
  else if((inputPlayerOne == "k" && inputPlayerTwo == "n")
  | (inputPlayerOne == "p" && inputPlayerTwo == "k")
  | (inputPlayerOne == "n" && inputPlayerTwo == "p")){
    WriteLine("Zwycięstwo gracza pierwszego");
    tablicawynikow[numergry, 2] = "Zwycięstwo gracza pierwszego";
  }
  else if((inputPlayerOne == "n" && inputPlayerTwo == "k")
  | (inputPlayerOne == "k" && inputPlayerTwo == "p")
  | (inputPlayerOne == "p" && inputPlayerTwo == "n")){
    WriteLine("Zwycięstwo gracza drugiego");
    tablicawynikow[numergry, 2] = "Zwycięstwo gracza drugiego";
  }
  else{
    WriteLine("Wpisano niepoprawne znaki");
}
    WriteLine("Zakończyć grę? [t]");
    string isExit = ReadLine();

    if(isExit == "t"){
        break;
      }
    Clear();
  
  }
  }
}