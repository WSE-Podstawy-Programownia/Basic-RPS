using System;
using static System.Console;

class GameController 
{
    string[] gameType = {"RPS", "My New Game"};
    int currentGameTypeIndex = 0;
    Game game;
    GamesRecord gamesRecord;

    public GameController ()
    {
        gamesRecord = new GamesRecord();
    }
    public void DisplayWelcomeMessage (bool withWelcomeMessage = true)
    {
        if (withWelcomeMessage)
        {
            WriteLine ("Welcome to a {0} game!", game.GameName);
        }
            WriteLine (game.GameRules);
    }

    public void MainMenuLoop ()
    {
        ConsoleKeyInfo inputKey;
        do 
        {
            Clear();
            WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Player vs Player\n\t[2] Player vs AI\n\t[3] Show rules\n\t[4] Display last games record\n\t[5] Play other game\n\t[ESC] Exit", gameType[currentGameTypeIndex]);
            inputKey = ReadKey(true);
            if (inputKey.Key == ConsoleKey.D1)
            {
                game = new GameRPS();
                game.PlayGame();
                gamesRecord += game.gamesRecord;
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                game = new GameRPS(true);
                game.PlayGame();
                gamesRecord += game.gamesRecord;
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                DisplayWelcomeMessage(false);
            }
            else if (inputKey.Key == ConsoleKey.D4)
            {
                gamesRecord.DisplayGamesHistory();
            }
            else if (inputKey.Key == ConsoleKey.D5)
            {
                currentGameTypeIndex = (currentGameTypeIndex + 1) % gameType.Length;
                continue;
            }
            else { continue; }
            WriteLine ("(click any key to continue)");
            ReadKey(true);
        }
        while (inputKey.Key != ConsoleKey.Escape);
    }
}