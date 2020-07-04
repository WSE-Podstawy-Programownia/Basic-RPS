using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class GameController {
    string[] gameType = {"RPS","???"};
    int currentGameTypeIndex = 0;
    Game game;
    GamesRecord gamesRecord;
    public GameController () {
        gamesRecord = new GamesRecord();
    }
    public void DisplayRules (Game game, bool withWelcomeMessage = true) {
       if (withWelcomeMessage) {
WriteLine ("Welcome to a {0} game!", game.GameName);
}
WriteLine (game.GameRules);
    }   

    public void MainMenuLoop (){
    ConsoleKeyInfo inputKey;
    do {
      Console.Clear();
      WriteLine ("Papier Kamień Nożyce Menu:\n\t[1] Zagraj w grę: multiplayer\n\t[2] Zagraj w grę: singleplayer\n\t[3] Pokaż zasady\n\t[4] Wyświetl poprzednie rozgrywki\n\t[5] Zmień gre\n\t[ESC] Exit", gameType[currentGameTypeIndex]);
      inputKey = ReadKey(true);
      if (inputKey.Key == ConsoleKey.D1){
        if (gameType[currentGameTypeIndex] == "RPS")
        game = new GameRPS();
        /*else if (gameType[currentGameTypeIndex] == "MyNewGame")
        game = new GameMyGame();*/
        else
        throw new ArgumentException("No such game");
        game.Play();
        gamesRecord += game.gamesRecord;
      }
     else if (inputKey.Key == ConsoleKey.D2){
        game = new GameRPS(true);
        game.Play();
        gamesRecord += game.gamesRecord;
      }
      else if (inputKey.Key == ConsoleKey.D3){
        DisplayRules(game, false);
      }
      else if (inputKey.Key == ConsoleKey.D4){
      gamesRecord.DisplayGamesHistory();
      }
      else if (inputKey.Key == ConsoleKey.D5){
      currentGameTypeIndex = (currentGameTypeIndex + 1) % gameType.Length;
      continue;
      }
      else { continue; }
        WriteLine ("Wciśnij dowolny przycisk");
        ReadKey(true);
    } 
      while(inputKey.Key != ConsoleKey.Escape);
    }
}