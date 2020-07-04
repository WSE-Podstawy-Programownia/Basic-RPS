using System;
using System.Collections.Generic;
using static System.Console;
class GameController
{
    string[] gameType = { "RPS", "???" };
    int currentGameTypeIndex = 0;
    Game game;
    GamesRecord gamesRecord;

    Dictionary<ConsoleKey, string> menuOptions = new Dictionary<ConsoleKey, string>()
    {
        {ConsoleKey.D1, "Player vs Player"},
        {ConsoleKey.D2, "Player vs AI"},
        {ConsoleKey.D3, "Show rukes"},
        {ConsoleKey.D4, "Display the record of recent games"},
        {ConsoleKey.D5, "Duel Mode"},
        {ConsoleKey.Escape, "Exit"},
    };

    public GameController()
    {
        gamesRecord = new GamesRecord(100);
    }


    public void DisplayRules(Game game, bool withWelcomeMessage = true)
    {
        if (withWelcomeMessage)
        {
            WriteLine("Welcome to a {0} game!", game.GameName);
        }
        WriteLine(game.GameRules);
    }

    public void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Console.Clear();
            WriteLine("Game Menu - Current game [{0}]:\n[1] Player vs Player\n[2] Player vs AI\n[3] Show rules\n[4] Display last games' record\n[5] Change game\n[ESC] Exit", gameType[currentGameTypeIndex]);

            inputKey = Console.ReadKey(true);

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
                DisplayRules(game, false); // false to not display the "Welcome.." part

            }
            else if (inputKey.Key == ConsoleKey.D4)
            {
                gamesRecord.DisplayGamesHistory();
            }
            else if (inputKey.Key == ConsoleKey.D5)
            {
                game = new GameRPS();
                game.DuelMode();
            }
            else if (inputKey.Key == ConsoleKey.D6)
            {
                currentGameTypeIndex = (currentGameTypeIndex + 1) % gameType.Length;
                continue;
            }

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();

        } while (inputKey.Key != ConsoleKey.Escape);
    }
}
