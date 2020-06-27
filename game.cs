using System;
using static System.Console;

class Game {
  Player playerOne, playerTwo;

  public GamesRecord gamesRecord;

  public Game (bool singleplayer = false) {
    playerOne = new Player ();
    if (singleplayer) playerTwo = new AIPlayer ();
    else  playerTwo = new Player ();
    gamesRecord = new GamesRecord (); 
    }

    Dictionary<string, string> inputTable = new Dictionary<string, string> () 
    {
      {"1", "Rock"},
      {"2", "Paper"},
      {"3", "Scissors"}
    };

    

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

  public string DetermineWinner (string playerOne, string playerTwo){
    if (playerOne.lastInput == playerTwo.lastInput){
        WriteLine ("It's a draw!");
        return "Draw";
    }
    else if ((playerOne.lastInput == "Rock" && playerTwo.lastInput == "Scissors") ||
            (player.lastInput == "Paper" && player.lastInput == "Rock") ||
            (playerOne.lastInput == "Scissors" && playerTwo.lastInput == "Paper")){
      Console.WriteLine ("{0} won!", playerOne.playerName);
      return String.Format("{0} won!", playerOne.playerName);
    }
    else{
     Console.WriteLine ("{0} won!", playerTwo.playerName);
    return String.Format("{0} won!", playerTwo.playerName);
    }
  }

  public void Play (){
    
    Clear();

    playerOne.GetInput(inputTable);
    
        
    
    Clear ();
    
    playerTwo.GetInput(inputTable);
    
    
    
    Clear ();

    
    string gameResult = DetermineWinner(playerOne, playerTwo);

    
    gamesRecord.AddRecord(playerOne.lastInput, playerTwo.lastInput, gameResult);
    
    
    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y){
      Play();
    }
  }

  public void MainMenuLoop (){
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
        Play();
      }
      else if (inputKey.Key == ConsoleKey.D2){
        DisplayRules(false); // false to not display the "Welcome.." part
      }
      else if (inputKey.Key == ConsoleKey.D3){
        gamesRecord.DisplayGamesHistory();
      }
      else { continue; }
      WriteLine ("(click any key to continue)");
      ReadKey(true);
    } while (inputKey.Key != ConsoleKey.Escape);
  }
}