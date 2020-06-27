using System;
class GameController {
    Game game;
    GamesRecord gamesRecord;
    public GameController () {
      gamesRecord = new GamesRecord();
    }

    public void DisplayRules (bool withWelcomeMessage = true) {
        if (withWelcomeMessage) {
            Console.WriteLine ("Welcome to a simple Rock-Paper-Scissors game!");
    }

    Console.WriteLine ("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
    }

    
    public void MainMenuLoop (){

        // funkcja glownej petli 

        ConsoleKeyInfo inputKey;

        do {
            Console.Clear();

            Console.WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
            inputKey = Console.ReadKey(true);

            if (inputKey.Key == ConsoleKey.D1){
                //po wybraniu Play tworzyła nowy obiekt Game i na nim wywoływała metodę Play 1b-48
                game = new Game();
                game.Play();
                gamesRecord += game.gamesRecord;
                //dodawanie po zakończeniu rozgrywki instrukcji dodającą GamesRecord trzymany w obiekcie klasy
                // GameController z obiektem Game, który właśnie skończył wykonywać swoją metodę Play
            }
            
            //dostępnienie graczowi odpowiedniego wyboru w menu gry.  single/multi
            else if (inputKey.Key == ConsoleKey.D2){
                game = new Game(true);
                game.Play();
                gamesRecord += game.gamesRecord;
            }

            else if (inputKey.Key == ConsoleKey.D3){
                DisplayRules(false);
            }

            else if (inputKey.Key == ConsoleKey.D4){
                gamesRecord.DisplayGamesHistory();
        }

            else { continue; }
            Console.WriteLine ("(click any key to continue)");
            Console.ReadKey(true);
            } 
        while (inputKey.Key != ConsoleKey.Escape);
    }
}
