using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {

    while(true){WriteLine("Witaj graczu pierwszy! Wybierz:\n(1) Kamień\n(2) Papier\n(3) Nożyczki");
      string inputPlayerOne;
      inputPlayerOne = ReadLine();

      if(inputPlayerOne == "1"){
        WriteLine("Wybrałeś kamień");
      }

      else if(inputPlayerOne == "2"){
        WriteLine("Wybrałeś papier");
      }
      
      else if(inputPlayerOne == "3"){
        WriteLine("Wybrałeś nożyce");
      }

      else{
        WriteLine("Niepoprawny znak");
      }

      WriteLine("Naciśnij cokolwiek");
      ReadKey();
      Clear();

      WriteLine("Dzień dobry graczu drugi, wybierz:\n(1) Kamień\n(2) Papier\n(3) Nożyczki");
      string inputPlayerTwo;
      inputPlayerTwo = ReadLine();

      if(inputPlayerTwo == "1"){
        WriteLine("Wybrałeś kamień, świetna decyzja");
      }

      else if(inputPlayerTwo == "2"){
        WriteLine("Wybrałeś papier");
      }
      
      else if(inputPlayerTwo == "3"){
        WriteLine("Wybrałeś nożyce");
      }

      else{
        WriteLine("Wpisz poprawną liczbę!");
      }

      if(inputPlayerOne == inputPlayerTwo){
        WriteLine("remis :(");
      }

      else if((inputPlayerOne == "1" && inputPlayerTwo == "3")
       || (inputPlayerOne == "2" && inputPlayerTwo == "1")
       || (inputPlayerOne == "3" && inputPlayerTwo == "2")){
          WriteLine("Zwycięzcą jest gracz 1!");
        }

         else if((inputPlayerTwo == "1" && inputPlayerOne == "3")
       || (inputPlayerTwo == "2" && inputPlayerOne == "1")
       || (inputPlayerTwo == "3" && inputPlayerOne == "2")){
          WriteLine("Gratulacje, graczu 2. Wygrałeś.");
        }

      WriteLine("Czy chcesz wyjść? [y]");
      string isExit = ReadLine();

      if(isExit == "y"){
        break;
      }
      Clear();
    }


      

      

  }
}