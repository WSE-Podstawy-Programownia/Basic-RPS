using System;
using static System.Console;
using System.Collections.Generic;

class GameAIRPSLS : Game {

public GameAIRPSLS (bool singleplayer = false) {
  GameName = "Rock-Paper-Scissors-Lizard-Spock";
  GameRules = "The rules are very simple - each AI player chooses Rock, Paper, Scissors, Lizard or Spock randomly.\nAfter both AI players choose, the winner is determined. After each game the application will ask you if you want to continue, and if you repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!";

  inputTable = new Dictionary<string, string> () 
  {
    {"1", "Rock"},
    {"2", "Paper"},
    {"3", "Scissors"},
    {"4", "Lizard"},
    {"5", "Spock"}
  };
  playerOne = new AIPlayer ();
  playerTwo = new AIPlayer ();
  gamesRecord = new GamesRecord ();
}

public override string GetPlayerInput (Player player){
  string rawInput;
  string properInput;
  WriteLine ("{0}, Choose:\n[1] Rock\n[2] Paper\n[3] Scissors\n[4] Lizard\n[5] Spock", player.PlayerName);
  rawInput = ReadLine();
  while (rawInput != "1" && rawInput != "2" && rawInput != "3" && rawInput != "4" && rawInput != "5") {
      WriteLine ("Wrong input. Please enter correct one.\nPlayer One, choose:\n[1] Rock\n[2] Paper\n[3] Scissors\n[4] Lizard\n[5] Spock");
      rawInput = ReadLine();
  }
  if (rawInput == "1") { properInput = "Rock"; }
  else if (rawInput == "2") { properInput = "Paper"; }
  else if (rawInput == "3") { properInput = "Scissors"; }
  else if (rawInput == "4") { properInput = "Lizard"; }
  else { properInput = "Spock"; }
  return properInput;
}



string DetermineWinner (Player playerOne, Player playerTwo){
    WriteLine ("{0} - {1}", playerOne.LastInput, playerTwo.LastInput);
  if (playerOne.LastInput == playerTwo.LastInput){
      WriteLine ("It's a draw!");
      return "Draw";
  }
  else if ((playerOne.LastInput == "Rock" && playerTwo.LastInput == "Scissors") ||
          (playerOne.LastInput == "Rock" && playerTwo.LastInput == "Lizard") ||
          (playerOne.LastInput == "Paper" && playerTwo.LastInput == "Rock") ||
          (playerOne.LastInput == "Paper" && playerTwo.LastInput == "Spock") ||
          (playerOne.LastInput == "Scissors" && playerTwo.LastInput == "Paper") ||
          (playerOne.LastInput == "Scissors" && playerTwo.LastInput == "Lizard") ||
          (playerOne.LastInput == "Lizard" && playerTwo.LastInput == "Paper") ||
          (playerOne.LastInput == "Lizard" && playerTwo.LastInput == "Spock") ||
          (playerOne.LastInput == "Spock" && playerTwo.LastInput == "Rock") ||
          (playerOne.LastInput == "Spock" && playerTwo.LastInput == "Scissors")){
    Console.WriteLine ("{0} 1 won!", playerOne.PlayerName);
    return String.Format("{0} 1 won!", playerOne.PlayerName);
  }
  else{
    Console.WriteLine ("{0} 2 won!", playerTwo.PlayerName);
    return String.Format("{0} 2 won!", playerTwo.PlayerName);
  }
}


public override void Play () {

    Clear ();
  playerOne.GetInput(inputTable);

  Clear ();
  playerTwo.GetInput(inputTable);

  Clear ();

  string gameResult = DetermineWinner(playerOne, playerTwo);
  gamesRecord.AddRecord(new RecordRPSLS(playerOne.LastInput, playerTwo.LastInput, gameResult));


WriteLine("Do you want to play another round? [y]");
if (ReadKey(true).Key == ConsoleKey.Y){
  Play();
}
}


}

