using System;
using static System.Console;
class MainClass {
  public static void Main (string[] args) {
     while (true){
      string poczatekrozgrywki = "\n \n Gra Papier, Kamień, Nożyce.\n \n Witaj Graczu NUMER 1! Wybierz jedną z opcji:\n \n1 - Papier \n2 - Kamień \n3 - Nożyce";
      WriteLine(poczatekrozgrywki);
      string InputPlayerOne;
      InputPlayerOne = ReadLine();

      if(InputPlayerOne == "1"){
        WriteLine("wybrałeś PAPIER \n");
      }
      else if(InputPlayerOne =="2"){
        WriteLine("wybrałeś KAMIEŃ \n");
      }
      else if(InputPlayerOne =="3"){
        WriteLine("wybrałeś NOŻYCE \n");
      }
      else{
        WriteLine("NIEPOPRAWNY WYBÓR!\n");
        continue;
      }
      WriteLine("Witaj Graczu NUMER 2! Wybierz jedną z opcji:\n \n1 - Papier \n2 - Kamień \n3 - Nożyce");
      string InputPlayerTwo;
      InputPlayerTwo = ReadLine();

      if(InputPlayerTwo == "1"){
        WriteLine("wybrałeś PAPIER \n");
      }
      else if(InputPlayerTwo =="2"){
        WriteLine("wybrałeś KAMIEŃ \n");
      }
      else if(InputPlayerTwo =="3"){
        WriteLine("wybrałeś NOŻYCE \n");
      }
      else{
        WriteLine("NIEPOPRAWNY WYBÓR!\n");
      }
      WriteLine("Naciśnij cokolwiek żeby poznać wynik rozgrywki\n");
      Read();

      if(InputPlayerOne == InputPlayerTwo){
        WriteLine("Jest REMIS!\n");
      }
      else if((InputPlayerOne == "1" && InputPlayerTwo == "3") 
        || (InputPlayerOne == "2" && InputPlayerTwo == "1")
        || (InputPlayerOne == "3" && InputPlayerTwo == "2")){
          WriteLine("graczu PIERWSZY zwyciężyłeś!\n\n");
          }
      else if((InputPlayerOne == "3" && InputPlayerTwo == "1") 
        || (InputPlayerOne == "1" && InputPlayerTwo == "2")
        || (InputPlayerOne == "2" && InputPlayerTwo == "3")){
          WriteLine("Graczu DRUGI zwyciężyłeś!\n\n");
          }
      else{
        WriteLine("Ktoś dokonał niepoprawnego wyboru!\n\n");
        continue;
        }
      WriteLine("Naciśnij y jeśli chcesz zakończyć");
      string isExit = ReadLine();
      if(isExit == "y"){
        break;
      }
    Clear();
    }
  }
}

