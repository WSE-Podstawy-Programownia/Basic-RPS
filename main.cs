using System;
using static System.Console;

class MainClass {

  string[,] gamesRecord = new string[10,3];
  int gamesRecordCurrentIndex = 0;

  public static void Main (string[] args) {
    while(true){
    string wiadomoscPowitalna = "Wybór P1:\nk =Kamień\np = Papier\nn = Nożyce ";
    WriteLine(wiadomoscPowitalna);
    string inputPlayerOne;
    inputPlayerOne = ReadLine();

   if(inputPlayerOne == "k"){
     gamesRecord[gamesRecordCurrentIndex, 0] = "Gracz pierwszy wybrał kamień";
     WriteLine("Gracz pierwszy wybrał kamień");
   }
   else if (inputPlayerOne == "p"){
     gamesRecord[gamesRecordCurrentIndex, 0] = "Gracz pierwszy wybrał papier"
     WriteLine("Gracz pierwszy wybrał papier");
     }
  else if (inputPlayerOne == "n"){
    gamesRecord[gamesRecordCurrentIndex, 0] = "Gracz pierwszy wybrał nożyce"
    WriteLine("Gracz pierwszy wybrał nożyce");
    }
   else{
     WriteLine("Błędny wybór");
   }
  WriteLine("Naciśnij dowolny klawisz, żeby przejść do P2");
  ReadKey();
  Clear();

   WriteLine("Wybór P2:\nk = Kamień\np = Papier\nn = Nożyce ");
    string inputPlayerTwo;
    inputPlayerTwo = ReadLine();

  if(inputPlayerTwo == "k"){
      WriteLine("Gracz drugi wybrał kamień");
   }
   else if (inputPlayerTwo == "p"){
     WriteLine("Gracz drugi wybrał papier");
     }
  else if (inputPlayerTwo == "n"){
    WriteLine("Gracz drugi wybrał nożyce");
    }
   else{
     WriteLine("Błędny wybór");
  }

  if(inputPlayerOne == inputPlayerTwo){
    WriteLine("Remis");
  }
  else if((inputPlayerOne == "k" && inputPlayerTwo == "n")
  | (inputPlayerOne == "p" && inputPlayerTwo == "k")
  | (inputPlayerOne == "n" && inputPlayerTwo == "p")){
    WriteLine("Zwycięstwo gracza pierwszego");
  }
  else if((inputPlayerOne == "n" && inputPlayerTwo == "k")
  | (inputPlayerOne == "k" && inputPlayerTwo == "p")
  | (inputPlayerOne == "p" && inputPlayerTwo == "n")){
    WriteLine("Zwycięstwo gracza drugiego");
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