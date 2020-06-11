using System;
using static System.Console;
class MainClass {
  static string DetermineWinner (string playerOne, string playerTwo){
    if (playerOne == playerTwo){
      WriteLine ("It's a draw!");
      return "Draw";
    }
    else if ((playerOne == "Rock" && playerTwo == "Scissors") ||
    (playerOne == "Paper" && playerTwo == "Rock")||
    (playerOne == "Scissors" && playerTwo == "Paper")){
      Console.WriteLine ("Player One won!");
      return "Player One won";
    }
    else {
        Console.WriteLine ("Player Two won!");
        return "player Two won";
      }
    }

  enum Choices {
    Rock,
    Paper,
    Scissors
  };
static void DisplayWelcomeMessage (){
  WriteLine ("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
}
static string GetPlayerInput (string player){
  string rawInput;
  string properInput;
  WriteLine ("{0} Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player);
    rawInput = ReadLine();
    while (rawInput != "1" && rawInput != "2" && rawInput != "3"){
      WriteLine ("Wrong input. Please enter correct choice.\nChoose:\n[1] Rock\n[2] Paper\n[3] Scissors");
      rawInput = ReadLine();
    }
      if (rawInput == "1") { properInput = "Rock"; }
      else if (rawInput == "2") { properInput = "Paper"; }
      else { properInput = "Scissors"; }
      return properInput;
  }
    
  public static void Main (string[] args) {
  Game game = new Game();
  }

   static void DisplayGamesHistory (string[,] gamesRecord, int gamesRecordSize, int gamesRecordCurrentSize = 10, int lastRecordIndex = 0){
      int currentIndex;
      if (gamesRecordCurrentSize < gamesRecordSize){
        currentIndex = 0;
      }
      else {
        currentIndex = lastRecordIndex;
      }
      WriteLine ("Last games history:");
      for (int i =0; i < gamesRecordCurrentSize; i++){
        WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
        currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
        }
       }
       static int gamesRecordSize = 10;
    static string[,] gamesRecord = new string[gamesRecordSize, 3];
    static int gamesRecordCurrentIndex = 0;
    static int gamesRecordCurrentSize = 0;

    static void MainMenuLoop (){
      WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
      ConsoleKeyInfo inputKey;

      do {
        Clear();
        WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
        inputKey = ReadKey(true);
        if (inputKey.Key == ConsoleKey.D1){
        PlayGame();
      }
      else if (inputKey.Key == ConsoleKey.D2){
        DisplayWelcomeMessage();
      }
      else if (inputKey.Key == ConsoleKey.D3){
       DisplayGamesHistory (gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);}
        else { continue;}
        WriteLine ("(click any key to continue)");
        ReadKey(true);
      } while (inputKey.Key != ConsoleKey.Escape);
      
    }
    static void PlayGame (){
      Clear ();
      string firstPlayerChoiceString = GetPlayerInput("Player One");
      gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;
      Clear ();
      string secondPlayerChoiceString = GetPlayerInput("Player Two");
      gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
      Clear ();
      gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);
      gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
      if (gamesRecordCurrentSize < gamesRecordSize){
        gamesRecordCurrentSize++;
      WriteLine("Do you want to play another round? [y]");
      if (ReadKey(true).Key == ConsoleKey.Y){
        PlayGame();
      }
      }
    }
}
