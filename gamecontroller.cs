using System;
using static System.Console;
class GameController
{
    string[] gameType = { "RPS", "Dice" };
    int currentGameTypeIndex = 0;

    Game game;
    GamesRecord gamesRecord;
    public GameController()
    {
        gamesRecord = new GamesRecord(100);
    }

    public void DisplayRules(Game game, bool withWelcomeMessage = true)
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
            Clear();
            WriteLine($"Game Menu - Current game [{gameType[currentGameTypeIndex]}]:\n[1] Player vs Player\n[2] Player vs AI\n[3] Show rules\n[4] Display last games' record\n[5] Change game\n[ESC] Exit");
            inputKey = ReadKey(true);
            if (inputKey.Key == ConsoleKey.D1)
            {
                if (gameType[currentGameTypeIndex] == "RPS")
                    game = new GameRPS();
                else if (gameType[currentGameTypeIndex] == "Dice")
                    game = new GameDice();
                else
                    throw new ArgumentException("No such game");
                game.Play();
                gamesRecord += game.gamesRecord;
            }
            if (inputKey.Key == ConsoleKey.D2)
            {
                if (gameType[currentGameTypeIndex] == "RPS")
                    game = new GameRPS(true);
                else if (gameType[currentGameTypeIndex] == "Dice")
                    game = new GameDice(true);
                else
                    throw new ArgumentException("No such game");
                game.Play();
                gamesRecord += game.gamesRecord;
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                DisplayRules(game, false);
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
            WriteLine("(click any key to continue)");
            ReadKey(true);
        } while (inputKey.Key != ConsoleKey.Escape);
    }
}