using System;
using static System.Console;

class Player
{
    private const int maxPlayerNameLength = 20;
    public string playerName;
    private bool isAi;

    public static Player CreateHumanPlayer()
    {
        var player = new Player();
        player.SetPlayerName();
        player.isAi = false;
        return player;
    }

    public static Player CreateAiPlayer()
    {
        var player = new Player();
        player.playerName = "Computer";
        player.isAi = true;
        return player;
    }
    
    private Player()
    {        
    }
    
    private void SetPlayerName()
    {
        Write("Please enter player name: ");
        var newPlayerName = ReadLine();
        if (String.IsNullOrWhiteSpace(newPlayerName) || newPlayerName.Length > maxPlayerNameLength)
        {
            WriteLine($"Player name cannot be empty or have more than {maxPlayerNameLength} characters.");
            SetPlayerName();
        }
        else
        {
            playerName = newPlayerName;
        }
    }

    public string GetPlayerInput()
    { 
        if (isAi)
        {
            return GetAiInput();
        }
        else
        {
            return GetHumanPlayerInput();
        }
    }

    private string GetHumanPlayerInput()
    {
        string rawInput;
        string properInput;
        WriteLine($"{playerName}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
        while (rawInput != "1" && rawInput != "2" && rawInput != "3")
        {
            WriteLine($"Wrong input. Please enter correct one.\n{playerName}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = ReadLine();
        }
        return ConvertChoiceIntToChoiceString(Int32.Parse(rawInput));
    }

    private string GetAiInput()
    {
        return ConvertChoiceIntToChoiceString(new Random().Next(1,4));
    }

    private string ConvertChoiceIntToChoiceString(int choice)
    {
        if (choice == 1) { return "Rock"; }
        else if (choice == 2) { return "Paper"; }
        else { return "Scissors"; }        
    }
}
