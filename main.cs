using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
   string[,] gamesRecord = new string[10,3];
   int gamesRecordCurrentIndex = 0;
    // powitanie
    WriteLine ("Welcome in RockPaperScissors game!\n");
    //zasady gry
    WriteLine (" Game rules: \n(1) Push any number from 1 to 3, then [enter] \n(2) Paper wins with rock\n(3) Rock wins with scissors\n(4) Scissors wins with paper");
    WriteLine ("\n [push any key to continue]");
    ReadKey ();
    Clear ();
    // funkja do ... while
     do {
      Clear ();

     //deklaracja player 1
     WriteLine("[Player 1] choose your type:\n(1) Rock\n(2) Paper\n(3) Scissors");
     string player1choose = ReadLine();
     int player1chooseInt;

      // wybierz poprawną liczbę
     while(!Int32.TryParse(player1choose, out player1chooseInt)
     || player1chooseInt > 3
     || player1chooseInt <=0 ){
       WriteLine("Select correct number");
       player1choose = ReadLine();}
     gamesRecord[gamesRecordCurrentIndex, 0] = player1choose;
     Clear ();

     //deklaracja player 2
     WriteLine("[Player 2] choose your type:\n(1) Rock\n(2) Paper\n(3) Scissors");
     string player2choose = ReadLine();
     int player2chooseInt;

     // wybierz poprawną liczbę
     while(!Int32.TryParse(player2choose, out player2chooseInt)
     || player2chooseInt > 3
     || player2chooseInt <=0 ){
       WriteLine("Select correct number");
       player2choose = ReadLine();}
     gamesRecord[gamesRecordCurrentIndex, 1] = player2choose;
     Clear ();

     //rozpisać warunki wygranej
     if (player1choose == player2choose){
      WriteLine ("Remis\n");
        gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";}
     else if (player1choose == "1" && player2choose == "2"){ WriteLine ("Paper beats Rock. Player 2 wins.");
        gamesRecord[gamesRecordCurrentIndex, 2] = "player2";}
     else if (player1choose == "1" && player2choose == "3"){ WriteLine ("Rock beats Scissors. Player 1 wins.");
        gamesRecord[gamesRecordCurrentIndex, 2] = "player1";}
     else if (player1choose == "2" && player2choose == "1"){ WriteLine ("Paper beats Rock. Player 1 wins.");
        gamesRecord[gamesRecordCurrentIndex, 2] = "player1";}
     else if (player1choose == "2" && player2choose == "3"){ WriteLine ("Scissors beat Paper. Player 2 wins.");
        gamesRecord[gamesRecordCurrentIndex, 2] = "player2";}
     else if (player1choose == "3" && player2choose == "1"){ WriteLine ("Rock beats Scissors. Player 2 wins.");
        gamesRecord[gamesRecordCurrentIndex, 2] = "player2";}
     else if (player1choose == "3" && player2choose == "2"){ WriteLine ("Scissors beat Paper. Player 1 wins.");
        gamesRecord[gamesRecordCurrentIndex, 2] = "player1";}
     
     /*gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
     gamesRecord[gamesRecordCurrentIndex, 2] = "player1";
     gamesRecord[gamesRecordCurrentIndex, 2] = "player2";*/
     
     gamesRecordCurrentIndex += 1;
     WriteLine ("\n Do you want to continue? \n [push any key to continue or (n + [enter]) to exit]");

      } while (ReadLine() != "n");
      ReadKey ();
      Clear ();

    WriteLine ("Score");
    for (int i = 0; i < gamesRecordCurrentIndex; i++){
    WriteLine ("Round #{0}: {1} - {2}, player1 wins {3}", i+1, gamesRecord[i,0], gamesRecord[i,1], gamesRecord[i,2]);
    }
  
      /*zrobić funkcje liczenia wyniku
      WriteLine ("Score:");
      WriteLine ("\n Player1\n Player2");
     ReadKey ();
     Clear ();*/
      
  }
}
