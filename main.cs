using System;
using static System.Console;

class MainClass {

  public static void Main (string[] args) {
    // declaration and initialization of the global game variables
    int gamesRecordSize = 10;
    string[,] gamesRecord = new string[gamesRecordSize,3];
    int gamesRecordCurrentIndex = 0;
    int gamesRecordCurrentSize = 0;
    
    // Welcome message to the game
    WriteLine ("Welcome to a simple Rock-Paper-Scissors game. \nThe rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!\n(click any key to continue)");
    
    // Use the ReadKey() method to get any key as input
    ReadKey();

    do {
      // Clear the console before the round
      Clear();

      // FirstPlayer makes his choice with data validation
      string firstPlayerChoiceString;
      int firstPlayerChoiceInt;
      do {
        WriteLine ("Player One, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");  
      } while (!Int32.TryParse(firstPlayerChoiceString = ReadLine(), out firstPlayerChoiceInt)|| !(firstPlayerChoiceInt > 0 && firstPlayerChoiceInt <= 3));
      // Add the information about the choice to the gamesRecord
      gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;
      
      // Clear the console so the SecondPlayer doesn't see what the FirstPlayer chose
      Clear ();
      
      // SecondPlayer makes his choice with data validation
      string secondPlayerChoiceString;
      int secondPlayerChoiceInt;
      do {
        WriteLine ("Player Two, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");  
      } while (!Int32.TryParse(secondPlayerChoiceString = ReadLine(), out secondPlayerChoiceInt)|| !(secondPlayerChoiceInt > 0 && secondPlayerChoiceInt <= 3));
      gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
      
      // Clear the console before announcing the winner
      Clear ();

      // Check the result
      if (firstPlayerChoiceInt == secondPlayerChoiceInt){
        WriteLine ("It's a draw!");
        gamesRecord[gamesRecordCurrentIndex, 2] = "Draw";
      }
      else if ((firstPlayerChoiceInt == 1 && secondPlayerChoiceInt == 3)
              ||
              (firstPlayerChoiceInt == 2 && secondPlayerChoiceInt == 1)
              ||
              (firstPlayerChoiceInt == 3 && secondPlayerChoiceInt == 2)
      ){
        Console.WriteLine ("Player One won!");
        gamesRecord[gamesRecordCurrentIndex, 2] = "Player One won";
      }
      else{
        Console.WriteLine ("Player Two won!");
        gamesRecord[gamesRecordCurrentIndex, 2] = "Player Two won";
      }

      // Increment the games index counter and current history size
      gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
      if (gamesRecordCurrentSize < gamesRecordSize){
        gamesRecordCurrentSize++;
      }

      // Ask the players if they want to continue
      WriteLine("Do you want to player another round? [y]");
    } while (ReadLine() == "y");

    // Present the games' history
    WriteLine ("Last 10 games went:");
    int currentIndex;
    if (gamesRecordCurrentSize < gamesRecordSize){
      currentIndex = 0;
    }
    else {
      currentIndex = gamesRecordCurrentIndex;
    }
    for (int i = 0; i < gamesRecordCurrentSize; i++){
        WriteLine ("Game #{0}: {1} - {2}, {3}",
        i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
        currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
    }
  }
}

