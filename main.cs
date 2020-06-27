using System;
using static System.Console;

class MainClass {
//modyfikować funkcję Main, aby powoływała nowy obiekt tej klasy (zamiast poprzednio stosowanego obiektu Game) i uruchomić MainMenuLoop
//1b-49
  public static void Main (string[] args) {
  GameController gameController = new GameController();
  gameController.MainMenuLoop();
  }
}


  // public static void Main (string[] args) {
  //   // MainMenuLoop();
  //   // Player playerOne = new Player("Player One");
  //   // WriteLine(playerOne.playerName);
  //   // Player playerTwo = new Player();
  //   // WriteLine(playerTwo.playerName);
  //   // GamesRecord gamesRecord = new GamesRecord();
  //   Game game = new Game();
  // }
