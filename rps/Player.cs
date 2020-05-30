using System;
class Player
{
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
        Console.WriteLine("Please choose your name");
        playerName = Console.ReadLine();

    }
}
