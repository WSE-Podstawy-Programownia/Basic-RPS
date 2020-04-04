using System;
using static System.Console;
class MainClass {
  public static void Main (string[] args) {

   string[,] gamesRecord = new string[10,3];
   int gamesRecordCurrentIndex = 0;

  

    gamesRecordCurrentIndex += 1;

     while (true){
      string poczatekrozgrywki = "Gra Papier, Kamień, Nożyce.\n \n Witaj Graczu NUMER 1! Wybierz jedną z opcji:\n \n1 - Papier \n2 - Kamień \n3 - Nożyce";
      WriteLine(poczatekrozgrywki);

      string InputPlayerOne;
      InputPlayerOne = ReadLine();

      string firstPlayerChoiceString = Console.ReadLine();gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;

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

      string secondPlayerChoiceString = Console.ReadLine();gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;

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
        gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
      }
      else if((InputPlayerOne == "1" && InputPlayerTwo == "3") 
        || (InputPlayerOne == "2" && InputPlayerTwo == "1")
        || (InputPlayerOne == "3" && InputPlayerTwo == "2")){
          WriteLine("graczu PIERWSZY zwyciężyłeś!\n\n");
          gamesRecord[gamesRecordCurrentIndex, 2] = "Pierwszy";
          }
      else if((InputPlayerOne == "3" && InputPlayerTwo == "1") 
        || (InputPlayerOne == "1" && InputPlayerTwo == "2")
        || (InputPlayerOne == "2" && InputPlayerTwo == "3")){
          WriteLine("Graczu DRUGI zwyciężyłeś!\n\n");
          gamesRecord[gamesRecordCurrentIndex, 2] = "Drugi";
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

