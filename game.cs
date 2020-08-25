using System;
using static System.Console;

class Game {
  Player playerOne, playerTwo;
  GamesRecord gamesRecord;

  public Game () {
    playerOne = new Player ();
    playerTwo = new Player ();
    gamesRecord = new GamesRecord ();
  }


  public string GetPlayerInput (Player player){
    // Variable declaration
    string rawInput;
    string properInput;

    // Prompt for input
    WriteLine ("{0}, Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player.playerName);
    
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

  public string DetermineWinner (string playerOneChoice, string playerTwoChoice){
    if (playerOneChoice == playerTwoChoice){
        WriteLine ("It's a draw!");
        return "Draw";
    }
    else if ((playerOneChoice == "Rock" && playerTwoChoice == "Scissors") ||
            (playerOneChoice == "Paper" && playerTwoChoice == "Rock") ||
            (playerOneChoice == "Scissors" && playerTwoChoice == "Paper")){
      Console.WriteLine ("Player One won!");
      return "Player One won";
    }
    else{
      Console.WriteLine ("Player Two won!");
      return "Player Two won";
    }
  }

  public void Play (){
    // Clear the console before the round
    Clear();

    // FirstPlayer makes his choice with data validation
    string firstPlayerChoiceString = GetPlayerInput(playerOne);
        
    // Clear the console so the SecondPlayer doesn't see what the FirstPlayer chose
    Clear ();
    
    // SecondPlayer makes his choice with data validation
    string secondPlayerChoiceString = GetPlayerInput(playerTwo);
    
    // Clear the console before announcing the winner
    Clear ();

    // Check and display the result
    string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

    // Add data to GamesRecord
    gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult);
    
    // Ask the players if they want to continue
    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y){
      Play();
    }
  }

 
}