using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
  while(true){
    string wiadomoscPowitalna = "Graczu pierwszy, wybierz jedną z możliwości: \n1 - Kamień\n2 - Papier\n3 - Nożyce";
    WriteLine(wiadomoscPowitalna);
    string inputPlayerOne;
    inputPlayerOne = ReadLine();
    if(inputPlayerOne == "1"){
      WriteLine("Gracz pierwszy wybrał kamień");
    }
    else if(inputPlayerOne == "2"){
      WriteLine("Gracz pierwszy wybrał papier");
    }
    else if(inputPlayerOne == "3"){
      WriteLine("Gracz pierwszy wybrał nożyce");
    }
    else{
      WriteLine("Gracz wpisał coś niepoprawnego");
    }

    WriteLine("Graczu drugi, wybierz jedną z możliwości:\n1 Kamień\n2 Papier\n3 Nożyce");
    string inputPlayerTwo;
    inputPlayerTwo = ReadLine();
    
    if(inputPlayerTwo == "1"){
      WriteLine("Gracz drugi wybrał kamień");
    }
    else if(inputPlayerTwo == "2"){
      WriteLine("Gracz drugi wybrał papier");
    }
    else if(inputPlayerTwo == "3"){
      WriteLine("Gracz drugi wybrał nożyce");
    }
    else{
      WriteLine("Gracz wpisał coś niepoprawnego");
    }
    
    if(inputPlayerOne == inputPlayerTwo){
      WriteLine("Remis");
    }
    else if((inputPlayerOne == "1" && inputPlayerTwo == "3") 
    || (inputPlayerOne == "2" && inputPlayerTwo == "1")
    || (inputPlayerOne == "3" && inputPlayerTwo == "2")){
      WriteLine("Zwyciestwo gracza pierwszego");
    }
    else if((inputPlayerOne == "3" && inputPlayerTwo == "1") 
    || (inputPlayerOne == "1" && inputPlayerTwo == "2")
    || (inputPlayerOne == "2" && inputPlayerTwo == "3")){
      WriteLine("Zwyciestwo gracza drugi");
    }
    else{
      WriteLine("Wpisano niepoprawne znaki");
    }

    WriteLine("Czy chcesz zakonczyc? [y]");
    string isExit = ReadLine();
    if(isExit == "y"){
      break;
    }
    Clear();
  }
  }
}