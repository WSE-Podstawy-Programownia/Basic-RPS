using System;
using static System.Console;

class GameController
{
    string[] gameType = {"RPS","???"};
    int currentGameTypeIndex = 0;
    Game game;
    GameRecord gameRecord;
    public GameController()
    {
        gameRecord = new GameRecord();
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
            Clear();
            WriteLine("Game Menu - Current game [{0}]:\n[1] Player vs Player\n[2] Player vs Computer\n[3] Show rules\n[4] Game Score\n[5] Change game[ESC] Exit", gameType[currentGameTypeIndex]);
            inputKey = ReadKey(true);
            if (inputKey.Key == ConsoleKey.D1)
            {
                game = new GameRPS();
                game.Play();
                gameRecord += game.gameRecord;
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                game = new GameRPS(true);
                game.Play();
                gameRecord += game.gameRecord;
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                DisplayRules(game,false);
            }
            else if (inputKey.Key == ConsoleKey.D4)
            {
                gameRecord.DisplayGameHistory();
            }
            else if (inputKey.Key == ConsoleKey.D5)
            {
                currentGameTypeIndex = (currentGameTypeIndex + 1) % gameType.Length;
                continue;
            }
            else { continue; }
            WriteLine("(click any key to continue)");
            ReadKey(true);
        }
        while (inputKey.Key != ConsoleKey.Escape);
    }
}