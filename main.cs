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
    public static void Main(string[] args)
    {
        int gameRecordSize = 10;
        int gameRecordCurrentSize = 0;
        string[,] gameRecord = new string[gameRecordSize, 3];
        int gameRecordCurrentIndex = 0;

        while (true)
        {
            DisplayWelcomeMessage("One");

            string inputPlayerOne = GetPlayerInput("One");
            gameRecord[gameRecordCurrentIndex, 0] = inputPlayerOne;

           DisplayWelcomeMessage("Two");

            string inputPlayerTwo = GetPlayerInput("Two");
            gameRecord[gameRecordCurrentIndex, 1] = inputPlayerTwo;

            gameRecord[gameRecordCurrentIndex, 2] = DetermineWinner(inputPlayerOne, inputPlayerTwo);

            gameRecordCurrentIndex = (gameRecordCurrentIndex + 1) % gameRecordSize;
            if (gameRecordCurrentSize < gameRecordSize)
            {
                gameRecordCurrentSize++;
            }

            WriteLine("DO you want to exit? [y]");
            string isExit = ReadLine();
            if (isExit == "y")
            {
                break;
            }
            Clear();
        }
        DisplayGameHistory (gameRecord, gameRecordSize);
    }
}