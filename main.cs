using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    string wiadomoscPowitalna = "Wybór P1:\n1. Rock\n2. Paper\n3. Scissors ";
    WriteLine(wiadomoscPowitalna);
    string inputPlayerOne;
    inputPlayerOne = ReadLine();
    
   if(inputPlayerOne == "1"){
     WriteLine("Gracz pierwszy wybrał kamień");
   }
   else if (inputPlayerOne == "2"){
     WriteLine("Gracz pierwszy wybrał papier");
     }
  else if (inputPlayerOne == "3"){
    WriteLine("Gracz pierwszy wybrał nożyce");
    }
   else{
     WriteLine("Błędny wybór");
   }

   WriteLine("Wybór P2:\n1. Rock\n2. Paper\n3. Scissors ");
    string inputPlayerTwo;
    inputPlayerTwo = ReadLine();

  if(inputPlayerTwo == "1"){
      WriteLine("Gracz drugi wybrał kamień");
   }
   else if (inputPlayerTwo == "2"){
     WriteLine("Gracz drugi wybrał papier");
     }
  else if (inputPlayerTwo == "3"){
    WriteLine("Gracz drugi wybrał nożyce");
    }
   else{
     WriteLine("Błędny wybór");
  }

  if(inputPlayerOne == inputPlayerTwo){
    WriteLine("Remis");
  }
  else if((inputPlayerOne == "1" && inputPlayerTwo == "3")
  | (inputPlayerOne == "2" && inputPlayerTwo == "1")
  | (inputPlayerOne == "3" && inputPlayerTwo == "2")){
    WriteLine("Zwycięstwo gracza pierwszego");
  }
  else if((inputPlayerOne == "3" && inputPlayerTwo == "1")
  | (inputPlayerOne == "1" && inputPlayerTwo == "2")
  | (inputPlayerOne == "2" && inputPlayerTwo == "3")){
    WriteLine("Zwycięstwo gracza drugiego");
  }
  else{
    WriteLine("Wpisano niepoprawne znaki");
  }
  }
}