using System;
using static System.Console;

class Player
{
    private const int maxPlayerNameLength = 20;
    public string playerName;
    
    public Player(string playerName)
    {
        this.playerName = playerName;
    }
    
    public Player()
    {
        SetPlayerName();
    }
    
    public void SetPlayerName()
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
}
