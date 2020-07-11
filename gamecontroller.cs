using System;


class GameController {
        Game game;
        GamesRecord gamesRecord;
        
        string[] gameType = {"RPS","Dice"};
        int currentGameTypeIndex = 0;


 

        public GameController () {
      
                  gamesRecord = new GamesRecord();
        
        }


        public void DisplayRules (Game game, bool withWelcomeMessage = true) {
        
          if (withWelcomeMessage) {
            
            Console.WriteLine ("Welcome to a {0} game!", game.GameName);
            }
          
            Console.WriteLine (game.GameRules);
          
          }

      public void MainMenuLoop (){

      // funkcja odpowiedzialna za pętle glownego menu

  ConsoleKeyInfo inputKey;
   

  do {
     Console.Clear();
           
            //Console.WriteLine ("Rock-Paper-Scissors Menu:\n\t [1] Player vs player\n\t [2] Player vs. AI\n\t [3] Show rules \n\t [4] Display last games' record\n\t [ESC] Exit");
            
            Console.WriteLine ("Game Menu - Current game [{0}]:\n[1] Player vs Player\n[2] Player vs AI\n[3] Show rules\n[4] Display last games' record\n[5] Change game\n[ESC] Exit", gameType[currentGameTypeIndex]);
            
            
            inputKey = Console.ReadKey(true);

      if (inputKey.Key == ConsoleKey.D1){
            game = new GameRPS();
            game.Play();
            gamesRecord += game.gamesRecord;
        }
      else if (inputKey.Key == ConsoleKey.D2){
          game = new GameRPS(true);
          game.Play();
          gamesRecord += game.gamesRecord;
  }

      else if (inputKey.Key == ConsoleKey.D3){
            //game = new Game();
            DisplayRules(game, false); // false = do not display welcome message
        }
      else if (inputKey.Key == ConsoleKey.D4){
            gamesRecord.DisplayGamesHistory();

      }

        else if (inputKey.Key == ConsoleKey.D5){
            
            currentGameTypeIndex = (currentGameTypeIndex + 1) % gameType.Length;
            
            continue;
      }
      else { continue; }
          Console.WriteLine ("(Press any key to continue)");
          Console.ReadKey(true);

    
    } 
  while (inputKey.Key != ConsoleKey.Escape);


}
}
  
  
  
  
  
  



    





