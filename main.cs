using System;
using static System.Console;

class MainClass {

  static void DisplayWelcomeMessage (){
   WriteLine ("Welcome to a simple Rock-Paper-Scissors game. \nThe rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!\n(click any key to continue)");
}

  static string GetPlayerInput (){
   // Variable declaration
   string rawInput;
   string properInput;
   WriteLine ("Choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
   rawInput = ReadLine();
   while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
   WriteLine ("Wrong input. Please enter correct one.\nChoose:\n[1] Rock\n[2] Paper\n[3] Scissors");
   rawInput = ReadLine();
   }
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
else {
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
  WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
  currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
}

}





  public static void Main (string[] args) {
    // declaration and initialization of the global game variables
    int gamesRecordSize = 10;
    string[,] gamesRecord = new string[gamesRecordSize,3];
    int gamesRecordCurrentIndex = 0;
    int gamesRecordCurrentSize = 0;
    
   DisplayWelcomeMessage();

    // Use the ReadKey() method to get any key as input
    ReadKey();

    do {
      // Clear the console before the round
      Clear();

      // FirstPlayer makes his choice with data validation
     string firstPlayerChoiceString = GetPlayerInput();
     gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;

      
      // Clear the console so the SecondPlayer doesn't see what the FirstPlayer chose
      Clear ();
      
      // SecondPlayer makes his choice with data validation
     string secondPlayerChoiceString = GetPlayerInput();
     gamesRecord[gamesRecordCurrentIndex, 0] = secondPlayerChoiceString;
      
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
      WriteLine("Do you want to player another round? [y]");
    } while (ReadLine() == "y");

    // Present the games' history
DisplayGamesHistory (gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);
    
  }
}