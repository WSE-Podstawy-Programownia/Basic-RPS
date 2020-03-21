using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
      WriteLine("Player One, choose RPS:\n(1) Rock\n(2) Paper\n(3) Scissors");
      string inputPlayerOne;
      inputPlayerOne = ReadLine();

      if(inputPlayerOne == "1"){
        WriteLine("Wybrałeś kamień");
      }

      else if(inputPlayerOne == "2"){
        WriteLine("wybrałeś papier");
      }
      
      else if(inputPlayerOne == "3"){
        WriteLine("wybrałeś nożyce");
      }

      else{
        WriteLine("cos niepoprawnego");
      }

      WriteLine("Player Two, choose RPS:\n(1) Rock\n(2) Paper\n(3) Scissors");
      string inputPlayerTwo;
      inputPlayerTwo = ReadLine();

      if(inputPlayerTwo == "1"){
        WriteLine("Wybrałeś kamień");
      }

      else if(inputPlayerTwo == "2"){
        WriteLine("wybrałeś papier");
      }
      
      else if(inputPlayerTwo == "3"){
        WriteLine("wybrałeś nożyce");
      }

      else{
        WriteLine("cos niepoprawnego");
      }

      if(inputPlayerOne == inputPlayerTwo){
        WriteLine("remis");
      }

      else if((inputPlayerOne == "1" && inputPlayerTwo == "3")
       || (inputPlayerOne == "2" && inputPlayerTwo == "1")
       || (inputPlayerOne == "3" && inputPlayerTwo == "2")){
          WriteLine("zwycieza gracz1");
        }

         else if((inputPlayerTwo == "1" && inputPlayerOne == "3")
       || (inputPlayerTwo == "2" && inputPlayerOne == "1")
       || (inputPlayerTwo == "3" && inputPlayerOne == "2")){
          WriteLine("zwycieza gracz2");
        }


      

      

  }
}