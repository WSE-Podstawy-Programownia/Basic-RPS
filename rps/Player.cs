using System;
class Player
{
    public string playerName;

    private readonly int maxNameLength = 20;

    public void SetPlayerName()
    {
        Console.Write("Enter your name:");
        playerName = Console.ReadLine();
        if (playerName.Length > maxNameLength || playerName.Length == 0)
        {
            throw new Exception("Invalid player name.");
        }
    }

    // public string playerName;
    public Player(string playerName)
    {
        this.playerName = playerName;
    }
    public Player()
    {
        SetPlayerName();
    }

}
