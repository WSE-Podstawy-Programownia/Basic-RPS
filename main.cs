using System;
using static System.Console;

class MainClass {

  // Declaration and initialization of the global game variables
  static int gamesRecordSize = 10;
  static string[,] gamesRecord = new string[gamesRecordSize,3];
  static int gamesRecordCurrentIndex = 0;
  static int gamesRecordCurrentSize = 0;

  static void DisplayWelcomeMessage (){
    WriteLine ("Welcome to a simple Rock-Paper-Scissors game. \nThe rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
  }

  static string GetPlayerInput (string player){
    // Variable declaration
    string rawInput;
    string properInput;

    // Prompt for input
    WriteLine ("{0} Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player);
    
    // Get player input
    rawInput = ReadLine();

    // Verify input and reprompt if wrong
    while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
        WriteLine ("Wrong input. Please enter correct one.\nPlayer One, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
    }

    // Translate the raw input into proper one
    if (rawInput == "1") { properInput = "Rock"; }
    else if (rawInput == "2") { properInput = "Paper"; }
    else { properInput = "Scissors"; }

    return properInput;
  }

  static string DetermineWinner (string playerOne, string playerTwo){
    if (playerOne == playerTwo){
        WriteLine ("It's a draw!");
        return "Draw";
    }
    else if ((playerOne == "Rock" && playerTwo == "Scissors") ||
            (playerOne == "Paper" && playerTwo == "Rock") ||
            (playerOne == "Scissors" && playerTwo == "Paper")){
      Console.WriteLine ("Player One won!");
      return "Player One won";
    }
    else{
      Console.WriteLine ("Player Two won!");
      return "Player Two won";
    }
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
    for (int i = 0; i < gamesRecordCurrentSize; i++){
        WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}",
        i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
        currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
    }
  }

  static void PlayGame (){
    // Clear the console before the round
    Clear();

    // FirstPlayer makes his choice with data validation
    string firstPlayerChoiceString = GetPlayerInput("Player One");
    
    // Add the information about the choice to the gamesRecord
    gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;
    
    // Clear the console so the SecondPlayer doesn't see what the FirstPlayer chose
    Clear ();
    
    // SecondPlayer makes his choice with data validation
    string secondPlayerChoiceString = GetPlayerInput("Player Two");
    
    // Add the information about the choice to the gamesRecord
    gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
    
    // Clear the console before announcing the winner
    Clear ();

    // Check the result
    gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

    // Increment the games index counter and current history size
    gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
    if (gamesRecordCurrentSize < gamesRecordSize){
      gamesRecordCurrentSize++;
    }

      // Ask the players if they want to continue
    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y){
      PlayGame();
    }
  }

  static void MainMenuLoop (){
    // Declare the variable used for input
    ConsoleKeyInfo inputKey;

    // Control the effect of input to call a proper function
    do {
      // Clear the console
      Clear();
      // Write the menu message
      WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
      inputKey = ReadKey(true);
      if (inputKey.Key == ConsoleKey.D1){
        PlayGame();
      }
      else if (inputKey.Key == ConsoleKey.D2){
        DisplayWelcomeMessage();
      }
      else if (inputKey.Key == ConsoleKey.D3){
        DisplayGamesHistory (gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);
      }
      else { continue; }
      WriteLine ("(click any key to continue)");
      ReadKey(true);
    } while (inputKey.Key != ConsoleKey.Escape);
  }


  public static void Main (string[] args) {
     MainMenuLoop();
  Player playerOne = new Player();
  playerOne.playerName = "Player One";
  WriteLine(playerOne.playerName);
  Player playerTwo = new Player();
  WriteLine(playerTwo.playerName);

  }
}