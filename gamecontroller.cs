using System;

class GameController {
 Game game;
 GamesRecord gamesRecord ;

 public void MainMenuLoop () {

     WriteLine ("Rock-Paper-Scissors Menu:\n[1] Player vs Player\n[2] Player vs AI\n[3] Show rules\n[4] Display last games' record\n[ESC] Exit");
  inputKey = ReadKey(true);


     if (inputKey.Key == ConsoleKey.D1) {

         game = new Game();
         game.Play();
         gamesRecord += game.gamesRecord;
     }
   else if (inputKey.Key == ConsoleKey.D2){
    game = new Game(true);
    game.Play();
    gamesRecord += game.gamesRecord;
  }
  else if (inputKey.Key == ConsoleKey.D3){
    DisplayRules(game , false);
  }
  else if (inputKey.Key == ConsoleKey.D4){
    gamesRecord.DisplayGamesHistory();
  }



 }

  public GameController () {
      gamesRecord = new GamesRecord();
  }

 public void DisplayRules (Game game, bool withWelcomeMessage = true) {
  if (withWelcomeMessage) {
    WriteLine ("Welcome to a {0} game!", game.GameName);
  }
  WriteLine (game.GameRules);
}


}