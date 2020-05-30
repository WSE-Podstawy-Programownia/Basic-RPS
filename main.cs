using System;
using static System.Console;

class MainClass
{
  static void DisplayGameHistory (string[,] gameRecord, int gameRecordSize, int gameRecordCurrentSize = 10, int lastRecordIndex = 0){
   int currentIndex;
  if (gameRecordCurrentSize < gameRecordSize){
  currentIndex = 0;
  }
  else {
  currentIndex = lastRecordIndex;
  }
  WriteLine ("Game score:");
  for (int i = 0; i < gameRecordCurrentSize; i++){
  WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gameRecord[currentIndex,0], gameRecord[currentIndex,1], gameRecord[currentIndex,2]);
  currentIndex = (currentIndex + 1) % gameRecordCurrentSize;
  }
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
  static string GetPlayerInput (string playerNumber){
   string rawInput;
   string properInput;
   WriteLine ("Choose one: \n1 - Rock\n2 - Paper\n3 - Scissors");
   rawInput = ReadLine();
   while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
     WriteLine ("Wrong input. Please enter correct one.\nChoose one:\n[1] Rock\n[2] Paper\n[3] Scissors");
   rawInput = ReadLine();
   }

   if (rawInput == "1") { properInput = "Rock"; }
   else if (rawInput == "2") { properInput = "Paper"; }
   else { properInput = "Scissors"; }

   WriteLine("Player " + playerNumber + " choose " + properInput);

   return properInput;
}

  static void DisplayWelcomeMessage (string playerNumber){
    WriteLine ("Welcome Player " + playerNumber + "!");
    ReadKey();
    Clear();
  }
  static int gameRecordSize = 10;
  static int gameRecordCurrentSize = 0;
  static string[,] gameRecord = new string[gameRecordSize, 3];
  static int gameRecordCurrentIndex = 0;

  static void PlayGame(){
    Clear();
    DisplayWelcomeMessage("One");

   string firstPlayerChoiceString = GetPlayerInput("One");
   gameRecord[gameRecordCurrentIndex, 0] = firstPlayerChoiceString;
   Clear ();
    DisplayWelcomeMessage("Two");

   string secondPlayerChoiceString = GetPlayerInput("Two");
   gameRecord[gameRecordCurrentIndex, 1] = secondPlayerChoiceString;
   Clear ();
   gameRecord[gameRecordCurrentIndex, 2] = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);
   gameRecordCurrentIndex = (gameRecordCurrentIndex + 1) % gameRecordSize;
   if (gameRecordCurrentSize < gameRecordSize){
      gameRecordCurrentSize++;
    }
    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y){
      PlayGame();
    }
  }

  static void MainMenuLoop (){
      ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Game Score\n\t[ESC] Exit");
            inputKey = ReadKey(true);
        if (inputKey.Key == ConsoleKey.D1)
        {
            PlayGame();
        }
        else if (inputKey.Key == ConsoleKey.D2)
        {
            WriteLine("No rules, anarchy!");
            WriteLine("(click any key to continue)");
            ReadKey(true);
        }
        else if (inputKey.Key == ConsoleKey.D3)
        {
            DisplayGameHistory(gameRecord, gameRecordSize, gameRecordCurrentSize, gameRecordCurrentIndex);

            WriteLine("(click any key to continue)");
            ReadKey(true);
        }
        }
        while (inputKey.Key != ConsoleKey.Escape);
   }
    public static void Main(string[] args)
    {
     Player playerOne = new Player("Player One");
     WriteLine(playerOne.playerName);
    }
}