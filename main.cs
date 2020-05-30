using System;
using static System.Console;

class MainClass {

  public static void Main (string[] args) {
  Player playerOne = new Player();
  playerOne.playerName = "Player One";
  WriteLine(playerOne.playerName);
  Player playerTwo = new Player();
  WriteLine(playerTwo.playerName);
  GamesRecord gamesRecord = new GamesRecord();
  Game game = new Game();

  }
}