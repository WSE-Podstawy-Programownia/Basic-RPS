using System;
using static System.Console;
using System.Collections.Generic;
class GameDice : Game
{
    Random random;
    public GameDice(bool singleplayer = false)
    {

        GameName = "Dice";
        GameRules = "The rules are very simple - each player rolls a die, and the higher number wins.";
        inputTable = new Dictionary<string, string>()
        {
            {"1", "Roll"},
        };

        while (true)
        {
            try
            {
                playerOne = new Player();
            }
            catch (Exception e)
            {
                continue;
            }
            break;
        }

        while (true)
        {
            try
            {
                if (singleplayer) playerTwo = new AIPlayer();
                else playerTwo = new Player();
            }
            catch (Exception e)
            {
                continue;
            }
            break;
        }


        gamesRecord = new GamesRecord();

        random = new Random();
    }

    public override void Play()
    {
        WriteLine($"{playerOne.PlayerName}: Roll the die.");
        playerOne.GetInput(inputTable);
        int playerOneChoice = random.Next(7);
        WriteLine($"{playerTwo.PlayerName}: Roll the die.");
        playerTwo.GetInput(inputTable);
        int playerTwoChoice = random.Next(7);

        string winner = DetermineWinner(playerOneChoice, playerTwoChoice);

        WriteLine($"{playerOne.PlayerName} rolled {playerOneChoice}.");
        WriteLine($"{playerTwo.PlayerName} rolled {playerTwoChoice}.");
        WriteLine($"Winner: {winner}");

        gamesRecord.AddRecord(new RecordDice(playerOneChoice.ToString(), playerTwoChoice.ToString(), winner));
        
        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Play();
        }
    }

    private string DetermineWinner(int playerOneChoice, int playerTwoChoice)
    {
        if (playerOneChoice > playerTwoChoice)
        {
            return playerOne.PlayerName + " won.";
        }
        else if (playerTwoChoice > playerOneChoice)
        {
            return playerTwo.PlayerName + " won.";
        }
        else
        {
            return "Draw";
        }
    }
}