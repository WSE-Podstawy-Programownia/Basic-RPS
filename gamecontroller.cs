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
    
     Console.WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
       
      inputKey = Console.ReadKey(true);

      if (inputKey.Key == ConsoleKey.D1){
            game = new Game();
            game.Play();
            gamesRecord += game.gamesRecord;
        }

      else if (inputKey.Key == ConsoleKey.D2){
            game.DisplayRules(false);
        }
      else if (inputKey.Key == ConsoleKey.D3){
            gamesRecord.DisplayGamesHistory();

      }
      else { continue; }
          Console.WriteLine ("(Press any key to continue)");
            Console.ReadKey(true);

    
    } 
  while (inputKey.Key != ConsoleKey.Escape);


}
}
  
  
  
  
  
  



    





