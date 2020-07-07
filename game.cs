using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class Game 
{
  Player playerOne, playerTwo;
  public GamesRecord gamesRecord;
  public Game()
  {
    playerOne = new Player();
    playerTwo = new Player();
    gamesRecord = new GamesRecord();
  }

  public string GetPlayerInput (Player player){
    string rawInput;
    string properInput;

    WriteLine ("{0} Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player);
    
    rawInput = ReadLine();
    while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
        WriteLine ("Wrong input. Please enter correct one.\nPlayer One, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
    }

    if (rawInput == "1") { properInput = "Rock"; }
    else if (rawInput == "2") { properInput = "Paper"; }
    else { properInput = "Scissors"; }

    return properInput;
  }

   public string DetermineWinner (string playerOne, string playerTwo){
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

  public void PlayGame ()
  {
    Clear();

    string firstPlayerChoiceString = GetPlayerInput(playerOne);
    
    Clear ();
    
    string secondPlayerChoiceString = GetPlayerInput(playerTwo);
    
    Clear ();

    string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);
    gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult);


    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y)
    {
      PlayGame();
    }
  }
}
