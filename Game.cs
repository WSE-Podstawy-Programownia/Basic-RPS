using System;
using static System.Console;

class Game
{
    Player playerOne, playerTwo;
    GameRecord gameRecord;
    public Game()
    {
        playerOne = new Player();
        playerTwo = new Player();
        gameRecord = new GameRecord();
        MainMenuLoop();
    }
    public void DisplayRules(bool withWelcomeMessage = true)
    {
        if (withWelcomeMessage)
        {
            WriteLine("Welcome to a simple Rock-Paper-Scissors game!");
        }
        WriteLine("The rules are very simple - each player chooses Rock, Paper or Scissors, the choice is made by entering its number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both players choise is made, the winner is determined. After each game the application will ask the player if they want to continue, and if the player repond with anything else than [y]es than the game ends and the record of the last up to 10 games is presented.\n\nHave fun!");
    }
    public string GetPlayerInput(Player player)
    {
        string rawInput;
        string properInput;
        WriteLine("Choose one: \n1 - Rock\n2 - Paper\n3 - Scissors");
        rawInput = ReadLine();
        while (rawInput != "1" && rawInput != "2" && rawInput != "3")
        {
            WriteLine("Wrong input. Please enter correct one.\nChoose one:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = ReadLine();
        }

        if (rawInput == "1") { properInput = "Rock"; }
        else if (rawInput == "2") { properInput = "Paper"; }
        else { properInput = "Scissors"; }

        WriteLine("Player " + player.playerName + " choose " + properInput);

        return properInput;
    }
    public string DetermineWinner(Player playerOne, string playerOneInput, Player playerTwo, string playerTwoInput)
    {
        if (playerOneInput == playerTwoInput)
        {
            WriteLine("It's a draw!");
            return "Draw";
        }
        else if ((playerOneInput == "Rock" && playerTwoInput == "Scissors") ||
         (playerOneInput == "Paper" && playerTwoInput == "Rock") ||
         (playerOneInput == "Scissors" && playerTwoInput == "Paper"))
        {
            string result = "Player " + playerOne.playerName + " won!";
            Console.WriteLine(result);
            return result;
        }
        else
        {
            string result = "Player " + playerTwo.playerName + " won!";
            Console.WriteLine(result);
            return result;
        }
    }
    public void PlayGame()
    {
        Clear();
        string firstPlayerChoiceString = GetPlayerInput(playerOne);

        Clear();
        string secondPlayerChoiceString = GetPlayerInput(playerTwo);

        Clear();
        string gameResult = DetermineWinner(playerOne, firstPlayerChoiceString, playerTwo, secondPlayerChoiceString);

        gameRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult);

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            PlayGame();
        }
    }
    public void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Game Score\n\t[ESC] Exit");
            inputKey = ReadKey(true);
            if (inputKey.Key == ConsoleKey.D1)
            {
                PlayGame();
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                DisplayRules(false);
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                gameRecord.DisplayGameHistory();
            }
            else { continue; }
            WriteLine("(click any key to continue)");
            ReadKey(true);
        }
        while (inputKey.Key != ConsoleKey.Escape);
    }
}
