using System;
using static System.Console;

class Game
{
    Player playerOne, playerTwo;
    GamesRecord gamesRecord;

    public Game()
    {
        playerOne = new Player();
        playerTwo = new Player();
        gamesRecord = new GamesRecord();
        MainMenuLoop();
    }

    public Game(string playerOneName, string playerTwoName, int gamesRecordSize)
    {
        playerOne = new Player(playerOneName);
        playerTwo = new Player(playerTwoName);
        gamesRecord = new GamesRecord(gamesRecordSize);
        MainMenuLoop();
    }

    public void DisplayRules(bool withWelcomeMessage = true)
    {
        if (withWelcomeMessage)
        {
            WriteLine("Welcome to a simple Rock-Paper-Scissors game!");
        }
        WriteLine("The rules are very simple - each player chooses Rock, Paper or Scissors by pressing the button of their choice:\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirming it by pressing Enter.\n\nAfter both players have chosen, the winner is determined. After each game the application will ask the players if they want to continue, and if the player reponds with anything else than [y]es, the game ends and presents the record of the last up to 10 games.\n\nHave fun!\n");
    }

    public string GetPlayerInput(Player player)
    {
        string rawInput;
        string properInput;
        WriteLine($"{player.playerName}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
        while (rawInput != "1" && rawInput != "2" && rawInput != "3")
        {
            WriteLine($"Wrong input. Please enter correct one.\n{player.playerName}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = ReadLine();
        }
        if (rawInput == "1") { properInput = "Rock"; }
        else if (rawInput == "2") { properInput = "Paper"; }
        else { properInput = "Scissors"; }
        return properInput;
    }

    public string DetermineWinner(string playerOneChoice, string playerTwoChoice)
    {
        if (playerOneChoice == playerTwoChoice)
        {
            WriteLine("It's a draw!");
            return "Draw";
        }
        else if ((playerOneChoice == "Rock" && playerTwoChoice == "Scissors") ||
                (playerOneChoice == "Paper" && playerTwoChoice == "Rock") ||
                (playerOneChoice == "Scissors" && playerTwoChoice == "Paper"))
        {
            WriteLine($"{playerOne.playerName} wins!");
            return $"{playerOne.playerName} wins!";
        }
        else
        {
            WriteLine($"{playerTwo.playerName} wins!");
            return $"{playerTwo.playerName} wins!";
        }
    }

    public void Play()
    {
        Clear();
        string firstPlayerChoiceString = GetPlayerInput(playerOne);

        Clear();
        string secondPlayerChoiceString = GetPlayerInput(playerTwo);

        Clear();

        string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);
        gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult);

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
                DisplayRules(false);
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