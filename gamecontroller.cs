using System;
using static System.Console;

class GameController {
    string[] gameType = {"RPS","RPSLS"};
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
  WriteLine ("Game Menu - Current game [{0}]:\n[1] Player vs Player\n[2] Player vs AI\n[3] AI vs AI\n[4] Show rules\n[5] Display last games' record\n[6] Change game\n[ESC] Exit", gameType[currentGameTypeIndex]);
  inputKey = ReadKey(true);
  if (inputKey.Key == ConsoleKey.D1){
            if (gameType[currentGameTypeIndex] == "RPS")
                game = new GameRPS();
            else if (gameType[currentGameTypeIndex] == "RPSLS")
                game = new GameRPSLS();
            else
                throw new ArgumentException("No such game");
            game.Play();
            gamesRecord += game.gamesRecord;
        }
     else if (inputKey.Key == ConsoleKey.D2){
            if (gameType[currentGameTypeIndex] == "RPS")
                game = new GameRPS(true);
            else if (gameType[currentGameTypeIndex] == "RPSLS")
                game = new GameRPSLS(true);
            else
                throw new ArgumentException("No such game");
            game.Play();
            gamesRecord += game.gamesRecord;
        }
else if (inputKey.Key == ConsoleKey.D3){
            if (gameType[currentGameTypeIndex] == "RPS")
                game = new GameAI(true);
            else if (gameType[currentGameTypeIndex] == "RPSLS")
                game = new GameAIRPSLS(true);
            else
                throw new ArgumentException("No such game");
            game.Play();
            gamesRecord += game.gamesRecord;
        }
    else if (inputKey.Key == ConsoleKey.D4) {
    DisplayRules(game, false); // false to not display the "Welcome.." part
  }

else if (inputKey.Key == ConsoleKey.D5){
    gamesRecord.DisplayGamesHistory();
  }
  else if (inputKey.Key == ConsoleKey.D6){
    currentGameTypeIndex = (currentGameTypeIndex + 1) % gameType.Length;
    continue;
  }
  else { continue; }
    WriteLine ("(click any key to continue)");
    ReadKey(true);
  } while (inputKey.Key != ConsoleKey.Escape);
}

}
