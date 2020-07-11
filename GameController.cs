using System;
using System.Collections.Generic;
using static System.Console;
class GameController
{
    string[] gameType = { "RPS", "Almost Black Jack" };
    int currentGameTypeIndex = 0;
    Game game;
    GamesRecord gamesRecord;

    public GameController()
    {
        gamesRecord = new GamesRecord(100);
    }


    public void DisplayRules(bool withWelcomeMessage = true)
    {
        if (withWelcomeMessage)
        {
            WriteLine("Welcome to a {0} game!", Game.GameName);
        }
        WriteLine(Game.GameRules);
    }

    public void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Console.Clear();
            WriteLine("Game Menu - Current game [{0}]:\n[1] Player vs Player\n[2] Player vs AI\n[3] Show rules\n[4] Display last games' record\n[5] Duel Mode\n[6] Change game\n[ESC] Exit", gameType[currentGameTypeIndex]);

            inputKey = Console.ReadKey(true);

            if (inputKey.Key == ConsoleKey.D1)
            {
                if (gameType[currentGameTypeIndex] == "RPS")
                    game = new GameRPS();
                else if (gameType[currentGameTypeIndex] == "Almost Black Jack")
                    game = new GameAlmostBlackJack();
                else
                    throw new ArgumentException("No such game");

                game.PlayGame();
                gamesRecord += game.gamesRecord;
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                if (gameType[currentGameTypeIndex] == "RPS")
                    game = new GameRPS(true);
                else if (gameType[currentGameTypeIndex] == "Almost Black Jack")
                    game = new GameAlmostBlackJack(true);
                else
                    throw new ArgumentException("No such game");

                game.PlayGame();
                gamesRecord += game.gamesRecord;
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                DisplayRules(false); // false to not display the "Welcome.." part
            }
            else if (inputKey.Key == ConsoleKey.D4)
            {
                gamesRecord.DisplayGamesHistory();
            }
            else if (inputKey.Key == ConsoleKey.D5)
            {
                if (gameType[currentGameTypeIndex] == "RPS")
                    game = new GameRPS(true);
                else if (gameType[currentGameTypeIndex] == "Almost Black Jack")
                    game = new GameAlmostBlackJack(true);
                else
                    throw new ArgumentException("No such game");
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
