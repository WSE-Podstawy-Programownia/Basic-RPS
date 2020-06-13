using System;
using static System.Console;

class Game
{
    bool aiPlayer;
    Player playerOne, playerTwo;
    GamesRecord gamesRecord;

    private const int PLAYER_HEALTH = 100, PLAYER_STRENGTH = 50;

    public Game()
    {
        DisplayWelcome();
        playerOne = Player.CreateHumanPlayer(PLAYER_HEALTH, PLAYER_STRENGTH);
        if (aiPlayer)
        {
            playerTwo = Player.CreateAiPlayer(PLAYER_HEALTH, PLAYER_STRENGTH);
        }
        else
        {
            playerTwo = Player.CreateHumanPlayer(PLAYER_HEALTH, PLAYER_STRENGTH);
        }
        gamesRecord = new GamesRecord();
        MainMenuLoop();
    }

    public void DisplayRules()
    {
        Clear();
        WriteLine("The rules are very simple - each player chooses Rock, Paper or Scissors by pressing the button of their choice:\n" +
            "[1] Rock\n[2] Paper\n[3] Scissors\nand confirming it by pressing Enter.\n" +
            "\nAfter both players have chosen, the winner is determined. " +
            "After each game the application will ask the players if they want to continue, " +
            "and if the player reponds with anything else than [y]es, " +
            $"the game ends and presents the record of the last up to {gamesRecord.gamesRecordSize} games.\n\n" +
            "Have fun!\n");
    }

    public void DisplayWelcome()
    {
        WriteLine("Welcome to a simple Rock-Paper-Scissors game!");
        WriteLine("Do you want to play with the computer? yes - [y], no - [n]");
        aiPlayer = ReadKey(true).Key != ConsoleKey.N;

    }

    public string DetermineWinner(string playerOneChoice, string playerTwoChoice)
    {
        string result;
        if (playerOneChoice == playerTwoChoice)
        {
            WriteLine("It's a draw!");
            result = "Draw";
        }
        else if ((playerOneChoice == "Rock" && playerTwoChoice == "Scissors") ||
                (playerOneChoice == "Paper" && playerTwoChoice == "Rock") ||
                (playerOneChoice == "Scissors" && playerTwoChoice == "Paper"))
        {                                    
            result = Skirmish(playerOne, playerTwo);
        }
        else
        {
            result = Skirmish(playerTwo, playerOne);
        }
        PrintHealthBars();
        return result;
    }

    private string Skirmish(Player winner, Player loser)
    {
        var hitStrength = winner.GetHitStrength();
        loser.TakeHit(hitStrength);
        var result = $"{winner.Name} wins! {loser.Name} took {hitStrength} hit points, health drops to {loser.Health}";            
        WriteLine(result);
        return result;
    }

    private void PrintHealthBars()
    {
        WriteLine($"{playerOne.Name} health: {playerOne.Health}");
        WriteLine($"{playerTwo.Name} health: {playerTwo.Health}");
    }

    public void Play()
    {
        Clear();
        string playerOneChoiceString = playerOne.GetPlayerInput();

        Clear();
        string playerTwoChoiceString = playerTwo.GetPlayerInput();

        Clear();

        WriteLine($"{playerOne.Name} chose {playerOneChoiceString}, {playerTwo.Name} chose {playerTwoChoiceString}.");
        string gameResult = DetermineWinner(playerOneChoiceString, playerTwoChoiceString);
        gamesRecord.AddRecord(playerOneChoiceString, playerTwoChoiceString, gameResult);

        if (playerOne.IsDead() || playerTwo.IsDead())
        {
            WriteLine("Game finished!");
            gamesRecord.DisplayGamesHistory();
            WriteLine("Press any key...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Play();
        }
    }

    public void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Rock-Paper-Scissors Menu:\n\t[1] Play\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
            inputKey = ReadKey(true);
            if (inputKey.Key == ConsoleKey.D1)
            {
                Play();
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                DisplayRules();
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                gamesRecord.DisplayGamesHistory();
            }
            else { continue; }
            WriteLine("(Press any key to continue)");
            ReadKey(true);
        } while (inputKey.Key != ConsoleKey.Escape);
    }

}