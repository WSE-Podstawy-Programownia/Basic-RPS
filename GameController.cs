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
    Clear();
    WriteLine ("Game Menu - Current game [{0}]:\n[1] Player vs Player\n[2] Player vs AI\n[3] Show rules\n[4] Display last games' record\n[5] Change game\n[ESC] Exit",
     gameType[currentGameTypeIndex]);
  inputKey = ReadKey(true);
    if (inputKey.Key == ConsoleKey.D1){
     if (gameType[currentGameTypeIndex] == "RPS")
      game = new GameRPS();
    else if (gameType[currentGameTypeIndex] == "Rzut Moneta")
      game = new Moneta();
    else
      throw new ArgumentException("Brak Gry");
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
    WriteLine ("(click any key to continue)");
    ReadKey(true);
  } while (inputKey.Key != ConsoleKey.Escape);
}

}
