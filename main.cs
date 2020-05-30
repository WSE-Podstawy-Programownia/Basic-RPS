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
  WriteLine (@"Welcome in the game of Rock-Paper-Scissors!
    Rules are simple - the first player picks Rock, Paper or Scissors enternig accordingly 1, 2 or 3. Next, the second player makes a choice and score is displayed on screen.
    Press any key to continue..");
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
   
   DisplayWelcomeMessage();
    
    Console.ReadKey();
    
    string theFirstPlayerChoiceString = GetPlayerInput("Player One");
    gamesRecord[gamesRecordCurrentIndex, 0] = theFirstPlayerChoiceString;
    // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
    Console.WriteLine ("You've chosen: {0}", theFirstPlayerChoiceString);
    Console.WriteLine ("Press any key to continue..");
    Console.ReadKey();

    // następnie czyścimy konsolę, żeby drugi gracz nie zobaczył wyboru pierwszego
    Console.Clear ();

    
    string theSecondPlayerChoiceString = GetPlayerInput("Player Two");
     gamesRecord[gamesRecordCurrentIndex, 1] = theSecondPlayerChoiceString;
    // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
    Console.WriteLine ("You've chosen: {0}", theSecondPlayerChoiceString);
    Console.WriteLine ("Press any key to continue..");
    Console.ReadKey();

    Console.Clear ();
    DisplayGamesHistory (gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);
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
       static int gamesRecordSize = 0;
    static string[,] gamesRecord = new string[gamesRecordSize, 3];
    static int gamesRecordCurrentIndex = 0;
    static int gamesRecordCurrentSize = 0;

    static void MainMenuLoop (){
      WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
      ConsoleKeyInfo inputKey;
      do {
        inputKey = ReadKey(true);
      } while (inputKey.Key != ConsoleKey.Escape);
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
