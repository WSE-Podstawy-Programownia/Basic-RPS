using System;
using static System.Console;

class GameController {
    string[] gameType = {"RPS","Sic Mundus"};
     int currentGameTypeIndex = 0;
    Game game;
    GamesRecord gamesRecord;
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

        // funkcja glownej petli 

        ConsoleKeyInfo inputKey;

        do {
            Console.Clear();

            Console.WriteLine ("Game Menu - Current game [{0}]:\n[1] Player vs Player\n[2] Player vs AI\n[3] Show rules\n[4] Display last games' record\n[5] Change game\n[ESC] Exit", gameType[currentGameTypeIndex]);
            inputKey = Console.ReadKey(true);

            if (inputKey.Key == ConsoleKey.D1){
                //po wybraniu Play tworzyła nowy obiekt Game i na nim wywoływała metodę Play 1b-48
                if (gameType[currentGameTypeIndex] == "RPS")
                    game = new GameRPS();
                else if (gameType[currentGameTypeIndex] == "MyNewGame")
                    game = new SicMundusGame();
                else
                    throw new ArgumentException("No such game");
                game.Play();
                gamesRecord += game.gamesRecord;
            }
            
            //udostępnienie graczowi odpowiedniego wyboru w menu gry.  single/multi
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
            Console.WriteLine ("(click any key to continue)");
            Console.ReadKey(true);
            } 
            while (inputKey.Key != ConsoleKey.Escape);
    }
}
