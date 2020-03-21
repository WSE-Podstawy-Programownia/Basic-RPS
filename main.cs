using System;
using static System.Console;
class MainClass {
  public static void Main (string[] args) {
    while(true){
      string poczatekrozgrywki = "Gra Papier, Kamień, Nożyce. Witaj Graczu NUMER 1! Wybierz jedną z opcji: \n1 - Papier \n2 - Kamień \n3 - Nożyce";
      WriteLine(poczatekrozgrywki);
      string InputPlayerOne;
      InputPlayerOne = ReadLine();

      if(InputPlayerOne == "1"){
        WriteLine("wybrałeś PAPIER");
      }
      else if(InputPlayerOne =="2"){
        WriteLine("wybrałeś KAMIEŃ");
      }
      else if(InputPlayerOne =="3"){
        WriteLine("wybrałeś NOŻYCE");
      }
      else{
        WriteLine("NIEPOPRAWNY WYBÓR!");
      }
      WriteLine("Witaj Graczu NUMER 2! Wybierz jedną z opcji: \n1 - Papier \n2 - Kamień \n3 - Nożyce");
      string InputPlayerTwo;
      InputPlayerTwo = ReadLine();

      if(InputPlayerTwo == "1"){
        WriteLine("wybrałeś PAPIER");
      }
      else if(InputPlayerTwo =="2"){
        WriteLine("wybrałeś KAMIEŃ");
      }
      else if(InputPlayerTwo =="3"){
        WriteLine("wybrałeś NOŻYCE");
      }
      else{
        WriteLine("NIEPOPRAWNY WYBÓR!");
      }
      if(InputPlayerOne == InputPlayerTwo){
        WriteLine("Jest REMIS!");
      }
      else if((InputPlayerOne == "1" && InputPlayerTwo == "3") 
        || (InputPlayerOne == "2" && InputPlayerTwo == "1")
        || (InputPlayerOne == "3" && InputPlayerTwo == "2")){
          WriteLine("graczu PIERWSZY zwyciężyłeś!");
          }
      else if((InputPlayerOne == "3" && InputPlayerTwo == "1") 
        || (InputPlayerOne == "1" && InputPlayerTwo == "2")
        || (InputPlayerOne == "2" && InputPlayerTwo == "3")){
          WriteLine("Graczu DRUGI zwyciężyłeś!");
          }
      else{
        WriteLine("Ktoś dokonał niepoprawnego wyboru!");
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

