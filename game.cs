using System;
using static System.Console;
class Game {
  Player playerOne, playerTwo;
  GamesRecord gamesRecord;
  public Game () {
    playerOne = new Player ();
    playerTwo = new Player ();
    gamesRecord = new GamesRecord ();
    MainMenuLoop ();
  }
  public void DisplayRules (bool withWelcomeMessage = true) {
    if (withWelcomeMessage) {
      WriteLine ("Welcome to a simple Rock-Paper-Scissors game!");
    }
      WriteLine ("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
  }
  public string GetPlayerInput (Player player){
  string rawInput;
  string properInput;
  WriteLine ("{0} Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player.playerName);
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
  public string DetermineWinner (string playerOneChoice, string playerTwoChoice){
    if (playerOneChoice == playerTwoChoice){
      WriteLine ("It's a draw!");
      return "Draw";
    }
    else if ((playerOneChoice == "Rock" && playerTwoChoice == "Scissors") ||
    (playerOneChoice == "Paper" && playerTwoChoice == "Rock")||
    (playerOneChoice == "Scissors" && playerTwoChoice == "Paper")){
      Console.WriteLine ("Player One won!");
      return "Player One won";
    }
    else {
        Console.WriteLine ("Player Two won!");
        return "player Two won";
    }
  }
  public void Play () {
    Clear ();
    string firstPlayerChoiceString = GetPlayerInput(playerOne);
    Clear ();
    string secondPlayerChoiceString = GetPlayerInput(playerTwo);
    Clear ();

    string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);
    gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult);

    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y){
    Play();
    }
  }
  public void MainMenuLoop (){
  ConsoleKeyInfo inputKey;
  do {
    Clear();
    WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
    inputKey = ReadKey(true);
    if (inputKey.Key == ConsoleKey.D1){
      Play();
    }
    else if (inputKey.Key == ConsoleKey.D2){
      DisplayRules(false);
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