using System;


class GameController {
        Game game;
        GamesRecord gamesRecord;

        public GameController () {
      
                  gamesRecord = new GamesRecord();
        
        }

      public void MainMenuLoop (){

      // funkcja odpowiedzialna za pętle glownego menu

  ConsoleKeyInfo inputKey;
   

  do {
     Console.Clear();
           
            Console.WriteLine ("Rock-Paper-Scissors Menu:\n\t [1] Player vs player\n\t [2] Player vs. AI\n\t [3] Show rules \n\t [4] Display last games' record\n\t [ESC] Exit");
            inputKey = Console.ReadKey(true);

      if (inputKey.Key == ConsoleKey.D1){
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
            //game = new Game();
            game.DisplayRules(false);
        }
      else if (inputKey.Key == ConsoleKey.D4){
            gamesRecord.DisplayGamesHistory();

      }
      else { continue; }
          Console.WriteLine ("(Press any key to continue)");
            Console.ReadKey(true);

    
    } 
  while (inputKey.Key != ConsoleKey.Escape);


}
}
  
  
  
  
  
  



    





